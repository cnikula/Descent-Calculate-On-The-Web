using Microsoft.AspNetCore.Components;

namespace CalculateAirPlanDescent.Pages
{
    public partial class Descend
    {
        [Parameter]
        public string? Pagetitle { get; set; }

        [Parameter]
        public string? ActionType1 { get; set; }

        private string? fullTital { get; set; }

        private void PracTitle()
        {
            fullTital = "Calculater " + Pagetitle.Substring(4);
        }
    }
}
