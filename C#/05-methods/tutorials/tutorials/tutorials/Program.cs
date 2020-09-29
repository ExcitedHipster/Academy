﻿using System;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = GetUserInput();
            PrintWordsAmount(userInput);
        }

        public static string GetUserInput()
        {
            Console.Write("Input string: ");
            string input = Console.ReadLine();

            return input;
        }

        public static void PrintWordsAmount(string userInput)
        {
            string[] stringArray = userInput.Split(" ");

            Console.WriteLine("Number of words in the string: " + stringArray.Length);
        }

    }
}
