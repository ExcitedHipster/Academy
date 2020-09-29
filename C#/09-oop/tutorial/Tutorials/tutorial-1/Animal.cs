using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial_1
{
    public abstract class Animal
    {
        public Animal()
        {
            AnimalCreated();
        }
        public abstract void MakeVoice();
        public virtual void PawCount()
        {
            Console.WriteLine("I have no paws.");
        }
        public abstract void AnimalCreated();
    }
}
