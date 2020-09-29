using System;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            string aString = Console.ReadLine();
            double a = double.Parse(aString);

            Console.Write("Input c: ");
            string cString = Console.ReadLine();
            double c = double.Parse(cString);

            Console.Write("Input angle: ");
            string angleString = Console.ReadLine();
            double angle = double.Parse(angleString);

            if (angle > 179 || angle < 1) { Console.WriteLine("Agle value should be in range 1 ... 179"); return; }
            if (a < 1 || c < 1) { Console.WriteLine("Side's length value should be greater than 1"); return; }

            Console.WriteLine($"Result: {CalculateTriangleArea(a, c, angle)}");
        }

        static double CalculateTriangleArea(double a, double c, double angle)
        {
            angle = RadianToDegree(angle);
            double SinOfAngle = Math.Sin(angle);
            double AreaOfTriangle = a * c * SinOfAngle / 2;
            return AreaOfTriangle;
        }

        static double RadianToDegree(double angle)
        {
            return angle * (Math.PI / 180.0);
        }
    }
}
