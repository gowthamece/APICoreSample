using HotelApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiTest
{
    public class WeatherForecastControllerTest
    {
        //[Fact]
        //public void GetAllTest()
        //{
        //    //Arrange
        //    var controller = new WeatherForecastController();
        //    //Act
        //    var data = controller.Get();
        //    //Assert
        //    Assert.NotNull(data);

        //}

        [Fact]
        public void GetWhetherForecastTest()
        {
            //Arrange 
            var controller=new WeatherForecastController();
            //Act 
            var actualResult = controller.Get().Count();
            var expectedResult = 5;
            //Assert 
            //Assert.True(actualResult.Count()>0);
            //Assert.False(actualResult.Count() == 0);
            Assert.Equal(actualResult, expectedResult);
        }
    }
}