using System;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //save user input
            //validate format
            //comparing input
            //display numbers

            Console.Write("Input first number: ");
            string firstInput = Console.ReadLine();
            int first;
            bool isFirstInputValid = int.TryParse(firstInput, out first);

            if (!isFirstInputValid)
            {
                Console.WriteLine("Incorrect format");
                return;
            }

            Console.Write("Input second number: ");
            string secondInput = Console.ReadLine();
            int second;
            bool isSecondInputValid = int.TryParse(secondInput, out second);

            if (!isSecondInputValid)
            {
                Console.WriteLine("Incorrect format");
                return;
            }

            if (first >= second)
            {
                Console.WriteLine("Range can not be calculated");
                return;
            }

            for(var i = first+1; i < second; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
