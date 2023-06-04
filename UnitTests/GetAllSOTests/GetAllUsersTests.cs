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
    public class GetAllUsersTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void GetAllUsers_Success()
        {
            // Arrange
            so = new GetAllUsersSO();
            var users = new List<IDomainObject>();
            repoMock.Setup(e => e.GetAll(It.IsAny<User>())).Returns(users);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.GetAll(It.IsAny<User>()), Times.Once);
        }
    }
}