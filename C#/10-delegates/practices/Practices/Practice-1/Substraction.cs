using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Substraction : Operations
    {
        
        public Substraction() : base()
        {
            
            Operator = "-";
            GetResult();
        }
        public static void GetResult()
        {
            result = a - b;
            Result(result);
        }
    }
}
