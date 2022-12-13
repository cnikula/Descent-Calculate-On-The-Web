using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using CalculateAirPlanDescent.Pages;

namespace CalculateAirPlanDescent.Data.Models
{
    public class DescendRateModel
    {

        // Fields
        [Range(1,100000, ErrorMessage = "Descend From Altitude can only be:  1 - 100000 Feet")]
        public double? descendFrom { get; set; }

        [Range(1, 100000, ErrorMessage = "Descend To Altitude can only be:  1 - 100000 Feet")]
        public double? descendTo { get; set; }

        [Range(50, 500, ErrorMessage = "Descending Speed can only be:  50 - 500 NM")]
        public double? descendSpeed { get; set; }

        [Range(1,20, ErrorMessage = "Descend Angle can only be be:  1 to 20 Degrees" )]
        public double? descendAngle { get; set; }

        [Range(1, 100000, ErrorMessage = "Distance Descending In can only be:  1 - 100000 NM")]
        public double? distanceDescendIn { get; set; }
    }
}
