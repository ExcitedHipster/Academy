using System;

namespace Equality
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

            bool ans = firstNumber == secondNumber;
            Console.WriteLine($"Numbers are equal: {ans}");

        }
    }
}
