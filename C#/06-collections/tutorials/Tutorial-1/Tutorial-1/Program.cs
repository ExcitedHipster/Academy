using System;
using System.Collections.Generic;
using System.Linq;

namespace Tutorial_1
{
    class Program
    {
        private const string ExitCommand = "exit";
        static void Main(string[] args)
        {
            Console.Write("Input numbers: ");

            string numbersString = Console.ReadLine();

            var numbersAsStrings = numbersString.Split(" ").ToList();

            var hasExitCommand = numbersAsStrings.Contains(ExitCommand);

            if (hasExitCommand) numbersAsStrings.Remove(ExitCommand);



            var numbers = numbersAsStrings.Select(x => double.Parse(x)).ToList();

            numbers = numbers.OrderByDescending(item => item).ToList();

            Console.Write("Sorted numbers: ");
            numbers.ForEach(number => Console.Write(number + " "));
            Console.WriteLine();

            PrintMultiplication(numbers);

        }

        static void PrintMultiplication(IEnumerable<double> numbers)
        {

            var min = numbers.Min();
            var max = numbers.Max();

            Console.Write("Multiplication of the smallest and biggest number: " + min * max);

        }


    }
}
