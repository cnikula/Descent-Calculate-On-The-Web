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
        private string? calculationType { get; set; }

        private bool errorMessage = false;
        private string? rersult = string.Empty;
        private bool? hide = true;
        private DescendRateModel descendRateModel = new();

        protected override void OnInitialized()
        {
            calculationType = CalculationType;
        }

        private bool Isdisable()
        {
            if (ActionType == "disable1")
            {   
                // Reset controls if need
                if (calculationType != CalculationType)
                {
                    Reset();
                    calculationType = CalculationType;
                }
                else
                {
                    calculationType = CalculationType;
                }
                
                return false;
            }
            else
            {
                if (calculationType != CalculationType)
                {
                    Reset();
                    calculationType = CalculationType;
                }
                else
                {
                    calculationType = CalculationType;
                }

                return true;
            }
        }

        private bool Isdisable2()
        {
            if (ActionType == "disable1")
            {
                if (calculationType != CalculationType)
                {
                    Reset();
                    calculationType = CalculationType;
                }
                else
                {
                    calculationType = CalculationType;
                }

                return true;
            }
            else
            {
                if (calculationType != CalculationType)
                {
                    Reset();
                    calculationType = CalculationType;
                }
                else
                {
                    calculationType = CalculationType;
                }

                return false;
            }
        }

        private void Reset()
        {
            hide = true;
            errorMessage = false;
            rersult = string.Empty;

            descendRateModel.descendFrom = null;
            descendRateModel.descendTo = null;
            descendRateModel.descendAngle = null;
            descendRateModel.descendSpeed = null;
            descendRateModel.distanceDescendIn = null;
        }

        private void GetCalculation()
        {
            // Determine what calculation to perform. We can determine
            // the type calculation by CalculationType parameter
            double calculationResult;
            double tempValue;

            hide = false;

            switch (CalculationType)
            {
                case "Calc Descend Only":
                    // validate properties
                    if (descendRateModel.descendFrom == null || descendRateModel.descendTo == null || descendRateModel.distanceDescendIn == null)
                    {
                        // display error message
                        errorMessage = true;
                        rersult = "* No Calculation was performed due to all/or some required Input are Empty";
                    }
                    else
                    {
                        errorMessage = false;
                        rersult = string.Empty;

                        calculationResult = (double)((descendRateModel.descendFrom - descendRateModel.descendTo) / descendRateModel.distanceDescendIn);
                        rersult = $"You need to descend {Math.Round(calculationResult).ToString()} feet per nautical mile.";
                    }

                    break;

                case "Calc Descend Speed":
                    
                    if (descendRateModel.descendAngle == null || descendRateModel.descendSpeed == null)
                    {
                        // display error message
                        errorMessage = true;
                        rersult = "* No Calculation was performed due to all/or some required Input are Empty";
                    }
                    else
                    {
                        errorMessage = false;
                        rersult = string.Empty;

                        tempValue = (double)(descendRateModel.descendSpeed / 60);

                        calculationResult = (double)(descendRateModel.descendAngle * tempValue * 100);
                        rersult = $" At {descendRateModel.descendSpeed.ToString()} NM, you will need to descend {Math.Round(calculationResult).ToString()} feet per nautical mile.";
                    }

                    break;

                case "Calc Descend Angle":

                    if (descendRateModel.descendFrom == null || descendRateModel.descendTo == null || descendRateModel.distanceDescendIn == null)
                    {
                        // display error message
                        errorMessage = true;
                        rersult = "* No Calculation was performed due to all/or some required Input are Empty";
                    }
                    else
                    {
                        errorMessage = false;
                        rersult = string.Empty;
                        double FPNM = 0;

                        FPNM = (double)((descendRateModel.descendFrom - descendRateModel.descendTo) / descendRateModel.distanceDescendIn);

                        calculationResult = FPNM / 100;

                        rersult = $"You will need to pitch down {Math.Round(calculationResult, 2).ToString()} " +
                                  $"degrees at {Math.Round(FPNM).ToString()} FPNM to accomplish the descent";
                    }

                    break;


            }
        }
    }
}
