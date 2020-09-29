using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your name: ");
            string UserName = Console.ReadLine();

            Console.Write("Input weight (kg): ");
            string UserWeightString = Console.ReadLine();
            double UserWeight = double.Parse(UserWeightString);

            Console.Write("Input height (m): ");
            string UserHeightString = Console.ReadLine();
            double UserHeight = double.Parse(UserHeightString);

            double ans = BMICalculator(UserHeight, UserWeight);

            Console.WriteLine($"{UserName}, your BMI = {ans}");
            //Console.WriteLine($"{UserName}, your BMI = {ans}");

            string ansString;

            if (ans < 18.5) ansString = "Underweight";
            else if (ans >= 18.5 && ans < 25) ansString = "Normal weight";
            else if (ans >= 25 && ans < 30) ansString = "Overweight";
            else ansString = "Obesity";

            Console.WriteLine($"BMI category: {ansString}");
        }

        static double BMICalculator(double height, double weight)
        {
            double BMI = weight / (height * height);
            return BMI;
        }
    }
}

