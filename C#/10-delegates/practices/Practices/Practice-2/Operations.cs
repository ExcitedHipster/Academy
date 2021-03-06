﻿
using System;
using System.Collections.Generic;
using System.Text;
namespace Practice_2
{
    public delegate void AddNameEvent();
    public delegate void NumberValidationCheck(string s);
    public delegate bool accountNumbChecker(double a);

    public class Operations 
    {
        public event AddNameEvent NameInputEvent; 
        public static string Operator,FirstName,LastName,message;
        public static double accountnumber = 100,balance, global, globalAccountNumber, result;
        public static bool isNumber;

        public static NumberValidationCheck Checker = new NumberValidationCheck(ifValidNumber);
        public static accountNumbChecker accountNumberChecker = new accountNumbChecker(accountNumberCheck);

        public void resultOutput()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Account number: " + accountnumber);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void ifValidNumber(string numberInString)
        {
            
            isNumber = double.TryParse(numberInString, out global);
            
        }

        public static void NumberChecker(string Message)
        {
            do
            {
                Console.Write(Message);
                string ammountInStrings = Console.ReadLine();
                Checker(ammountInStrings);
                if (!isNumber || (message==Message && !accountNumberChecker(global)))  Console.WriteLine("try again");
     
            } while (!isNumber || (message == Message && !accountNumberChecker(global)));
        }

        public static bool accountNumberCheck(double forCheck)
        {

            return forCheck == accountnumber;
        }

        public virtual void nameInputEvent()
        {
            NameInputEvent?.Invoke();
        }
    }
}