using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.AddSO;

namespace UnitTests.AddSOTests
{
    [TestClass]
    public class AddGamesDoubleTests
    {
        private readonly Mock<IRepository<IDomainObject>> _repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void AddGamesDouble_Success()
        {
            // Arrange
            var teams = new List<Team>
            {
                new Team { ID = 1, Name = "Team 1" },
                new Team { ID = 2, Name = "Team 2" },
                new Team { ID = 3, Name = "Team 3" },
                new Team { ID = 4, Name = "Team 4" }
            };
            
            // Act
            so = new AddGamesDoubleSO(teams);
            so.ExecuteTemplate(_repoMock.Object);
            
            // Assert
            _repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(12));
        }

        [TestMethod]
        public void AddGamesDouble_OddNumberOfTeamsException()
        {
            // Arrange
            var teams = new List<Team>
            {
                new Team { ID = 1, Name = "Team 1" },
                new Team { ID = 2, Name = "Team 2" },
                new Team { ID = 3, Name = "Team 3" },
            };
            
            // Act
            so = new AddGamesDoubleSO(teams);
            so.ExecuteTemplate(_repoMock.Object);
            
            // Assert
            _repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void AddGamesDouble_EmptyTeamsException()
        {
            // Arrange
            var teams = new List<Team>();
            
            // Act
            so = new AddGamesDoubleSO(teams);
            so.ExecuteTemplate(_repoMock.Object);
            
            // Assert
            _repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(0));
        }
    }
}
