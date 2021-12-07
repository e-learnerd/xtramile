using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xtramile.Api;

namespace Xtramile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        readonly WeatherForecastService weather;
        public WeatherForecastController(WeatherForecastService weather)
        {
            this.weather = weather;
        }

        [HttpGet("{cityName}")]
        public async Task<IActionResult> City([FromRoute] string cityName)
        {
            var result = await weather.GetWeather(cityName);
            return Ok(result);
        }
    }
}
