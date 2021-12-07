using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xtramile.Extensions
{
    public class TemperatureConverter
    {
        public static double FahrenheitToCelcius(double fahrenheit) => (fahrenheit - 32d) * (5d / 9d);
    }
}
