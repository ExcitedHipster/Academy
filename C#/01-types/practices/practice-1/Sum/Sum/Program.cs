using System;

namespace Sum
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

            var sum = secondNumber + firstNumber;

            Console.WriteLine($"Result is: {sum}");

        }
    }
}
