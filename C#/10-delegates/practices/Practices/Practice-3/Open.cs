using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    public class Open : Operations
    {
        public Open()
        {

            message = "";
            NumberChecker("Enter the amount to create an account: ");

            balance = global;
            TypeInput();
            message = "";
            Console.WriteLine("Your account has been successfully opened!");
            resultOutput();
        }

        public static void TypeInput()
        {
            Console.WriteLine("Choose account type:");
            Console.WriteLine("    1. Deposit");
            Console.WriteLine("    2. Demand");
            Console.Write("Select an action: ");

            Program.indicator = Console.ReadLine();
            var IsTypeActionValid = int.TryParse(Program.indicator, out Program.action);

            while (!IsTypeActionValid || Program.action < 1 || Program.action > 2)
            {
                Console.WriteLine("Incorrect input.");
                Console.Write("Select an action: ");
                Program.indicator = Console.ReadLine();
                IsTypeActionValid = int.TryParse(Program.indicator, out Program.action);
                continue;
            }

            if (Program.action == 1)
            {
                Program.isDeposit = true;
                Program.accountType = "Deposit";
            }
            else
            {
                Program.isDeposit = false;
                Program.accountType = "Demand";
            }
        } 
    }
}
