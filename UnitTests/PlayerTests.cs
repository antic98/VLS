using System.Reflection;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository.DatabaseRepository;
using Xunit;

namespace UnitTests
{
    [TestClass]
    public class PlayerTests
    {
        private readonly Mock<IRepository<Player>> _playerRepoMock = new Mock<IRepository<Player>>();
        private readonly Mock<IRepository<Position>> _positionRepoMock = new Mock<IRepository<Position>>();
        private readonly Mock<IRepository<Country>> _countryRepoMock = new Mock<IRepository<Country>>();
        private readonly Mock<IRepository<Team>> _teamRepoMock = new Mock<IRepository<Team>>();

        [Fact]
        public void PlayerCreated()
        {
            //Arrange
            Position position = new Position()
            {
                ID = 1,
                Name = "CENTAR"
            };
            var responsePosition = _positionRepoMock.Setup(e => e.Add(position));

            Country country = new Country()
            {
                ID = 1,
                Name = "CENTAR"
            };
            var responseCountry = _countryRepoMock.Setup(e => e.Add(country));

            Team team = new Team()
            {
                ID = 1,
                Name = "CENTAR",
                City = "Belgrade",
                Color = "black"
            };
            var responseTeam = _teamRepoMock.Setup(e => e.Add(team));
            Player player = new Player()
            {
                ID = 1,
                Name = "AAA",
                Surname = "AAA",
                Position = position,
                Country = country,
                Team = team,
                Goals = 10
            };

            //Assert
            var responsePlayer = _playerRepoMock.Setup(e => e.Add(player));

            //Act
            Assert.IsNotNull(responsePlayer);
        }
    }
}
