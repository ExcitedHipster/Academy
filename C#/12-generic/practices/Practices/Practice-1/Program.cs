using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_1
{
    class Program<T>
    {
        public static List<T> list = new List<T>();
        static void Main(string[] args)
        {   
            Console.WriteLine("Array os strings:");
            string StringArray = Console.ReadLine();
       
            list = StringArray.Split(" ").ToList();
        }

        Dictionary<T, int> CountEqualValues<T>(List<T> list)
        {

        }
    }
}
