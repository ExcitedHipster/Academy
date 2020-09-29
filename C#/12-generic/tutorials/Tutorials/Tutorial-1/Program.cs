using System;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point<int>(30, 30);

            var doublePoint = new Point<double>(12.546, 55.99);

            var stringPoint = new Point<string>("Hello", "World");

            var anon = new { name = "gigi", point };
            

            Console.WriteLine(point);
            Console.WriteLine(stringPoint);
            Console.WriteLine(doublePoint);

        }
    }
}
