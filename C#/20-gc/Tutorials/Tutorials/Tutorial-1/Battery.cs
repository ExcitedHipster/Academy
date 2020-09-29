using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_1
{
    class Battery
    {
        public string Name { get; set; }
        public int CurrentCharge { get; set; }
        public Battery(string name)
        {
            Name = name;
        }
    }
}
