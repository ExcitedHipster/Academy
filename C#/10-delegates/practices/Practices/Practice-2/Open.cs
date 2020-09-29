using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    public class Open:Operations
    {
        public Open() 
        {
            message = "";
            NumberChecker("Enter the amount to create an account: ");
                
            balance = global;

            message = "";
            Console.WriteLine("Your account has been successfully opened!");
            resultOutput();
        }
    }
}
