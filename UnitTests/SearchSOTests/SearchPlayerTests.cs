using System.Collections.Generic;
using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.SearchSO;

namespace UnitTests.SearchSOTests
{
    [TestClass]
    public class SearchPlayerTests
    {
        private readonly Mock<IRepository<IDomainObject>> _repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void SearchPlayer_Success()
        {
            // Arrange
            var player = new Player(1, "a", "a", new Position(), new Country(), new Team());
            var players = new List<Player>() { player };

            _repoMock.Setup(e => e.Search(player)).Returns(players.Cast<IDomainObject>().ToList());
            
            // Act
            so = new SearchPlayerSO(player);
            so.ExecuteTemplate(_repoMock.Object);

            // Assert
            Assert.AreEqual(players[0], ((SearchPlayerSO)so).Result[0]);
            //_repoMock.Verify(e => e.GetAll(It.IsAny<Player>()), Times.Once);
        }
        
        [TestMethod]
        public void SearchPlayer_WhenPlayerNullException()
        {
            // Arrange
            _repoMock.Setup(e => e.Search(null)).Returns((List<IDomainObject>)null);
            
            // Act
            so = new SearchPlayerSO(null);
            so.ExecuteTemplate(_repoMock.Object);

            // Assert
            Assert.AreEqual(null, ((SearchPlayerSO)so).Result);
            //_repoMock.Verify(e => e.GetAll(It.IsAny<Player>()), Times.Once);
        }
        
        [TestMethod]
        public void SearchPlayer_WhenPlayerNameNullException()
        {
            // Arrange
            var player = new Player(1, null, "a", new Position(), new Country(), new Team());

            _repoMock.Setup(e => e.Search(player)).Returns((List<IDomainObject>)null);
            
            // Act
            so = new SearchPlayerSO(null);
            so.ExecuteTemplate(_repoMock.Object);

            // Assert
            Assert.AreEqual(null, ((SearchPlayerSO)so).Result);
            //_repoMock.Verify(e => e.GetAll(It.IsAny<Player>()), Times.Once);
        }
        
    }
}