namespace Domain.Abstract
{
    /// <summary>
    /// Abstract class for temprature methods
    /// </summary>
    public abstract class TempratureService
    {
        /// <summary>
        /// Return Kelvin temprature after conversion from current temprature
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Converted Temprature</returns>
        public virtual double ToKelvin(double CurrentTemprature) { return CurrentTemprature; }
        /// <summary>
        /// Return Celsius temprature after conversion from current temprature
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Converted Temprature</returns>
        public virtual double ToCelsius(double CurrentTemprature) { return CurrentTemprature; }
        /// <summary>
        /// Return Fahrenheit temprature after conversion from current temprature
        /// </summary>
        /// <param name="CurrentTemprature"></param>
        /// <returns>Converted Temprature</returns>
        public virtual double ToFahrenheit(double CurrentTemprature) { return CurrentTemprature; }
    }
}
