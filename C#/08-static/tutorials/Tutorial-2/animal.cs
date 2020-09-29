using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_2
{
    class animal
    {
        public static int NumberOfLegs = 4;
        public string Name { get; set; }
        static animal()
        {
            Console.WriteLine("Number of legs " + NumberOfLegs);
            Console.WriteLine("Static constructor running");
        }

        public animal()
        {
            Console.WriteLine("Parameterless constructor running");
        }

        public animal(string name)
        {
            Console.WriteLine("Name constructor running");
            Name = name;
        }

    }
}
