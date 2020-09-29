using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    public class Student : Person
    {
        public int CourseNumber { set; get; }
        public Student(string name, string passportID, int courseNumber) : base(name, passportID)
        {
            CourseNumber = courseNumber;
        }
        public Student(){}
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Course Number: {CourseNumber}");
        }
    }
}
