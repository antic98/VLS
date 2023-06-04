using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.SearchSO;

namespace UnitTests.SearchSOTests
{
    [TestClass]
    public class SearchTeamTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void SearchTeam_Success()
        {
            // Arrange
            var team = new Team
            {
                Search = "Partizan"
            };
            var teams = new List<IDomainObject> { team };
            repoMock.Setup(e => e.Search(team)).Returns(teams);

            so = new SearchTeamSO(team);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Search(It.IsAny<Team>()), Times.Exactly(1));
        }
        
        [TestMethod]
        public void SearchTeam_TeamNullException()
        {
            // Arrange
            so = new SearchTeamSO(null);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Search(It.IsAny<Team>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void SearchTeam_SearchNullException()
        {
            // Arrange
            var team = new Team();
            so = new SearchTeamSO(team);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Search(It.IsAny<Team>()), Times.Exactly(0));
        }
    }
}