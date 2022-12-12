using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace CalculateAirPlanDescent.Data.Models
{
    public class DescendRateModel
    {

        // Fields
        [Range(1,100000, ErrorMessage = "Descend Fromm Altitude can only 1 - 100000 Feet")]
        public double? descendFrom { get; set; }

        [Range(1, 100000, ErrorMessage = "Descend To Altitude can only 1 - 100000 Feet")]
        public double? descendTo { get; set; }

        [Range(10, 500, ErrorMessage = "Descending Speed can only 50 - 500 NM")]
        public double? descendSpeed { get; set; }
        
        public double? descendAngle { get; set; }

        [Range(1, 100000, ErrorMessage = "Distance Descending In can only 1 - 100000 NM")]
        public double? distanceDescendIn { get; set; }
    }
}
