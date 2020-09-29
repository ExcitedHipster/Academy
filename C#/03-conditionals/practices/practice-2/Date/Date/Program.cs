using System;

namespace _03_conditionals_practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= Menu ======");
            Console.WriteLine("1.The current month");
            Console.WriteLine("2.The current day of week");
            Console.WriteLine("3.The current year");
            Console.WriteLine("0.Exit");
            Console.WriteLine("===================");

            Console.Write("Select menu number: ");
            string inputString = Console.ReadLine();

            int inputNumber;

            var isNumber = Int32.TryParse(inputString, out inputNumber);

            if (!isNumber)
            {
                Console.WriteLine("Incorrect format");
                return;
            }



            if (inputNumber == 0)
            {
                Console.WriteLine("Exiting now...");
            }

            DateTime dateTime = DateTime.Now;

            Console.Write("The current date: ");
            Console.WriteLine(dateTime.ToString("dd.MM.yyyy HH:mm:ss"));

            if (inputNumber == 1)
            {
                Console.Write("Month: ");
                Console.WriteLine(dateTime.ToString("MM"));
            }

            if (inputNumber == 2)
            {
                Console.Write("Day of the week: ");
                Console.WriteLine(dateTime.ToString("dddd"));
            }

            if (inputNumber == 3)
            {
                Console.Write("Year: ");
                Console.WriteLine(dateTime.ToString("yyyy"));
            }

            

        }
    }
}