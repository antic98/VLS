using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using Xunit;

namespace UnitTests
{
    [TestClass]
    public class AddPlayerTests
    {
        private readonly Mock<IRepository<IDomainObject>> _repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        //[Fact]
        public void PlayerAdded()
        {
            //Arrange
            Position position = new Position()
            {
                ID = 1,
                Name = "CENTAR"
            };

            Country country = new Country()
            {
                ID = 1,
                Name = "CENTAR"
            };

            Team team = new Team()
            {
                ID = 1,
                Name = "CENTAR",
                City = "Belgrade",
                Color = "black"
            };

            Player player = new Player()
            {
                Name = "AAA",
                Surname = "AAA",
                Position = position,
                Country = country,
                Team = team,
                Goals = 10
            };

            //Assert
            _repoMock.Setup(e => e.Add(player)).Returns(true);

            //Act
            so = new AddPlayerSO(player);
            so.ExecuteTemplate(_repoMock.Object);
            var response = ((AddPlayerSO)so).Result;

            Assert.IsTrue(response);
        }

        [TestMethod]
        public void PlayerAdded_PositionEmpty()
        {
            //Arrange
            Position position = new Position()
            {
                ID = 1,
                Name = "CENTAR"
            };

            Country country = new Country()
            {
                ID = 1,
                Name = "CENTAR"
            };

            Team team = new Team()
            {
                ID = 1,
                Name = "CENTAR",
                City = "Belgrade",
                Color = "black"
            };

            Player player = new Player()
            {
                //Name = "AAA",
                Surname = "AAA",
                Position = position,
                Country = country,
                Team = team,
                Goals = 10
            };

            //Assert
            _repoMock.Setup(e => e.Add(player)).Returns(false);

            //Act
            so = new AddPlayerSO(player);
            so.ExecuteTemplate(_repoMock.Object);
            var response = ((AddPlayerSO)so).Result;

            Assert.IsFalse(response);
        }
    }
}
