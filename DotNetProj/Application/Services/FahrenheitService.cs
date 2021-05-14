using Domain.Abstract;
using System;

namespace Application.Services
{

    /// <summary>
    /// Class to convert temprature from Fahrenheit to others
    /// </summary>
    public class FahrenheitService : TempratureService, IDisposable
    {

        /// <summary>
        /// Gets temprature in Fahrenheit, returns temprature in Kelvin
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Temprature in Kelvin</returns>
        public override double ToKelvin(double CurrentTemprature)
        {
            return Math.Round((CurrentTemprature + 459.67) * 5 / 9, 2);
        }

        /// <summary>
        /// Gets temprature in Fahrenheit, returns temprature in Celsius
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Temprature in Celsius</returns>
        public override double ToCelsius(double CurrentTemprature)
        {
            return Math.Round((CurrentTemprature - 32) * 5 / 9, 2);
        }

        /// <summary>
        /// Dispose method, so that service can be called as a disposable
        /// </summary>
        public void Dispose()
        {
        }
    }
}
