
using Xunit;

namespace Xtramile.Tests
{
    public class ExtensionsTest
    {
        [Fact]
        public void FahrenheitToCelcius_TemperatureConverter_Resulted20()
        {
            var celcius = Xtramile.Extensions.TemperatureConverter.FahrenheitToCelcius(68);
            Assert.Equal(20, celcius);
        }
    }
}