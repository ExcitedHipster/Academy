using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Point(20, 20);
            var b = new Point(25, 22);

            string aString = "[20, 20]";
            string bString = "[25, 22]";

            var c = a == b;
            var d = a < b;
            var e = a > b;
            var f = a >= b;
            var g = a <= b;

            Console.WriteLine("First Point: " + aString);
            Console.WriteLine("Second Point: " + bString);

            Console.WriteLine();

            Console.WriteLine(aString + " == " + bString);
            Console.WriteLine("Result: " + c);

            Console.WriteLine();

            Console.WriteLine(aString + "Overload operator < " + bString);
            Console.WriteLine("Result: " + d);

            Console.WriteLine();

            Console.WriteLine(aString + "Overload operator > " + bString);
            Console.WriteLine("Result: " + e);

            Console.WriteLine();

            Console.WriteLine(aString + " >= " + bString);
            Console.WriteLine("Result: " + f);

            Console.WriteLine();

            Console.WriteLine(aString + " <= " + bString);
            Console.WriteLine("Result: " + g);



        }
    }
}
