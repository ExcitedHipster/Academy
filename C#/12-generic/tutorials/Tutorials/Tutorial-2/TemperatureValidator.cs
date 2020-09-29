using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_2
{
    public class TemperatureValidator
    {
        private const int MinTemperature = -60;
        private const int MaxTemperature = 60;
        private const string temperatureError = "Temperature is out of range";
        public int Temperature { get; set; }
        public TemperatureValidator(int temp)
        {
            if (IsTemperatureInRange(temp))
            {
                throw new IncredibleTemperatureException(temperatureError);
            }
            Temperature = temp;
        }

        private bool IsTemperatureInRange(int temp)
        {
            return temp < MinTemperature || temp > MaxTemperature;
        }
    }
}
