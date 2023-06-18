using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.DeleteSO;

namespace UnitTests.DeleteSOTests
{
    [TestClass]
    public class DeletePlayerTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void DeletePlayer_Success()
        {
            // Arrange
            var player = new Player
            {
                ID = 1
            };

            var stats = new List<IDomainObject>
            {
                new Stats(new Game(), player, 5),
                new Stats(new Game(), player, 7),
                new Stats(new Game(), new Player(), 10),
                new Stats(new Game(), player, 3),
            };
            
            repoMock.Setup(e => e.GetList(It.IsAny<Stats>())).Returns(stats);
            so = new DeletePlayerSO(player);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.GetList(It.IsAny<Stats>()), Times.Exactly(1));
            repoMock.Verify(e => e.Delete(It.IsAny<Stats>()), Times.Exactly(3));
            repoMock.Verify(e => e.Delete(It.IsAny<Player>()), Times.Exactly(1));
        }
        
        [TestMethod]
        public void DeletePlayer_PlayerNullException()
        {
            // Arrange
            so = new DeletePlayerSO(null);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Delete(It.IsAny<Player>()), Times.Exactly(0));
        }
    }
}