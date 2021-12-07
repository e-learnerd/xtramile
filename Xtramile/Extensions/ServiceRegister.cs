using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xtramile.Extensions
{
    public static class ServiceRegister
    {
        public static void RegisterCustomServices(this IServiceCollection services)
        {
            services.AddScoped<Api.CountryService>();
            services.AddScoped<Api.WeatherForecastService>();
        }
    }
}
