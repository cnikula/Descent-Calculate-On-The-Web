using Microsoft.AspNetCore.Components;

namespace CalculateAirPlanDescent.Shared.Components
{
    public partial class DescendComponent
    {
        [Parameter]
        public string? ActionType { get; set; }
        [Parameter]
        public string? CalculationType { get; set; }

        // Fields
        private string? descendFrom { get; set; }
        private string? descendTo { get; set; }
        private string? descendSpeed { get; set; }
        private string? descendAngle { get; set; }
        private string? distanceDescendIn { get; set; }
        private string? test { get; set; } = "test";



        private void GetCalculation()
        {

        }
    }
}
