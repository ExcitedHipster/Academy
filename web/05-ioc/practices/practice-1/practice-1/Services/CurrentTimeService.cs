using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice_1
{
    public class CurrentTimeService : ITimeService
    {
        public string GetTime()
        {
            string currentTime = $"Hour: {DateTime.Now.Hour} \nMinute: {DateTime.Now.Minute}\nSecond: { DateTime.Now.Second}";
            return currentTime;
        }
    }
}
