using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xtramile.ResponseModels;
using Xtramile.Extensions;

namespace Xtramile.Api
{
    public class CountryService
    {
        private readonly HttpClient client;
        const string endpoint = "https://countriesnow.space/api/v0.1/countries";

        public CountryService(IHttpClientFactory factory)
        {
            client = factory.CreateClient();
        }

        public async Task<CountryResponse> GetCountries() 
            => await client.GetAsync<CountryResponse>($"{endpoint}/iso");

        public async Task<CityResponse> GetCities(string countryName) 
            => await client.PostAsync<CityResponse>($"{endpoint}/cities", new { country = countryName });


    }
}
