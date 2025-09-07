using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class TemperatureModel
    {
        [Required(ErrorMessage = "Please enter a Fahrenheit value.")]
        [Range(-1000, 1000, ErrorMessage = "Fahrenheit must be between -1000 and 1000.")]
        public double? Fahrenheit { get; set; }

        public double CalculateCelsius()
        {
            return (Fahrenheit.Value - 32) * 5 / 9;
        }
    }
}
