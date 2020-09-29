using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Triangle
    {
        public double FirstSide { get; set; }

        public double SecondSide { get; set; }

        public double ThirdSide { get; set; }

        //public double Perimeter(double firstSide, double secondSide, double thirdSide)
        public static double Perimeter(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide + secondSide + thirdSide;
        }

        public static bool IsIsosceles(double firstSide, double secondSide, double thirdSide)
        {
            bool check1 = firstSide == secondSide , check2 = firstSide == thirdSide;

            return check1 && check2;

        }


    }
}
