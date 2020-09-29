using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Jeep : Car
    {
        public Jeep(double jeepMaxSpeed) : base(jeepMaxSpeed) { }


        public void inputJeepCurrentSpeed()
        {
            
            Console.Write("Current speed of jeep: ");
            CheckAndOutputCurrentSpeed();
        }

    }
}
