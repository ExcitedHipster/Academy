using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_1
{
    public class Snake : Animal
    {
       
        public override void MakeVoice()
        {
            Console.WriteLine("Tsssss!");
        }

        public override void AnimalCreated()
        {
            Console.WriteLine("Snake was created.");
        }

        public override void PawCount()
        {
            Console.WriteLine("I have no paws.");
        }
    }
}
