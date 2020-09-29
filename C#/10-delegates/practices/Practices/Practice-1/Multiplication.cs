using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Multiplication : Operations
    {
       
        public Multiplication() : base ()
        {
            
            Operator = "*";
            GetResult();
        }
        public static void GetResult()
        {
            result = a * b;
            Result(result);
        }
    }
}
