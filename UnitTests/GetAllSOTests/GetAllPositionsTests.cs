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
    public class GetAllPositionsTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void GetAllPositions_Success()
        {
            // Arrange
            so = new GetAllPositionsSO();
            var positions = new List<IDomainObject>();
            repoMock.Setup(e => e.GetList(It.IsAny<Position>())).Returns(positions);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.GetList(It.IsAny<Position>()), Times.Once);
        }
    }
}