using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.UpdateSO;

namespace UnitTests.UpdateSOTests
{
    [TestClass]
    public class UpdatePlayerTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void UpdatePlayer_Success()
        {
            // Arrange
            var team1 = new Team { ID = 1 };
            var team2 = new Team { ID = 2 };
            
            var player = new Player(1, "Aleksandar", "Antic", new Position(), new Country(), team1);
            var updatedPlayer = new Player(1, "Aleksandar", "Antic", new Position(), new Country(), team2);

            var stats = new List<IDomainObject>
            {
                new Stats(new Game(), player, 5),
                new Stats(new Game(), player, 7),
                new Stats(new Game(), new Player(), 10),
                new Stats(new Game(), player, 3),
            };
            
            repoMock.Setup(e => e.GetAll(It.IsAny<Stats>())).Returns(stats);
            repoMock.Setup(e => e.GetObject(updatedPlayer)).Returns(player);
            
            so = new UpdatePlayerSO(updatedPlayer);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.GetObject(It.IsAny<Player>()), Times.Exactly(1));
            repoMock.Verify(e => e.GetAll(It.IsAny<Stats>()), Times.Exactly(1));
            repoMock.Verify(e => e.Delete(It.IsAny<Stats>()), Times.Exactly(3));
            repoMock.Verify(e => e.Update(It.IsAny<Player>()), Times.Exactly(1));
        }
        
        [TestMethod]
        public void UpdatePlayer_PlayerNullException()
        {
            // Arrange
            so = new UpdatePlayerSO(null);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Player>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void UpdatePlayer_NameNullException()
        {
            // Arrange
            var player = new Player(null, "Antic", new Position(), new Country(), new Team());
            so = new UpdatePlayerSO(player);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Player>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void UpdatePlayer_SurnameNullException()
        {
            // Arrange
            var player = new Player("Aleksandar", null, new Position(), new Country(), new Team());
            so = new UpdatePlayerSO(player);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Player>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void UpdatePlayer_PositionNullException()
        {
            // Arrange
            var player = new Player("Aleksandar", "Antic", null, new Country(), new Team());
            so = new UpdatePlayerSO(player);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Player>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void UpdatePlayer_CountryNullException()
        {
            // Arrange
            var player = new Player("Aleksandar", "Antic", new Position(), null, new Team());
            so = new UpdatePlayerSO(player);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Player>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void UpdatePlayer_TeamNullException()
        {
            // Arrange
            var player = new Player("Aleksandar", "Antic", new Position(), new Country(), null);
            so = new UpdatePlayerSO(player);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Player>()), Times.Exactly(0));
        }
    }
}