using System;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input value: ");
            string valueInString = Console.ReadLine();
            double value=double.Parse(valueInString);

            
            Console.WriteLine("Currency Format " + value.ToString("C2"));
            Console.WriteLine("Percentage Format " + value.ToString("P"));
            Console.WriteLine("Fixed-Point Format "+value.ToString("F"));
            Console.WriteLine("Expotential " + value.ToString("e"));
        }
    }
}
