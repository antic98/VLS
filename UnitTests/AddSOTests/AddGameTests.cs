using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.AddSO;

namespace UnitTests.AddSOTests
{
    [TestClass]
    public class AddGameTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void AddGame_Success()
        {
            //Arrange
            var game = new Game(new Team(), new Team(), DateTime.Now);
            so = new AddGameSO(game);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(1));
        }

        [TestMethod]
        public void AddGame_GameNullException()
        {
            //Arrange
            so = new AddGameSO(null);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void AddGame_HostNullException()
        {
            //Arrange
            var game = new Game(null, new Team(), DateTime.Now);
            so = new AddGameSO(game);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(0));
        }

        [TestMethod]
        public void AddGame_GuestNullException()
        {
            //Arrange
            var game = new Game(new Team(), null, DateTime.Now);
            so = new AddGameSO(game);

            //Act
            so.ExecuteTemplate(repoMock.Object);

            //Assert
            repoMock.Verify(e => e.Add(It.IsAny<Game>()), Times.Exactly(0));
        }
    }
}
