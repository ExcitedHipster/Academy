using System;
using System.Collections.Generic;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> randomWords = new List<string>() { "milk" , "cheese", "team", "apple"};
  
            Console.WriteLine("====================================");

            foreach (var item in randomWords)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("====================================");

            string inputString;

            do
            {
                Console.Write("\nInput word: ");
                inputString = Console.ReadLine();
                string inputStringLower = inputString.ToLower();

                if (inputString != "Want to Exit")
                {
                    foreach (var item in randomWords)
                    {
                        if (item == inputStringLower)
                        {
                            Console.WriteLine($"\n{inputString} already exists in array");
                            goto end;
                        }
                    }

                    randomWords.Add(inputStringLower);

                    Console.WriteLine();

                    Console.WriteLine("====================================");

                    foreach (var item in randomWords)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("====================================");

                end:;
                }
            } 
            
            while (inputString != "Want to Exit");

            Console.WriteLine("Goodbye!");
        }
    }
}