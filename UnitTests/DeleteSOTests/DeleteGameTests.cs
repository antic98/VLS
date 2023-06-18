using System;
using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.DeleteSO;

namespace UnitTests.DeleteSOTests
{
    [TestClass]
    public class DeleteGameTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void DeleteGame_Played_Success()
        {
            // Arrange
            var team1 = new Team { ID = 1 };
            var team2 = new Team { ID = 2 };

            var player1 = new Player(1, "", "", new Position(), new Country(), team1);
            var player2 = new Player(2, "", "", new Position(), new Country(), team2);
            
            var game = new Game(1, team1, team2, DateTime.Now)
            {
                GoalsHost = 5,
                GoalsGuest = 3
            };
                
            var stats = new List<IDomainObject>
            {
                new Stats(game, player1, 5),
                new Stats(game, player2, 7),
                new Stats(new Game(), new Player(), 10)
            };

            var players = new List<IDomainObject>
            {
                player1, player2
            };
            
            repoMock.Setup(e => e.GetList(It.IsAny<Stats>())).Returns(stats);
            repoMock.Setup(e => e.GetList(It.IsAny<Player>())).Returns(players);
            repoMock.Setup(e => e.GetObject(player1)).Returns(player1);
            repoMock.Setup(e => e.GetObject(player2)).Returns(player2);
            repoMock.Setup(e => e.GetObject(team1)).Returns(team1);
            repoMock.Setup(e => e.GetObject(team2)).Returns(team2);
            
            so = new DeleteGameSO(game);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.GetList(It.IsAny<Stats>()), Times.Exactly(1));
            repoMock.Verify(e => e.GetObject(It.IsAny<Player>()), Times.Exactly(2));
            repoMock.Verify(e => e.Update(It.IsAny<Player>()), Times.Exactly(2));
            repoMock.Verify(e => e.Delete(It.IsAny<Stats>()), Times.Exactly(2));
            repoMock.Verify(e => e.GetObject(It.IsAny<Team>()), Times.Exactly(2));
            repoMock.Verify(e => e.Update(It.IsAny<Team>()), Times.Exactly(2));
            repoMock.Verify(e => e.Delete(It.IsAny<Game>()), Times.Exactly(1));
        }
        
        [TestMethod]
        public void DeleteGame_NotPlayed_Success()
        {
            // Arrange
            var game = new Game
            {
                GoalsHost = -1,
                GoalsGuest = -1
            };
            so = new DeleteGameSO(game);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Game>()), Times.Exactly(1));
        }
        
        [TestMethod]
        public void DeleteGame_GameNullException()
        {
            // Arrange
            so = new DeleteGameSO(null);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Game>()), Times.Exactly(0));
        }
    }
}