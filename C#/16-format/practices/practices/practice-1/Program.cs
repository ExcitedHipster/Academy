using System;
using System.Text;
namespace practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string author = "It is â t€st";
            // Convert a C# string to a byte array
            byte[] asciiBytes = Encoding.ASCII.GetBytes(author);
            byte[] UTF8Bytes = Encoding.UTF8.GetBytes(author);
            Console.Write("Byte codes: ");
            foreach (byte b in asciiBytes)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine();
            string asci = Encoding.ASCII.GetString(asciiBytes);
            Console.WriteLine(asci);
            asci = Encoding.UTF8.GetString(UTF8Bytes);
            Console.WriteLine(asci);
        }
    }
}