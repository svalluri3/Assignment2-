using System;
using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class TemperatureConversionModel
    {
        [Required(ErrorMessage = "Fahrenheit value is required.")]
        [Range(-1000, 1000, ErrorMessage = "Value out of range.")]
        [Display(Name = "Fahrenheit Value")]
        public double? FahrenheitValue { get; set; }

        [Display(Name = "Celsius Value")]
        public double? CelsiusValue { get; set; }

        public double ConvertFahrenheitToCelsius()
{
    if (!FahrenheitValue.HasValue)
        return 0; // or throw an exception

    return (FahrenheitValue.Value - 32) * 5 / 9;
}

        public void Calculate()
        {
            CelsiusValue = ConvertFahrenheitToCelsius();
        }

        public void Clear()
        {
            FahrenheitValue = null;
            CelsiusValue = null;
        }
    }
}
