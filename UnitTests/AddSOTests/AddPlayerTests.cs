using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.AddSO;

namespace UnitTests.AddSOTests
{
    [TestClass]
    public class AddPlayerTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void AddPlayer_Success()
        {
            //Arrange
            var player = new Player("Aleksandar", "Antic", new Position(), new Country(), new Team());
            so = new AddPlayerSO(player);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Player>()), Times.Exactly(1));
        }

        [TestMethod]
        public void AddPlayer_NameNullException()
        {
            //Arrange
            var player = new Player(null, "Antic", new Position(), new Country(), new Team());
            so = new AddPlayerSO(player);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Player>()), Times.Exactly(0));
        }

        [TestMethod]
        public void AddPlayer_SurnameNullException()
        {
            //Arrange
            var player = new Player("Aleksandar", null, new Position(), new Country(), new Team());
            so = new AddPlayerSO(player);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Player>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void AddPlayer_PositionNullException()
        {
            //Arrange
            var player = new Player("Aleksandar", "Antic", null, new Country(), new Team());
            so = new AddPlayerSO(player);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Player>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void AddPlayer_CountryNullException()
        {
            //Arrange
            var player = new Player("Aleksandar", "Antic", new Position(), null, new Team());
            so = new AddPlayerSO(player);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Player>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void AddPlayer_TeamNullException()
        {
            //Arrange
            var player = new Player("Aleksandar", "Antic", new Position(), new Country(), null);
            so = new AddPlayerSO(player);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Player>()), Times.Exactly(0));
        }
    }
}
