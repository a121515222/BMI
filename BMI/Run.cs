// See https://aka.ms/new-console-template for more information

using BMI;
namespace Kata
{
    class Porgram
    {
        static void Main()
        {
            var height = 0;
            var weight = 166.6;
            Console.WriteLine(BmiTool.GetBmi(height, weight));
        }
    }
}
