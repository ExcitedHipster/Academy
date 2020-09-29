using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(180);
            Jeep myJeep = new Jeep(250);

            myCar.inputCarCurrentSpeed();
            myJeep.inputJeepCurrentSpeed();

        }
    }
}
