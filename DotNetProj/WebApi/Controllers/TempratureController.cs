using Domain.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    //[EnableCors("AllowOrigin")]
    [Route("[controller]")]
    public class TempratureController : ControllerBase
    {
        private readonly ITempratureManager _tempratureManager;
        //private readonly ILogger<TempratureController> _logger; would inject logger in real world scenario

        public TempratureController(ITempratureManager tempratureManager)
        {
            _tempratureManager = tempratureManager;
            //_logger = logger;
        }

        /// <summary>
        /// Convert Kelvin to Celsius
        /// </summary>
        /// <param name="request">TempratureConversionRequest</param>
        /// <returns></returns>
        [HttpGet]
        //[EnableCors("AllowOrigin")]
        [Route("Kelvin/Celsius")]
        public IActionResult ConvertKelvinToCelsius([FromQuery] TempratureConversionRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var tempratureModel = _tempratureManager.KelvinToCelsius(request.CurrentTemprature.Value);
                var message = "Success"; // Can be varied in case of more complex code
                var response = TempratureConversionResponse.GetResponse(tempratureModel, message);
                return Ok(response);
            }
            catch
            {
                //should log exception
                var result = StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Exception!");
                return result;
            }
        }

        /// <summary>
        /// Convert Kelvin to Fahrenheit
        /// </summary>
        /// <param name="request">TempratureConversionRequest</param>
        /// <returns></returns>
        [HttpGet]
        //[EnableCors("AllowOrigin")]
        [Route("Kelvin/Fahrenheit")]
        public IActionResult ConvertKelvinToFahrenheit([FromQuery] TempratureConversionRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var tempratureModel = _tempratureManager.KelvinToFahrenheit(request.CurrentTemprature.Value);
                var message = "Success"; // Can be varied in case of more complex code
                var response = TempratureConversionResponse.GetResponse(tempratureModel, message);
                return Ok(response);
            }
            catch
            {
                //should log exception
                var result = StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Exception!");
                return result;
            }
        }

        /// <summary>
        /// Convert Celsius to Fahrenheit
        /// </summary>
        /// <param name="request">TempratureConversionRequest</param>
        /// <returns></returns>
        [HttpGet]
        //[EnableCors("AllowOrigin")]
        [Route("Celsius/Fahrenheit")]
        public IActionResult ConvertCelsiusToFahrenheit([FromQuery] TempratureConversionRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var tempratureModel = _tempratureManager.CelsiusToFahrenheit(request.CurrentTemprature.Value);
                var message = "Success"; // Can be varied in case of more complex code
                var response = TempratureConversionResponse.GetResponse(tempratureModel, message);
                return Ok(response);
            }
            catch
            {
                //should log exception
                var result = StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Exception!");
                return result;
            }
        }

        /// <summary>
        /// Convert Celsius to Kelvin
        /// </summary>
        /// <param name="request">TempratureConversionRequest</param>
        /// <returns></returns>
        [HttpGet]
        //[EnableCors("AllowOrigin")]
        [Route("Celsius/Kelvin")]
        public IActionResult ConvertCelsiusToKelvin([FromQuery] TempratureConversionRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var tempratureModel = _tempratureManager.CelsiusToKelvin(request.CurrentTemprature.Value);
                var message = "Success"; // Can be varied in case of more complex code
                var response = TempratureConversionResponse.GetResponse(tempratureModel, message);
                return Ok(response);
            }
            catch
            {
                //should log exception
                var result = StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Exception!");
                return result;
            }
        }

        /// <summary>
        /// Convert Fahrenheit to Kelvin
        /// </summary>
        /// <param name="request">TempratureConversionRequest</param>
        /// <returns></returns>
        [HttpGet]
        //[EnableCors("AllowOrigin")]
        [Route("Fahrenheit/Kelvin")]
        public IActionResult ConvertFahrenheitToKelvin([FromQuery] TempratureConversionRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var tempratureModel = _tempratureManager.FahrenheitToKelvin(request.CurrentTemprature.Value);
                var message = "Success"; // Can be varied in case of more complex code
                var response = TempratureConversionResponse.GetResponse(tempratureModel, message);
                return Ok(response);
            }
            catch
            {
                //should log exception
                var result = StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Exception!");
                return result;
            }
        }

        /// <summary>
        /// Convert Fahrenheit to Celsius
        /// </summary>
        /// <param name="request">TempratureConversionRequest</param>
        /// <returns></returns>
        [HttpGet]
        //[EnableCors("AllowOrigin")]
        [Route("Fahrenheit/Celsius")]
        public IActionResult ConvertFahrenheitToCelsius([FromQuery] TempratureConversionRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var tempratureModel = _tempratureManager.FahrenheitToCelsius(request.CurrentTemprature.Value);
                var message = "Success"; // Can be varied in case of more complex code
                var response = TempratureConversionResponse.GetResponse(tempratureModel, message);
                return Ok(response);
            }
            catch
            {
                //should log exception
                var result = StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Exception!");
                return result;
            }
        }
    }
}
