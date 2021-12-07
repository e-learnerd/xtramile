using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net.Http;
using Xtramile.Api;
using Xunit;

namespace Xtramile.Tests
{
    public class ServiceCountryTest
    {
        [Fact]
        public async void GetCountry_CountryService()
        {
            var factory = Common.GetHttpClientFactory();
           
            var mockService = new Mock<CountryService>(factory);
            var country = await mockService.Object.GetCountries();
            var city = await mockService.Object.GetCities("indonesia");
            Assert.True(country.Data.Count > 0);
            Assert.True(city.Data.Count > 0);
        }
    }
}
