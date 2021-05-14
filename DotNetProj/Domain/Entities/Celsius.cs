using Domain.Abstract;

namespace Domain.Entities
{

    /// <summary>
    /// Class for Celsius, extends abstract Temprature
    /// </summary>
    public class Celsius : Temprature
    {
        public Celsius(double CurrentTemprature) : base(CurrentTemprature)
        {
            base.CurrentUnit = Enums.TempratureUnit.TempratureUnits.Celsius;
        }
    }
}
