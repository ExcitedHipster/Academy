﻿using System;

namespace GreatestAndNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            string firstString = Console.ReadLine();
            double first = Double.Parse(firstString);

            Console.Write("Input the second number: ");
            string secondString = Console.ReadLine();
            double second = Double.Parse(secondString);

            Console.Write("Input the third number: ");
            string thirdString = Console.ReadLine();
            double third = Double.Parse(thirdString);

            double max;

            max = first > second 
                ? first > third 
                      ? first 
                      : third 
                : second > third 
                      ? second 
                      : third;

            //if (first > second)
            //{
            //    if (first > third)
            //    {
            //        max = first;
            //    }
            //    else
            //    {
            //        max = third;
            //    }
            //}

            //else
            //{
            //    if (second > third)
            //    {
            //        max = second;
            //    }
            //    else
            //    {
            //        max = third;
            //    }
            //}


            //double max = Math.Max(first, second);
            //max = Math.Max(max, third);

            Console.WriteLine($"The greatest number: {max}");

            if(first<0 || second<0 || third < 0)
            {
                Console.WriteLine($"Negative number contained");
            }
        }
    }
}
