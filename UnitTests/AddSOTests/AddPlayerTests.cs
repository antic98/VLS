using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;

namespace UnitTests.AddSOTests
{
    [TestClass]
    public class AddPlayerTests
    {
        private readonly Mock<IRepository<IDomainObject>> _repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void AddPlayer_Success()
        {
            //Arrange
            Player player = new Player("Aleksandar", "Antic", new Position(), new Country(), new Team());

            //Assert
            _repoMock.Setup(e => e.Add(player)).Returns(true);

            //Act
            so = new AddPlayerSO(player);
            so.ExecuteTemplate(_repoMock.Object);
            var response = ((AddPlayerSO)so).Result;

            Assert.IsTrue(response);
            _repoMock.Verify(e => e.Add(It.IsAny<Player>()), Times.Exactly(1));
        }

        [TestMethod]
        public void AddPlayer_NameNullException()
        {
            //Arrange
            Player player = new Player(null, "Antic", new Position(), new Country(), new Team());

            //Assert
            _repoMock.Setup(e => e.Add(player)).Returns(false);

            //Act
            so = new AddPlayerSO(player);
            so.ExecuteTemplate(_repoMock.Object);
            var response = ((AddPlayerSO)so).Result;

            Assert.IsFalse(response);
            _repoMock.Verify(e => e.Add(It.IsAny<Player>()), Times.Exactly(1));
        }

        [TestMethod]
        public void AddPlayer_SurnameNullException()
        {
            //Arrange
            Player player = new Player(null, "Antic", new Position(), new Country(), new Team());

            //Assert
            _repoMock.Setup(e => e.Add(player)).Returns(false);

            //Act
            so = new AddPlayerSO(player);
            so.ExecuteTemplate(_repoMock.Object);
            var response = ((AddPlayerSO)so).Result;

            Assert.IsFalse(response);
            _repoMock.Verify(e => e.Add(It.IsAny<Player>()), Times.Exactly(1));
        }
        
        [TestMethod]
        public void AddPlayer_PositionNullException()
        {
            //Arrange
            Player player = new Player("Aleksandar", null, new Position(), new Country(), new Team());

            //Assert
            _repoMock.Setup(e => e.Add(player)).Returns(false);

            //Act
            so = new AddPlayerSO(player);
            so.ExecuteTemplate(_repoMock.Object);
            var response = ((AddPlayerSO)so).Result;

            Assert.IsFalse(response);
            _repoMock.Verify(e => e.Add(It.IsAny<Player>()), Times.Exactly(1));
        }
        
        [TestMethod]
        public void AddPlayer_CountryNullException()
        {
            //Arrange
            Player player = new Player("Aleksandar", "Antic", new Position(), null, new Team());

            //Assert
            _repoMock.Setup(e => e.Add(player)).Returns(false);

            //Act
            so = new AddPlayerSO(player);
            so.ExecuteTemplate(_repoMock.Object);
            var response = ((AddPlayerSO)so).Result;

            Assert.IsFalse(response);
            _repoMock.Verify(e => e.Add(It.IsAny<Player>()), Times.Exactly(1));
        }
        
        [TestMethod]
        public void AddPlayer_TeamNullException()
        {
            //Arrange
            Player player = new Player("Aleksandar", "Antic", new Position(), new Country(), null);

            //Assert
            _repoMock.Setup(e => e.Add(player)).Returns(false);

            //Act
            so = new AddPlayerSO(player);
            so.ExecuteTemplate(_repoMock.Object);
            var response = ((AddPlayerSO)so).Result;

            Assert.IsFalse(response);
            _repoMock.Verify(e => e.Add(It.IsAny<Player>()), Times.Exactly(1));
        }
    }
}
