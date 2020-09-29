using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input email: ");
            string input = Console.ReadLine();

            Console.WriteLine(EmailValidator.IsValid(input));
        }
    }
}
