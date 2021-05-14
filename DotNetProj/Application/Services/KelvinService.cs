using Domain.Abstract;
using System;

namespace Application.Services
{
    /// <summary>
    /// Class to convert temprature from Kelvin to others
    /// </summary>
    public class KelvinService : TempratureService, IDisposable
    {

        /// <summary>
        /// Gets temprature in Kelvin, returns temprature in Celsius
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Temprature in Celsius</returns>
        public override double ToCelsius(double CurrentTemprature)
        {
            return Math.Round(CurrentTemprature - 273.15, 2);
        }

        /// <summary>
        /// Gets temprature in Kelvin, returns temprature in Fahrenheit
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Temprature in Fahrenheit</returns>
        public override double ToFahrenheit(double CurrentTemprature)
        {
            return Math.Round(CurrentTemprature * 9 / 5 - 459.67, 2);
        }

        /// <summary>
        /// Dispose method, so that service can be called as a disposable
        /// </summary>
        public void Dispose()
        {
        }
    }
}
