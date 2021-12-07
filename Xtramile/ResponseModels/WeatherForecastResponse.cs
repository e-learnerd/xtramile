using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Xtramile.ResponseModels
{
    public class WeatherForecastResponse
    {
        public CoordResponse Coord { get; set; }
        public List<WeatherResponse> Weather { get; set; } = new List<WeatherResponse>();
        public string Base { get; set; }
        public MainResponse Main { get; set; }
        public int Visibility { get; set; }
        public WindResponse Wind { get; set; }
        public CloudResponse Clouds { get; set; }
        public long Dt { get; set; }
        public SysResponse Sys { get; set; }
        public int Timezone { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public long Cod { get; set; }

        public class CoordResponse
        {
            public double Lon { get; set; }
            public double Lat { get; set; }
        }

        public class WeatherResponse
        {
            public long Id { get; set; }
            public string Main { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }
        }

        public class MainResponse
        {
            public double Temp { get; set; }
            public double FeelsLike { get; set; }
            public double TempMin { get; set; }
            public double TempMax { get; set; }
            public double Pressure { get; set; }
            public double Humidity { get; set; }

            public double TempCelcius
            {
                get
                {
                    return Extensions.TemperatureConverter.FahrenheitToCelcius(Temp);
                }
            }
        }

        public class WindResponse
        {
            public double Speed { get; set; }
            public double Deg { get; set; }
        }

        public class CloudResponse
        {
            public long All { get; set; }
        }

        public class SysResponse
        {
            public long Type { get; set; }
            public long Id { get; set; }
            public string Country { get; set; }
            public long Sunrise { get; set; }
            public long Sunset { get; set; }
        }
    }
}
