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
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void AddGamesDouble_Success()
        {
            // Arrange
            var teams = new List<Team>
            {
                new Team(), new Team(), new Team(), new Team()
            };
            so = new AddGamesDoubleSO(teams);
            
            // Act
            so.ExecuteTemplate(repoMock.Object);
            
            // Assert
            repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(12));
        }

        [TestMethod]
        public void AddGamesDouble_OddNumberOfTeamsException()
        {
            // Arrange
            var teams = new List<Team>
            {
                new Team(), new Team(), new Team()
            };
            so = new AddGamesDoubleSO(teams);
            
            // Act
            so.ExecuteTemplate(repoMock.Object);
            
            // Assert
            repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void AddGamesDouble_EmptyTeamsException()
        {
            // Arrange
            var teams = new List<Team>();
            so = new AddGamesDoubleSO(teams);
            
            // Act
            so.ExecuteTemplate(repoMock.Object);
            
            // Assert
            repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(0));
        }
    }
}
