using System;

namespace Practice_2
{
    

    class Program
    {
        public static string vowels= "aeiouyAEIOUY";
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string InputWord = Console.ReadLine();

            int cnt = 0;
            foreach (var item in InputWord)
            {
                bool check = isVowel(item);
                if (check == true) cnt++;
            }
            Console.WriteLine($"Number of vowels: {cnt}");
        }

        static bool isVowel(char CharToCheck)
        {
            for (int i=0;i<vowels.Length;i++)
            {
                    if(vowels[i]==CharToCheck)return true;
            }
            
             return false;
        }
    }
}
