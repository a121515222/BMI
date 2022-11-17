// See https://aka.ms/new-console-template for more information

static class BMI
{
    public static string Bmi(double height, double weight)
    {
        var bmi = BmiCounter(height, weight);
        return GetBmiResultOutput(bmi);
    }

    private static double BmiCounter(double height, double weight)
    {
        return weight / (height * height);
    }

    private static string GetBmiResultOutput(double bmi)
    {
        return bmi switch
        {
            <= 18.5 => "Underweight",
            <= 25.0 => "Normal",
            <= 30.0 => "Overweight",
            > 30 => "Obese",
            _ => ""
        };
    }
} 

