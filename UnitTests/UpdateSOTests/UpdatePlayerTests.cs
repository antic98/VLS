using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.UpdateSO;

namespace UnitTests.UpdateSOTests
{
    [TestClass]
    public class UpdatePlayerTests
    {
        private readonly Mock<IRepository<IDomainObject>> _repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void UpdatePlayer_Success()
        {
            //Arrange
            Player player = new Player(1, "Aleksandar", "Antic", new Position(), new Country(), new Team());
            
            //Act
            so = new UpdatePlayerSO(player);
            so.ExecuteTemplate(_repoMock.Object);
            
            //Assert
            _repoMock.Verify(e => e.GetObject(It.IsAny<Player>()), Times.Exactly(1));
            _repoMock.Verify(e => e.Update(It.IsAny<Player>()), Times.Exactly(1));
        }

        [TestMethod]
        public void UpdatePlayer_PlayerNullException()
        {
            //Arrange
            
            //Act
            so = new UpdatePlayerSO(new Player());
            so.ExecuteTemplate(_repoMock.Object);
            
            //Assert
            _repoMock.Verify(e => e.GetObject(It.IsAny<Player>()), Times.Exactly(1));
            _repoMock.Verify(e => e.Update(It.IsAny<Player>()), Times.Exactly(1));
        }

        
    }
}
