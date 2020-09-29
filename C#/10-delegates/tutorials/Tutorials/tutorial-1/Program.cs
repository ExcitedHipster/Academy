using System;
using System.Linq;
using System.Collections.Generic;
namespace tutorial_1
{
    public delegate void Sort<T>(List<T> list);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("source array: ");
            string numbersString = Console.ReadLine();

            var numbersStringList = numbersString.Split(" ").ToList();

            var numbers = numbersStringList.Select(x => int.Parse(x)).ToList();

            Sort<int> sort = SortAscending;

     
            sort += SortDescending;

            sort(numbers);
            
          
        }

        public static void SortAscending<T>(List<T> list)
        {
            var result = list.OrderBy(x => x).ToList();
            result.ForEach(x => PrintNumber(x));
            Console.WriteLine();
        }
        public static void SortDescending<T>(List<T> list)
        {
            var result = list.OrderByDescending(x => x).ToList();
            result.ForEach(x => PrintNumber(x));
            Console.WriteLine();
        }

        public static void PrintNumber<T>(T number)
        {
            Console.Write(number + " ");
        }

    }
}
