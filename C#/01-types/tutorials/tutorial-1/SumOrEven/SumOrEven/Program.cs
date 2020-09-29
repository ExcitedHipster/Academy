using System;

namespace SumOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            string firstNumberString = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstNumberString);

            Console.Write("Input second number: ");
            string secondNumberString = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondNumberString);

            double sum = firstNumber + secondNumber;
            Console.WriteLine($"Result: {sum}");

            var intSum = (int)sum;

            Console.WriteLine();

            bool isEven = intSum % 2 == 0;

            Console.WriteLine($"Result is even number: {isEven}");
  
        }
    }
}
