using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Car
    {
        public static double CurrentSpeed { get; set; }
        public double maxSpeed { get; }

        public Car(double maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        public void inputCarCurrentSpeed()
        {
            Console.Write("Input car current speed: ");
            string carCurrentSpeedString = Console.ReadLine();
            CurrentSpeed = double.Parse(carCurrentSpeedString); 
            Console.Write("Current speed of Car: ");
            CheckAndOutputCurrentSpeed();
        }

        public void CheckAndOutputCurrentSpeed()
        {
           
            if (maxSpeed > CurrentSpeed) Console.WriteLine(CurrentSpeed);
            else Console.WriteLine(maxSpeed);
        }
    }
}
