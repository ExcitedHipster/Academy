using System;

namespace Tutorial_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string text = "some string";

            Console.WriteLine(text);
            Console.WriteLine(text.ToHtmlComment());
            Console.WriteLine(text.CutHalfString());
        }
    }
}
