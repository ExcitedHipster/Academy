using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    public class Teacher:Person
    {
        public int ExperienceInLessons { get; set; }

        public Teacher(string name ,string passportID,int experienceInLessons):base(name,passportID)
        {
            ExperienceInLessons = experienceInLessons;
        }
        public void GoToClasses()
        {
            Console.WriteLine("I am going to class");
        }

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }

        public void IncreaseExperience()
        {
            ExperienceInLessons++;
        }

        public override void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Teacher");
            base.GetInfo();
            Console.WriteLine($"ExperienceInLessons: {ExperienceInLessons}");
            Console.WriteLine();
        }
    }
}
