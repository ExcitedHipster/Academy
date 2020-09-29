using System;
using System.Linq;

namespace Tutorial_1
{ 
    [Info("Gigi",1,"Tutorial on attributes","Andrii","Max")]
    class Program
    {
       
        static void Main(string[] args)
        {
            InfoAttribute attr = (InfoAttribute)typeof(Program).GetCustomAttributes(false).First();
            Console.WriteLine($"Author: {attr.Author}");
            Console.WriteLine($"Revision: {attr.Revision}");
            Console.WriteLine($"Description: {attr.Description}");
            Console.WriteLine($"Reviewers: {string.Join(", ",attr.Reviewers)}");
        }
    }
}
