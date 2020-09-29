
using System;
using System.Collections.Generic;
using System.Text;
namespace Practice_1
{
    
    public class Operations
    {
        public delegate void resultOut(double s);
        public delegate void ValidationCheck(string s);
        public delegate void NumberInput(char s);

        public static double a,b,result,global;
        public static bool isNumber;
        public static string Operator;

        public static resultOut Result = new resultOut(resultOutput);
        public static ValidationCheck ifValid = new ValidationCheck(ifValidNumber);
        public static NumberInput NumberInputDelegate = new NumberInput(InputNumber);

        public Operations()
        {
            NumberInputDelegate('A');
            NumberInputDelegate('B');        
        }


        public static void InputNumber(char whichNumber)
        {
            int numberIndicator = default;
            do
            {
                numberIndicator = default;
                Console.Write($"Enter {whichNumber}: ");
                string aInString = Console.ReadLine();
                ifValid(aInString);
                if (!isNumber)
                {
                    Console.WriteLine("Incorrect input. try again.");
                    numberIndicator = 1;
                    continue;
                }
                if (whichNumber == 'A') a = global;
                else b = global;
            } while (numberIndicator == 1);
        } 
        public static void resultOutput(double result)
        {
            Console.WriteLine($"The result (A {Operator} B): {result}");
        }
        public static void ifValidNumber(string numberInString)
        {
            isNumber = double.TryParse(numberInString, out global);
        }
    }
}