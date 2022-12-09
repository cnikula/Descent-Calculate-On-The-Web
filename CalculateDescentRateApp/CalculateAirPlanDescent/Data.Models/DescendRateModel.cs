using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace CalculateAirPlanDescent.Data.Models
{
    public class DescendRateModel
    {

        // Fields
        [Required]
        public string? descendFrom { get; set; }

        [Required]
        public string? descendTo { get; set; }
        public string? descendSpeed { get; set; }
        public string? descendAngle { get; set; }
        public string? distanceDescendIn { get; set; }
    }
}
