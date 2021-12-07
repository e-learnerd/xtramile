using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net.Http;
using Xtramile.Api;
using Xunit;

namespace Xtramile.Tests
{
    public class ControllerCountryTest
    {
        [Fact]
        public async void Country_CountryController_TestCountry()
        {
            var factory = Common.GetHttpClientFactory();
           
            var mockService = new Mock<CountryService>(factory);

            var controller = new Controllers.CountryController(mockService.Object);
            
            var country = (await controller.Country()) as OkObjectResult;
            var city = (await controller.City("indonesia")) as OkObjectResult;

            var valueCountry = country.Value as ResponseModels.CountryResponse;
            var valueCity = city.Value as ResponseModels.CityResponse;

            Assert.True(valueCountry.Data.Count > 0);
            Assert.True(valueCity.Data.Count > 0);
        }
    }
}
