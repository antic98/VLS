using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.GetAllSO;

namespace UnitTests.GetAllSOTests
{
    [TestClass]
    public class GetAllTeamsTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void GetAllTeams_Success()
        {
            // Arrange
            so = new GetAllTeamsSO();
            var teams = new List<IDomainObject>();
            repoMock.Setup(e => e.GetList(It.IsAny<Team>())).Returns(teams);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.GetList(It.IsAny<Team>()), Times.Once);
        }
    }
}