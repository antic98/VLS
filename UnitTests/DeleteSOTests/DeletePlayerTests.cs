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
        private readonly Mock<IRepository<IDomainObject>> _repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void DeletePlayer_Success()
        {
            //Arrange
            Player player = new Player("Aleksandar", "Antic", new Position(), new Country(), new Team());

            //Act
            so = new DeletePlayerSO(player);
            so.ExecuteTemplate(_repoMock.Object);

            //Assert
        }

        [TestMethod]
        public void DeletePlayer_PlayerNullException()
        {
            //Arrange


            //Act
            so = new DeletePlayerSO(null);
            so.ExecuteTemplate(_repoMock.Object);

            //Assert
        }
    }
}
