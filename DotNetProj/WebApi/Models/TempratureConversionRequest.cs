using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    /// <summary>
    /// Temprature conversion request model
    /// </summary>
    [BindProperties]
    public class TempratureConversionRequest : IValidatableObject
    {
        [Required]
        public double? CurrentTemprature { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Double.IsNaN(CurrentTemprature.Value))
            {
                yield return new ValidationResult("Provided temprature is not a number", new[] { nameof(CurrentTemprature) });
            }
        }
    }
}
