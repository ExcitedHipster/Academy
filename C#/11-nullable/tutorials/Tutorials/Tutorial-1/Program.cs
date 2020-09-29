using System;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Point(30, 30);
            var b = new Point(20, 20);

            var c = a - b;
            var d = a + b;

            Console.WriteLine("Overload operator +: ");
            Console.WriteLine("Result: "+d);

            Console.WriteLine();

            Console.WriteLine("Overload operator -: ");
            Console.WriteLine("Result: " + c);

   
           
         
        }
    }
}
