using Domain.Abstract;

namespace Domain.Entities
{
    /// <summary>
    /// Class for Kelvin, extends abstract Temprature
    /// </summary>
    public class Kelvin : Temprature
    {
        public Kelvin(double CurrentTemprature) : base(CurrentTemprature)
        {
            base.CurrentUnit = Enums.TempratureUnit.TempratureUnits.Kelvin;
        }
    }
}
