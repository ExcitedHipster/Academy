using System;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Bob", "UI096701", 3);
            student.GetInfo();
            Teacher teacher = new Teacher("Mr Green", "KO723157", 5);
            
            teacher.GetInfo();
            teacher.GoToClasses();
            student.BeReadyForLesson();
            
            teacher.Explain();
            teacher.IncreaseExperience();
            teacher.GetInfo();
        }
    }
}
