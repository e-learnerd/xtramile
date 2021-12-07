using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net.Http;
using Xtramile.Api;
using Xunit;


namespace Xtramile.Tests
{
    public class ControllerWeatherForecastTest
    {
        [Fact]
        public async void Country_CountryController_TestCountry()
        {
            var factory = Common.GetHttpClientFactory();
            var mockService = new Mock<WeatherForecastService>(factory);

            var controller = new Controllers.WeatherForecastController(mockService.Object);
            var weather = (await controller.City("london")) as OkObjectResult;

            var valueWeather = weather.Value as ResponseModels.WeatherForecastResponse;

            Assert.True(valueWeather.Main != null);
        }
    }
}
