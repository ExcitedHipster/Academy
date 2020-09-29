using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice_3
{

    public static class FacebookAccountValidator
    {
        public static string[] AccPatterns = new string[]{
            "^[A-Z]([a-z]+)$",
            "^[A-Z]([a-z]+)$",
            "^[A-Za-z]([A-Za-z_-]+)[A-Za-z]$",
            @"[+]+995\d{10}",
            @"(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{6,12})"

         };
        //public static int i=default;
        public static string Validate(string input, int i)
        {
            var regexp = new Regex(AccPatterns[i]);
          
            if (!regexp.IsMatch(input))
            {
                Console.WriteLine("Invalid input, try again!");
                return default;
            }
            return input;
        }

    }
}
