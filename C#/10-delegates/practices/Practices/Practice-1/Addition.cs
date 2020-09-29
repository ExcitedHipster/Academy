using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Addition : Operations
    {
        public Addition():base()
        {
            Operator = "+";
            GetResult();
        }
        public static void GetResult()
        {
            result = a - b;
            Result(result);
        }
    }
}
