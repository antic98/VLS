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
    public class UpdateTeamTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void UpdateTeam_Success()
        {
            // Arrange
            var team = new Team("Partizan", "Belgrade", "black");
            
            repoMock.Setup(e => e.GetObject(team)).Returns(team);
            
            so = new UpdateTeamSO(team);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.GetObject(It.IsAny<Team>()), Times.Exactly(1));
            repoMock.Verify(e => e.Update(It.IsAny<Team>()), Times.Exactly(1));
        }
        
        [TestMethod]
        public void UpdateTeam_TeamNullException()
        {
            // Arrange
            so = new UpdateTeamSO(null);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Team>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void UpdateTeam_NameNullException()
        {
            // Arrange
            var team = new Team(null, "Belgrade", "black");
            so = new UpdateTeamSO(team);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Team>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void UpdateTeam_CityNullException()
        {
            // Arrange
            var team = new Team("Partizan", null, "black");
            so = new UpdateTeamSO(team);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Team>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void UpdateTeam_ColorNullException()
        {
            // Arrange
            var team = new Team("Partizan", "Belgrade", null);
            so = new UpdateTeamSO(team);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Team>()), Times.Exactly(0));
        }
    }
}