using System;
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
    public class UpdateGameTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void UpdateGame_Success()
        {
            // Arrange
            var team1 = new Team { ID = 1 };
            var team2 = new Team { ID = 2 };
            
            var player = new Player(1, "Aleksandar", "Antic", new Position(), new Country(), team1);
            
            var game = new Game(1, team1, team2, DateTime.Now)
            {
                GoalsHost = 5,
                GoalsGuest = 3,
            };
            
            var stats = new List<Stats>
            {
                new Stats(game, player, 5),
                new Stats(game, player, 7),
                new Stats(game, player, 3),
            };

            game.Stats = stats;

            repoMock.Setup(e => e.GetObject(player)).Returns(player);
            repoMock.Setup(e => e.GetObject(team1)).Returns(team1);
            repoMock.Setup(e => e.GetObject(team2)).Returns(team2);
            
            so = new UpdateGameSO(game);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Add(It.IsAny<Stats>()), Times.Exactly(3));
            repoMock.Verify(e => e.GetObject(It.IsAny<Player>()), Times.Exactly(3));
            repoMock.Verify(e => e.Update(It.IsAny<Player>()), Times.Exactly(3));
            repoMock.Verify(e => e.GetObject(It.IsAny<Team>()), Times.Exactly(2));
            repoMock.Verify(e => e.Update(It.IsAny<Team>()), Times.Exactly(2));
            repoMock.Verify(e => e.Update(It.IsAny<Game>()), Times.Exactly(1));
        }
        
        [TestMethod]
        public void UpdateGame_GameNullException()
        {
            // Arrange
            so = new UpdateGameSO(null);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Game>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void UpdateGame_HostNullException()
        {
            // Arrange
            var game = new Game(1, null, new Team(), DateTime.Now);
            so = new UpdateGameSO(game);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Game>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void UpdateGame_GuestNullException()
        {
            // Arrange
            var game = new Game(1, new Team(), null, DateTime.Now);
            so = new UpdateGameSO(game);
            
            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Game>()), Times.Exactly(0));
        }
    }
}