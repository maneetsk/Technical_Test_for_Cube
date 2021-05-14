using Application.Services;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Managers
{
    public class TempratureManager : ITempratureManager
    {
        CelsiusService celsiusService;
        KelvinService kelvinService;
        FahrenheitService fahrenheitService;

        public Celsius CelsiusToFahrenheit(double CurrentTemprature)
        {
            Celsius celsius = new Celsius(CurrentTemprature);
            using (celsiusService = new CelsiusService())
            {
                celsius.ConvertedTemprature = celsiusService.ToFahrenheit(celsius.CurrentTemprature);
            }
            celsius.ConvertedUnit = Domain.Entities.Enums.TempratureUnit.TempratureUnits.Fahrenheit;
            return celsius;

        }

        public Celsius CelsiusToKelvin(double CurrentTemprature)
        {
            Celsius celsius = new Celsius(CurrentTemprature);
            using (celsiusService = new CelsiusService())
            {
                celsius.ConvertedTemprature = celsiusService.ToKelvin(celsius.CurrentTemprature);
            }
            celsius.ConvertedUnit = Domain.Entities.Enums.TempratureUnit.TempratureUnits.Kelvin;

            return celsius;
        }

        public Fahrenheit FahrenheitToCelsius(double CurrentTemprature)
        {
            Fahrenheit fahrenheit = new Fahrenheit(CurrentTemprature);
            using (fahrenheitService = new FahrenheitService())
            {
                fahrenheit.ConvertedTemprature = fahrenheitService.ToCelsius(fahrenheit.CurrentTemprature);
            }
            fahrenheit.ConvertedUnit = Domain.Entities.Enums.TempratureUnit.TempratureUnits.Celsius;

            return fahrenheit;
        }

        public Fahrenheit FahrenheitToKelvin(double CurrentTemprature)
        {
            Fahrenheit fahrenheit = new Fahrenheit(CurrentTemprature);
            using (fahrenheitService = new FahrenheitService())
            {
                fahrenheit.ConvertedTemprature = fahrenheitService.ToKelvin(fahrenheit.CurrentTemprature);
            }
            fahrenheit.ConvertedUnit = Domain.Entities.Enums.TempratureUnit.TempratureUnits.Kelvin;

            return fahrenheit;
        }

        public Kelvin KelvinToCelsius(double CurrentTemprature)
        {
            Kelvin kelvin = new Kelvin(CurrentTemprature);
            using (kelvinService = new KelvinService())
            {
                kelvin.ConvertedTemprature = kelvinService.ToCelsius(kelvin.CurrentTemprature);
            }
            kelvin.ConvertedUnit = Domain.Entities.Enums.TempratureUnit.TempratureUnits.Celsius;

            return kelvin;
        }

        public Kelvin KelvinToFahrenheit(double CurrentTemprature)
        {
            Kelvin kelvin = new Kelvin(CurrentTemprature);
            using (kelvinService = new KelvinService())
            {
                kelvin.ConvertedTemprature = kelvinService.ToFahrenheit(kelvin.CurrentTemprature);
            }
            kelvin.ConvertedUnit = Domain.Entities.Enums.TempratureUnit.TempratureUnits.Fahrenheit;

            return kelvin;
        }
    }
}
