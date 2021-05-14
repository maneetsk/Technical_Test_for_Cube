using Domain.Entities;

namespace Domain.Interfaces
{
    /// <summary>
    /// Manager to process temprature conversions
    /// </summary>
    public interface ITempratureManager
    {
        /// <summary>
        /// Convert Fahrenheit To Kelvin
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Fahrenheit model</returns>
        Fahrenheit FahrenheitToKelvin(double CurrentTemprature);

        /// <summary>
        /// Convert Fahrenheit To Celsius
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Fahrenheit model</returns>
        Fahrenheit FahrenheitToCelsius(double CurrentTemprature);

        /// <summary>
        /// Convert Kelvin To Fahrenheit 
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Kelvin model</returns>
        Kelvin KelvinToFahrenheit(double CurrentTemprature);

        /// <summary>
        /// Convert Kelvin To Celsius 
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Kelvin model</returns>
        Kelvin KelvinToCelsius(double CurrentTemprature);

        /// <summary>
        /// Convert Celsius To Fahrenheit 
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Celsius model</returns>
        Celsius CelsiusToFahrenheit(double CurrentTemprature);

        /// <summary>
        /// Convert Celsius To Kelvin 
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Celsius model</returns>
        Celsius CelsiusToKelvin(double CurrentTemprature);
    }
}
