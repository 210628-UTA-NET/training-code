using System;
using RRModel;
using Xunit;

namespace RRTest
{
    public class RestaurantModelTest
    {
        /// <summary>
        /// This test will check if validation works in Restaurant Model
        /// It will input the right data and see if it persists
        /// </summary>
        [Fact]
        public void CityShouldSetValidData()
        {
            //Arrange
            Restaurant test = new Restaurant();
            string city = "Houston";

            //Act
            test.City = city;

            //Assert
            Assert.Equal(city, test.City);
        }
    }
}
