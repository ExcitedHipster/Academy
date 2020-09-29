using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    public class Student : Person
    {
        public int CourseNumber { set; get; }
        public Student(string name, string passportID, int courseNumber) : base(name, passportID)
        {
            CourseNumber = courseNumber;
        }
        public Student(){}

        public void BeReadyForLesson()
        { 
            Console.WriteLine("I am ready for the lesson");
        } 
        public override void GetInfo()
        {
            Console.WriteLine("Student");
            base.GetInfo();
            Console.WriteLine($"Course Number: {CourseNumber}");
            Console.WriteLine();
        }
    }
}
