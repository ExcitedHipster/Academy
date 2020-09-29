using System;

namespace LeapCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Input year number: ");
            string yearNumberString = Console.ReadLine();
            int yearNumber = Convert.ToInt32(yearNumberString);

            bool LeapCheck = yearNumber % 4 == 0;

            Console.WriteLine($"{yearNumber} is a leap year: {LeapCheck}");

        }
    }
}
