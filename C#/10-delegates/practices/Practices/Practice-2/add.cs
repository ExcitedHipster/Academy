﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    public class Add:Operations
    {
        public Add()
        {
            message = "Enter account number: ";
            NumberChecker(message);

            message = "";
            NumberChecker("Indicate the amount to be add: ");

            balance += global;
            resultOutput();
        }
    }
}
