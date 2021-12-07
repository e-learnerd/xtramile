using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net.Http;
using Xtramile.Api;
using Xunit;


namespace Xtramile.Tests
{
    public class ServiceWeatherForecastTest
    {
        [Fact]
        public async void GetWeatherForecast_WeatherForecastService()
        {
            var factory = Common.GetHttpClientFactory();
            var mockService = new Mock<WeatherForecastService>(factory);
            var weather = await mockService.Object.GetWeather("jakarta");
            Assert.True(weather != null);
        }
    }
}
