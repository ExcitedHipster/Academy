﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Modulo : Operations
    {
        
        public Modulo() : base ()
        {
            
            Operator = "%";
            GetResult();
        }
        public static void GetResult()
        {
            result = a % b;
            if (b != 0) Result(result);
            else Console.WriteLine("You can't divide by 0");
        }
    }
}