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
    public class AddGamesSingleTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void AddGamesSingle_Success()
        {
            // Arrange
            var teams = new List<Team>
            {
                new Team(), new Team(), new Team(), new Team()
            };
            so = new AddGamesSingleSO(teams);
            
            // Act
            so.ExecuteTemplate(repoMock.Object);
            
            // Assert
            repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(6));
        }

        [TestMethod]
        public void AddGamesSingle_OddNumberOfTeamsException()
        {
            // Arrange
            var teams = new List<Team>
            {
                new Team(), new Team(), new Team()
            };
            so = new AddGamesSingleSO(teams);
            
            // Act
            so.ExecuteTemplate(repoMock.Object);
            
            // Assert
            repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void AddGamesSingle_EmptyTeamsException()
        {
            // Arrange
            var teams = new List<Team>();
            so = new AddGamesSingleSO(teams);
            
            // Act
            so.ExecuteTemplate(repoMock.Object);
            
            // Assert
            repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(0));
        }
    }
}