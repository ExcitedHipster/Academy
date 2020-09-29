using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input length of array: ");
            string ArrayLengthString = Console.ReadLine();
            int length;
            var isInt = int.TryParse(ArrayLengthString, out length);

            if (!isInt) { Console.WriteLine("Incorrect format"); return; }

            byte max = 0;
            string answerString = "Array: ";
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Input number {i + 1}: ");
                string ArrayNumberString = Console.ReadLine();
                byte number;
                var isByte = byte.TryParse(ArrayNumberString, out number);

                if (!isByte) { Console.WriteLine("Number is not a byte! Try again."); i--; continue; }

                //Console.Write($"{number} ");
                answerString += number.ToString()+" ";

               
                max = Math.Max(max, number);

            }

            Console.WriteLine(answerString);
            Console.WriteLine("The biggest in array: " + max);

        }
    }
}
