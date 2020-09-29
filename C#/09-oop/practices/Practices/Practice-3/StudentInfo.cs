using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    public class StudentInfo:Student
    {
        public string Address { get; set; }
        public StudentInfo(string address)
        {
            Address = address;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine();
        } 
    }
}
