using System;

namespace IntToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input double number: ");
            string firstNumberString = Console.ReadLine();
            double firstNumberDouble = Convert.ToDouble(firstNumberString);

            int firstNumberInt = Convert.ToInt32(firstNumberDouble);

            Console.WriteLine($"The answer is: {firstNumberInt}");
            
        }
    }
}
