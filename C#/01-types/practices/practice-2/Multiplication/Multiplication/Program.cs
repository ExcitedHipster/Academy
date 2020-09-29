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

            var ans = secondNumber * firstNumber;

            Console.WriteLine($"Result is: {ans}");

            bool greater = ans > 10;

            Console.WriteLine($"Greater than 10: {greater}");
        }
    }
}
