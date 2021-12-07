using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xtramile.Api;
using Xtramile.ResponseModels;

namespace Xtramile.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        readonly CountryService country;
        public CountryController(CountryService country)
        {
            this.country = country;
        }

        [HttpGet]
        public async Task<IActionResult> Country()
        {
            var result = await country.GetCountries();
            return Ok(result);
        }

        [HttpGet("{countryName}")]
        public async Task<IActionResult> City([FromRoute]string countryName)
        {
            var result = await country.GetCities(countryName);
            return Ok(result);
        }
    }
}
