using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice_2
{
    public class EmailValidator
    {
        private const string pattern = @"[^@]+@[^\.]+\..+$";

        public static bool IsValid(string email)
        {
            var regexp = new Regex(pattern);
            return regexp.IsMatch(email);
        }

    }
}
