using Microsoft.AspNetCore.Mvc;
using Moq;
using RRBL;
using RRModel;
using RRWebUI.Controllers;
using RRWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RRTest
{
    public class RestaurantControllerTest
    {
        [Fact]
        public void IndexActionShouldReturnRestaurantList()
        {
            //Arrange
            var mockBL = new Mock<IRestaurantBL>();
            mockBL.Setup(restBL => restBL.GetAllRestaurant()).Returns
            (
                new List<Restaurant>
                {
                    new Restaurant(){ Name = "Stephen's Rest"},
                    new Restaurant(){ Name = "Chase's Rest"}
                }
            );

            var restController = new RestaurantController(mockBL.Object);

            //Act
            var result = restController.Index();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<RestaurantVM>>(viewResult.ViewData.Model);

            Assert.Equal(2, model.Count());
        }
    }
}
