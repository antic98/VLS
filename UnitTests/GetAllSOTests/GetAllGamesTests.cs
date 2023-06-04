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
    public class GetAllGamesTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void GetAllGames_Success()
        {
            // Arrange
            so = new GetAllGamesSO();
            var games = new List<IDomainObject>();
            repoMock.Setup(e => e.GetAll(It.IsAny<Game>())).Returns(games);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.GetAll(It.IsAny<Game>()), Times.Once);
        }
    }
}