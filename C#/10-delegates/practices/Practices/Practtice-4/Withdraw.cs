﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_4
{
    public class Withdraw:Operations
    {
        public Withdraw()
        {
            message = "Enter account number: ";
            NumberChecker(message);

            message = "";
            NumberChecker("Indicate the amount to be withdraw: ");

            balance -= global;
            ResultOutputDelegate();
        }
    }
}
