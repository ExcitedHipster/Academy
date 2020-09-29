using System;
using System.Text.RegularExpressions;

namespace Practice_4
{
    class Program
    {
        public static string[] patterns = new string[] {
                @"^(\d+)\.(\d+)\.(\d+)\.(\d+)$",
                @"[0-9A-Fa-fx]{4}(\.?)[0-9A-Fa-fx]{4}(\.?)[0-9A-Fa-fx]{4}(\.?)[0-9A-Fa-fx]{4}(\.?)",
                @"[0-7]{4}(\.?)[0-7]{4}(\.?)[0-7]{4}(\.?)[0-7]{4}(\.?)",
                @"0[xX][0-9a-fA-F]+",
                @"^[0-9]*$",
                @"^[0-7]*$"
            };
        static void Main(string[] args)
        {

            Console.WriteLine("input vales (type -exit- to end): ");
            string input = default;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "exit")
                {
                    Console.WriteLine("All inpts are valid");
                    return;
                }

                bool check = IsValidIpv4(input);

                if (check == false)
                {
                    Console.WriteLine("invalid input");
                    return;
                }

            }



        }

        public static bool IsValidIpv4(string input)
        {
            foreach (var pattern in patterns)
            {
                var regexp = new Regex(pattern);
                if (regexp.IsMatch(input)) return true;
            }
            return false;
        }
    }
}
