using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_1
{
    public class Dog:Animal
    {
       

        public override void AnimalCreated()
        {
            Console.WriteLine("Dog was created.");
        }
        
        public override void MakeVoice()
        {
            Console.WriteLine("woof");
        }

        public override void PawCount()
        {
            Console.WriteLine("I have 4 paws.");
        }
    }
}
