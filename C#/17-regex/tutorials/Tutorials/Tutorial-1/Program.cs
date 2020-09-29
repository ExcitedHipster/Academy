
using System;
using System.Text.RegularExpressions;

namespace Tutorial_1
{
    class Program
    {
        private const string Success = "Word validated";
        private const string Failure = "Word failed validated";
        static void Main(string[] args)
        {
            Console.Write("Input word: ");

            string word = Console.ReadLine();

            var regexp = new Regex("[Aa][a-z]{3,}g");

            string result = regexp.IsMatch(word)
                            ? Success
                            : Failure;

            Console.WriteLine(result);

        }
    }
}
