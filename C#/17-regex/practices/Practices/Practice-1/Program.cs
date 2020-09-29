using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tutorial_2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Test string:");
            string input = Console.ReadLine();

            input = Regex.Replace(input, Regex.Escape("&#160;"), " ");
            input = Regex.Replace(input, Regex.Escape("&#38;"), "&");
            input = Regex.Replace(input, Regex.Escape("&#63;"), "?");


            Console.WriteLine(input);
        }
    }
}
