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
    public class GetAllCountriesTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void GetAllCountries_Success()
        {
            // Arrange
            so = new GetAllCountriesSO();
            var countries = new List<IDomainObject>();
            repoMock.Setup(e => e.GetList(It.IsAny<Country>())).Returns(countries);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.GetList(It.IsAny<Country>()), Times.Once);
        }
    }
}