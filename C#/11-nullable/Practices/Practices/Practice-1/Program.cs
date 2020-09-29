using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Point(20, 20);


            var c = a--;
            var d = a++;
            var mult = a * 2;

            Console.WriteLine("Point: [20,20]");

            Console.WriteLine();

            Console.WriteLine("Overload operator --: ");
            Console.WriteLine("Result: " + c);

            Console.WriteLine();

            Console.WriteLine("Overload operator ++: ");
            Console.WriteLine("Result: " + d);

            Console.WriteLine();

            Console.WriteLine("Overload operator *: ");
            Console.WriteLine("(Multiply by 2)");
            Console.WriteLine("Result: " + mult);




        }
    }
}
