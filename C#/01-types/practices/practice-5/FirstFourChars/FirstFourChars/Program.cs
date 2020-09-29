using System;

namespace FirstFourChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Input string: ");
            string String = Console.ReadLine();

            int startIndex = 0 , length = 4;
            Console.WriteLine($"Output string: {String.Substring(startIndex,length)}");

        }
    }
}
