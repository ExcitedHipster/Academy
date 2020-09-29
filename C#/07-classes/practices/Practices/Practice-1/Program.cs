using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input the first side A: ");
            string InputFirstSideString = Console.ReadLine();
            double FirstSide;
            var isDouble = double.TryParse(InputFirstSideString, out FirstSide);
            if (!isDouble || FirstSide <= 0)
            {
                Console.WriteLine("Incorrect input format");
                return;
            }


            Console.Write("Input the first side B: ");
            string InputSecondSideString = Console.ReadLine();
            double SecondSide;
            var isDouble2 = double.TryParse(InputSecondSideString, out SecondSide);
            if (!isDouble2 || SecondSide <= 0)
            {
                Console.WriteLine("Incorrect input format");
                return;
            }


            Console.Write("Input the first side C: ");
            string InputThirdSideString = Console.ReadLine();
            double ThirdSide;
            var isDouble3 = double.TryParse(InputThirdSideString, out ThirdSide);
            if (!isDouble3 || ThirdSide <= 0)
            {
                Console.WriteLine("Incorrect input format");
                return;
            }


            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Triangle");

            Console.WriteLine($"A: {FirstSide}");
            Console.WriteLine($"B: {SecondSide}");
            Console.WriteLine($"C: {ThirdSide}");

            double perimeter = Triangle.Perimeter(FirstSide, SecondSide, ThirdSide);
            Console.WriteLine($"Perimeter {perimeter}");

            bool isOscele = Triangle.IsIsosceles(FirstSide, SecondSide, ThirdSide);
            Console.WriteLine($"Isosceles: {isOscele}");
        }
    }
}
