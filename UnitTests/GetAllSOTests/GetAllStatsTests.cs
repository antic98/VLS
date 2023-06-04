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
    public class GetAllStatsTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void GetAllStats_Success()
        {
            // Arrange
            so = new GetAllStatsSO();
            var stats = new List<IDomainObject>();
            repoMock.Setup(e => e.GetAll(It.IsAny<Stats>())).Returns(stats);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.GetAll(It.IsAny<Stats>()), Times.Once);
        }
    }
}