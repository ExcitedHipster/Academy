using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Bob", "UI096701", 3);
            student.GetInfo();

            StudentInfo info = new StudentInfo("4, Ramdas Rd, Gujarat");
            info.GetInfo();
        }
    }
}
