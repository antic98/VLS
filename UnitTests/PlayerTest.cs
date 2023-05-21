using System;
using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemOperations;
using Xunit;

namespace UnitTests
{
    [TestClass]
    public class PlayerTest
    {
        private Team _team;
        private Country _country;

        private void GetData()
        {
            _team = new Team();
            SystemOperationBase so = new AddTeamSO(_team);
            so.ExecuteTemplate();
            _country = new Country();
        }

        [TestMethod]
        public void PlayerCreated()
        {
            var country = new Country();
            country.Name = "...";

            Assert.IsNotNull(country);
            Assert.IsNotNull(country.Name);
            Assert.AreEqual("...", country.Name);
        }

        public static IEnumerable<object[]> TestDataForValidTest =>
         new List<object[]>
         {
            new object[] { "Name", "Surname" },
            new object[] { new string('*', 20), "Beograd" },
            new object[] { "BGD", new string('*', 100) },
            new object[] { new string('*', 20), new string('*', 100) },
         };


    }
}
