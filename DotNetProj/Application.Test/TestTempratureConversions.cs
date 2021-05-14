using Application.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Test
{
    /// <summary>
    /// Test cases for Payment Plan Service
    /// Note that expected data are hard coded below just for convenience
    /// </summary>
    [TestClass]
    public class TestTempratureConversions
    {
        KelvinService _kelvinService;
        CelsiusService _celsiusService;
        FahrenheitService _fahrenheitService;


        /// <summary>
        /// Setup for all the test cases
        /// </summary>
        [TestInitialize]
        public void TestInit()
        {
            _kelvinService = new KelvinService();
            _celsiusService = new CelsiusService();
            _fahrenheitService = new FahrenheitService();
        }

        [TestMethod]
        public void Convert_Kelvin_To_Celsius() 
        {
            var kelvinTemp = 50;
            var celsiusTemp = _kelvinService.ToCelsius(kelvinTemp);
            Assert.AreEqual(-223.15, celsiusTemp);
        }

        [TestMethod]
        public void Convert_Kelvin_To_Fahrenheit()
        {
            var kelvinTemp = 50;
            var fahrenheitTemp = _kelvinService.ToFahrenheit(kelvinTemp);
            Assert.AreEqual(-369.67, fahrenheitTemp);
        }

        [TestMethod]
        public void Convert_Celsius_To_Fahrenheit()
        {
            var celsiusTemp = 50;
            var fahrenheitTemp = _celsiusService.ToFahrenheit(celsiusTemp);
            Assert.AreEqual(122, fahrenheitTemp);
        }

        [TestMethod]
        public void Convert_Celsius_To_Kelvin()
        {
            var celsiusTemp = 50;
            var kelvinTemp = _celsiusService.ToKelvin(celsiusTemp);
            Assert.AreEqual(323.15, kelvinTemp);
        }

        [TestMethod]
        public void Convert_Fahrenheit_To_Kelvin()
        {
            var fahrenheitTemp = 50;
            var kelvinTemp = _fahrenheitService.ToKelvin(fahrenheitTemp);
            Assert.AreEqual(283.15, kelvinTemp);
        }

        [TestMethod]
        public void Convert_Fahrenheit_To_Celsius()
        {
            var fahrenheitTemp = 50;
            var celsiusTemp = _fahrenheitService.ToCelsius(fahrenheitTemp);
            Assert.AreEqual(10, celsiusTemp);
        }
    }
}
