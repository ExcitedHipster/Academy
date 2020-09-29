using System;
using System.Text;
using System.Collections.Generic;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string CheckString = "y";
            List<string> historyString = new List<string>(); ;

            while (CheckString == "y")
            {
                Console.WriteLine("==============================");

                Console.Write("Input number X: ");
                string StringNumber = Console.ReadLine();
                double firstNumber;

                var IsNumber1 = double.TryParse(StringNumber, out firstNumber);
                if (!IsNumber1)
                {
                    Console.WriteLine($"Inaccessible operation: {StringNumber} is not a number");
                    historyString.Add($"Inaccessible operation: {StringNumber} is not a number");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Continue (y/n): ");
                    Console.WriteLine();
                    Console.WriteLine();
                    CheckString = Console.ReadLine();
                    continue;
                }

                Console.Write("Input number Y: ");
                StringNumber = Console.ReadLine();
                double secondNumber;

                var IsNumber2 = double.TryParse(StringNumber, out secondNumber);
                if (!IsNumber2)
                {
                    Console.WriteLine($"Inaccessible operation: {StringNumber} is not a number");
                    historyString.Add($"Inaccessible operation: {StringNumber} is not a number");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Continue (y/n): ");
                    Console.WriteLine();
                    Console.WriteLine();
                    CheckString = Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Choose a mathematical operation from the following list: ");
                Console.WriteLine("1-Add");
                Console.WriteLine("2-Substract");
                Console.WriteLine("3-Multiply");
                Console.WriteLine("4-Divide");
                Console.Write("option: ");
                string option = Console.ReadLine();
                int optionNumber = int.Parse(option);

                Console.Write("Result: ");
                double ans;
                switch ((menu)optionNumber)
                {
                    case menu.Add:
                        ans = firstNumber + secondNumber;
                        Console.Write($"{firstNumber} + {secondNumber} = {ans}");
                        historyString.Add($"{firstNumber} + {secondNumber} = {ans}");
                        break;

                    case menu.Divide:
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Inaccessible operation: You cannot divide by zero.");
                            historyString.Add("Inaccessible operation: You cannot divide by zero.");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("Continue (y/n): ");
                            Console.WriteLine();
                            Console.WriteLine();
                            CheckString = Console.ReadLine();
                            continue;
                        }
                        ans = firstNumber / secondNumber;
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {ans}");
                        historyString.Add($"{firstNumber} / {secondNumber} = {ans}");
                        break;

                    case menu.Multiply:
                        ans = firstNumber * secondNumber;
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {ans}");
                        historyString.Add($"{firstNumber} * {secondNumber} = {ans}");
                        break;

                    case menu.Substract:
                        ans = firstNumber - secondNumber;
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {ans}");
                        historyString.Add($"{firstNumber} - {secondNumber} = {ans}");
                        break;

                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Continue (y/n): ");
                CheckString = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------History-------");

            int i = 1;
            foreach (var item in historyString)
            {
                Console.WriteLine(i + ") " + item);
                i++;
            }

        }
    }
}
