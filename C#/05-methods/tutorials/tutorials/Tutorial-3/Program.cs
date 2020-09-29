using System;

namespace Tutorial_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserInput(out double x, out double y, out double z);

            var result = Multiply(x, y, z);

            Console.WriteLine("Result: " + result);

        }

        public static int Multiply(int x, int y) => x * y;




        public static int Multiply(int x, int y, int z) => x * y * z;

        public static double Multiply(double x, double y) => x * y;

        public static double Multiply(double x, double y, double z) => x * y * z;


        public static void GetUserInput(out double x, out double y, out double z)
        {
            Console.Write("Input array of numbers: ");
            string numbersString = Console.ReadLine();

            var numberAsStrings = numbersString.Split(" ");

            x = double.Parse(numberAsStrings[0]);
            y = double.Parse(numberAsStrings[1]);

            z = numberAsStrings.Length == 3
                ? double.Parse(numberAsStrings[2])
                : 1;


        }
    }
}
