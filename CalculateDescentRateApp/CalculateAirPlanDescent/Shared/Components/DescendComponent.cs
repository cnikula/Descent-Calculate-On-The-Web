using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using CalculateAirPlanDescent.Data.Models;

namespace CalculateAirPlanDescent.Shared.Components
{
    public partial class DescendComponent
    {
        [Parameter]
        public string? ActionType { get; set; }
        [Parameter]
        public string? CalculationType { get; set; }

        private DescendRateModel descendRateModel = new();

        private bool Isdisable()
        {
            if (ActionType == "disable1")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool Isdisable2()
        {
            if (ActionType == "disable1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void GetCalculation()
        {

        }
    }
}
