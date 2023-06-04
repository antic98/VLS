using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using SystemOperations;
using SystemOperations.SearchSO;

namespace UnitTests.SearchSOTests
{
    [TestClass]
    public class SearchGameTests
    {
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void SearchGame_Success()
        {
            // Arrange
            var game = new Game
            {
                Search = "Partizan"
            };
            var games = new List<IDomainObject> { game };
            repoMock.Setup(e => e.Search(game)).Returns(games);

            so = new SearchGameSO(game);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Search(It.IsAny<Game>()), Times.Exactly(1));
        }
        
        [TestMethod]
        public void SearchGame_GameNullException()
        {
            // Arrange
            so = new SearchGameSO(null);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Search(It.IsAny<Game>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void SearchGame_SearchNullException()
        {
            // Arrange
            var game = new Game();
            so = new SearchGameSO(game);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Search(It.IsAny<Game>()), Times.Exactly(0));
        }
    }
}