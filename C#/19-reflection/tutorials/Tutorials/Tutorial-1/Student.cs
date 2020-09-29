using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_1
{
    public class Student
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public void DisplayData(string data)
        {
            Console.WriteLine($"Name: {Name} Number: {Number}");
        }
    }
}
