using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    public class Person
    {
        public string Name { set; get; }
        public string PassportID { set; get; }
        public Person(string name, string passportID) 
        {
            Name = name;
            PassportID = passportID;
        }

        public Person(){ }

        public virtual void GetInfo()
        {
            Console.Write($"Name: {Name}, PassportID: {PassportID} ");
        }

    }
}
