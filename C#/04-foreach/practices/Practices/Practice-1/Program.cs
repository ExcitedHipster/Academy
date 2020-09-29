using System;

namespace Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            string String = "";
            int counter = -1;
            while (String != "0")
            {
                Console.Write("Input nmber: ");
                String = Console.ReadLine();
                
                double number;
                var isNumber = double.TryParse(String, out number);
                if (!isNumber) continue;


                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("Count of entered numbers before zero: " + counter);

        }
    }
}
