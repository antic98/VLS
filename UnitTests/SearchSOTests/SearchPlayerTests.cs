﻿using System.Collections.Generic;
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
        private readonly Mock<IRepository<IDomainObject>> repoMock = new Mock<IRepository<IDomainObject>>();
        private SystemOperationBase so;

        [TestMethod]
        public void SearchPlayer_Success()
        {
            // Arrange
            var player = new Player
            {
                Search = "Aleksandar"
            };
            var players = new List<IDomainObject> { player };
            repoMock.Setup(e => e.Search(player)).Returns(players);

            so = new SearchPlayerSO(player);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Search(It.IsAny<Player>()), Times.Exactly(1));
        }
        
        [TestMethod]
        public void SearchPlayer_PlayerNullException()
        {
            // Arrange
            so = new SearchPlayerSO(null);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Search(It.IsAny<Player>()), Times.Exactly(0));
        }
        
        [TestMethod]
        public void SearchPlayer_SearchNullException()
        {
            // Arrange
            var player = new Player();
            so = new SearchPlayerSO(player);

            // Act
            so.ExecuteTemplate(repoMock.Object);

            // Assert
            repoMock.Verify(e => e.Search(It.IsAny<Player>()), Times.Exactly(0));
        }
    }
}