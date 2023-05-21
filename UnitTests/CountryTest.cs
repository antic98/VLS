using System;
using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace UnitTests
{
    [TestClass]
    public class CountryTest
    {
        [Theory]
        [InlineData("Beograd")]
        public void CountryCreated(string countryName)
        {
            var country = new Country(1, countryName);

            Assert.IsNotNull(country);
            Assert.IsNotNull(country.Name);
            Assert.AreEqual(countryName, country.Name);
        }

        [Theory]
        [InlineData(null)]
        public void Country_ExceptionThrown_WhenCreatingWithNullFields(string countryName)
        {
            Assert.ThrowsException<ParameterEmptyException>(() => new Country(1, countryName));
        }

        // public static IEnumerable<object[]> TestDataForValidTest =>
        //new List<object[]>
        //{
        //     new object[] { "CountryName" },
        //};


    }
}
//moq