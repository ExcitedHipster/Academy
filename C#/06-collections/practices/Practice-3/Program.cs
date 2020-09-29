using System;
using System.Collections.Generic;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dates = new List<string>();

            for (int i = DateTime.Now.Day; i <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            {
                dates.Add($"{i}.{DateTime.Now.Month}.{DateTime.Now.Year}");
            }

            Console.WriteLine("All dates: ");

            foreach (var item in dates)
            {
                Console.WriteLine(item);
            }


            Console.Write("\nSearch date: ");
            string searchDate = Console.ReadLine();

            if (dates.Contains(searchDate))
            {
                Console.WriteLine("Date Presents.");
                Console.Write("Do you want to modify? (y/n) ");

                string check = Console.ReadLine();

                if (check == "y")
                {
                    dates.Remove(searchDate);
                    Console.Write("Put new date: ");
                    string change = Console.ReadLine();
                    dates.Add(change);
                }
                else
                {
                    Console.WriteLine("Done!");
                }

            }

            Console.WriteLine("\nNew dates: ");

            foreach (var item in dates)
            {
                Console.WriteLine(item);
            }
        }
    }
}