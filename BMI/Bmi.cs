// See https://aka.ms/new-console-template for more information

namespace BMI
{
    public class Bmi
    {
        public static string GetBmi(double height, double weight)
        {
            var bmi = BmiCounter(height, weight);
            return GetBmiResultOutput(bmi);
        }

        private static double BmiCounter(double height, double weight)
        {
            return (height == 0 || weight == 0) ? 0 : (weight / (height * height));
        }

        private static string GetBmiResultOutput(double bmi)
        {
            return bmi switch
            {
                0 => "weight or height can't be 0",
                <= 18.5 => "Underweight",
                <= 25.0 => "Normal",
                <= 30.0 => "Overweight",
                > 30 => "Obese",
                _ => ""
            };
        }
    } 
}