using System;
using System.Collections.Generic;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userData = new Dictionary<string, string>() { { "giorgi", "grg123" } , { "davit", "qwe890" }, { "davit0", "zxc000" }, { "malvina", "paskey1" } };

            Console.WriteLine("SIGN IN");

            Console.Write("Username: ");
            string NameInput = Console.ReadLine();

            Console.Write("Password: ");
            string PasswordInput = Console.ReadLine();

            Console.WriteLine();

            if (userData.ContainsKey(NameInput))
            {
                userData.TryGetValue(NameInput, out string password);
                if (PasswordInput == password)
                {
                    Console.WriteLine("Hello"+ NameInput);
                }
                else
                {
                    Console.WriteLine("Incorrect password");
                }
            }
            else
            {
                Console.WriteLine("A user with this name could not be found.");
            }

        }
    }
}