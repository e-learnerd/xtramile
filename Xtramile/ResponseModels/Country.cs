using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xtramile.ResponseModels
{
    public class BaseCountryResponse
    {
        public bool Error { get; set; }
        public string Msg { get; set; }
    }

    public class CountryResponse : BaseCountryResponse
    {
        public List<DataCountry> Data { get; set; } = new List<DataCountry>();

        public class DataCountry
        {
            public string Name { get; set; }
            public string Iso2 { get; set; }
            public string Iso3 { get; set; }
        }
    }

    public class CityResponse : BaseCountryResponse
    {
        public List<string> Data { get; set; } = new List<string>();
    }
}
