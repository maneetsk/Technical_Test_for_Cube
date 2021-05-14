using Domain.Abstract;
using System;

namespace Application.Services
{

    /// <summary>
    /// Class to convert temprature from Celsius to others
    /// </summary>
    public class CelsiusService : TempratureService, IDisposable
    {

        /// <summary>
        /// Gets temprature in Celsius, returns temprature in Kelvin
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Temprature in Kelvin</returns>
        public override double ToKelvin(double CurrentTemprature)
        {
            return Math.Round(CurrentTemprature + 273.15, 2);
        }

        /// <summary>
        /// Gets temprature in Celsius, returns temprature in Fahrenheit
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Temprature in Fahrenheit</returns>
        public override double ToFahrenheit(double CurrentTemprature)
        {
            return Math.Round(CurrentTemprature * 9 / 5 + 32, 2);
        }

        /// <summary>
        /// Dispose method, so that service can be called as a disposable
        /// </summary>
        public void Dispose()
        {

        }
    }
}
