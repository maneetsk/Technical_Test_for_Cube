using static Domain.Entities.Enums.TempratureUnit;

namespace Domain.Abstract
{

    /// <summary>
    /// Abstract temprature model
    /// </summary>
    public abstract class Temprature
    {
        /// <summary>
        /// Current temprature
        /// </summary>
        public double CurrentTemprature { get; set; }

        /// <summary>
        /// Converted temprature
        /// </summary>
        public double ConvertedTemprature { get; set; }

        /// <summary>
        /// Unit of current temprature
        /// </summary>
        public TempratureUnits CurrentUnit { get; set; }

        /// <summary>
        /// Unit of converted temprature
        /// </summary>
        public TempratureUnits ConvertedUnit { get; set; }

        public Temprature(double CurrentTemprature)
        {
            this.CurrentTemprature = CurrentTemprature;
        }
    }
}
