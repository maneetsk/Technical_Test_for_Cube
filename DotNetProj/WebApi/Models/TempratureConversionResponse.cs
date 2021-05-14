using Domain.Abstract;

namespace WebApi.Model
{
    /// <summary>
    /// Temprature Conversion Response model 
    /// </summary>
    public class TempratureConversionResponse
    {
        /// <summary>
        /// Temprature Conversions
        /// </summary>
        public TempratureResponseModel Temprature { get; set; }

        /// <summary>
        /// Message to the caller
        /// </summary>
        public string Message { get; set; }

        public static TempratureConversionResponse GetResponse(Temprature temprature, string message)
        {
            return new TempratureConversionResponse
            {
                Temprature = new TempratureResponseModel()
                {
                    ConvertedTemprature = temprature.ConvertedTemprature,
                    ConvertedUnit = temprature.ConvertedUnit.ToString(),
                    CurrentTemprature = temprature.CurrentTemprature,
                    CurrentUnit = temprature.CurrentUnit.ToString()
                },
                Message = message
            };
        }

    }

    /// <summary>
    /// Temprature response model
    /// </summary>
    public class TempratureResponseModel
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
        public string CurrentUnit { get; set; }

        /// <summary>
        /// Unit of converted temprature
        /// </summary>
        public string ConvertedUnit { get; set; }
    }
}
