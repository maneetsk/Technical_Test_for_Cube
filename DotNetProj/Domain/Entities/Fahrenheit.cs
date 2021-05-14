using Domain.Abstract;

namespace Domain.Entities
{

    /// <summary>
    /// Class for Fahrenheit, extends abstract Temprature
    /// </summary>
    public class Fahrenheit : Temprature
    {
        public Fahrenheit(double CurrentTemprature) : base(CurrentTemprature)
        {
            base.CurrentUnit = Enums.TempratureUnit.TempratureUnits.Fahrenheit;
        }
    }
}
