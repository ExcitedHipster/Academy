using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tutorial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var escapeSymbols = new List<string>()
            {
                Regex.Escape("\n"),
                Regex.Escape("\t")
            };

            string input = "\tThis\n is \n text";

            Console.WriteLine(input);

            foreach (var Symbol in escapeSymbols)
            {
                input = Regex.Replace(input, Symbol, string.Empty);
            }

            Console.WriteLine(input);
        }
    }
}


