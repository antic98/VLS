using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.AddSO;

namespace UnitTests.AddSOTests
{
    [TestClass]
    public class AddTeamTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void AddTeam_Success()
        {
            //Arrange
            var team = new Team("Partizan", "Belgrade", "black-white");
            so = new AddTeamSO(team);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Team>()), Times.Exactly(1));
        }

        [TestMethod]
        public void AddTeam_NameNullException()
        {
            //Arrange
            var team = new Team(null, "Belgrade", "black-white");
            so = new AddTeamSO(team);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Team>()), Times.Exactly(0));
        }

        [TestMethod]
        public void AddTeam_CityNullException()
        {
            //Arrange
            var team = new Team("Partizan", null, "black-white");
            so = new AddTeamSO(team);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Team>()), Times.Exactly(0));
        }

        [TestMethod]
        public void AddTeam_ColorNullException()
        {
            //Arrange
            var team = new Team("Partizan", "Belgrade", null);
            so = new AddTeamSO(team);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Team>()), Times.Exactly(0));
        }

        
    }
}
