using System;

namespace IfDevisible
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            string numberString = Console.ReadLine();
            int number;
            var IfNumber = int.TryParse(numberString, out number);

            if (!IfNumber)
            {
                Console.WriteLine("Incorrect format");
            }

            else if (number % 10 == 0) { Console.WriteLine("Number is divisible by 5 and 10"); }
                 else if (number % 5 == 0) { Console.WriteLine("Number is divisible by 5 only"); }
                      else Console.WriteLine("Number is not divisible by 5 and 10");


        }
    }
}
