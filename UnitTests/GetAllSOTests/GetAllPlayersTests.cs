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
    public class GetAllPlayersTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void GetAllPlayers_Success()
        {
            // Arrange
            so = new GetAllPlayersSO();
            var players = new List<IDomainObject>();
            repoMock.Setup(e => e.GetAll(It.IsAny<Player>())).Returns(players);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.GetAll(It.IsAny<Player>()), Times.Once);
        }
    }
}
