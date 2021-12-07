using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xtramile.ResponseModels;
using Xtramile.Extensions;

namespace Xtramile.Api
{
    public class WeatherForecastService
    {
        private readonly HttpClient client;
        const string endpoint = "http://api.openweathermap.org/data/2.5/weather";
        const string apiKey = "831ad72a86927965d2062309b34bfd6a";

        public WeatherForecastService(IHttpClientFactory factory)
        {
            client = factory.CreateClient();
        }

        public async Task<WeatherForecastResponse> GetWeather(string cityName)
            => await client.GetAsync<WeatherForecastResponse>($"{endpoint}?q={cityName}&appid={apiKey}");

    }
}
