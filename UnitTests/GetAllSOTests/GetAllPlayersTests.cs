using System.Collections.Generic;
using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.GetSO;

namespace UnitTests.GetSOTests
{
    [TestClass]
    public class GetPlayerTests
    {
        private readonly Mock<IRepository<IDomainObject>> _repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void GetAllPlayers_Success()
        {
            // Arrange
            var players = new List<Player>()
            {
                new Player(1, "a", "a", new Position(), new Country(), new Team())
            };

            _repoMock.Setup(e => e.GetAll(It.IsAny<Player>())).Returns(players.Cast<IDomainObject>().ToList());
            
            // Act
            so = new GetAllPlayersSO();
            so.ExecuteTemplate(_repoMock.Object);

            // Assert
            Assert.AreEqual(players[0], ((GetAllPlayersSO)so).Result[0]);
            //_repoMock.Verify(e => e.GetAll(It.IsAny<Player>()), Times.Once);
        }
        
    }
}
