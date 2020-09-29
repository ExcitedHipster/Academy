using System;
namespace Practice_1
{
    class Program
    {
        //public
        static void Main(string[] args)
        { 
            string indicator = "";
            while (indicator != "0")
            { 
                Console.WriteLine("==================================");
                Console.WriteLine("                Menu              ");
                Console.WriteLine("      1. Addition                 ");
                Console.WriteLine("      2. Subtraction              ");
                Console.WriteLine("      3. Multiplication           ");
                Console.WriteLine("      4. Division                 ");
                Console.WriteLine("      5. The remainder of division");
                Console.WriteLine("      0. Exit                     ");
                Console.WriteLine("==================================");

                Console.Write("Select an action: ");
                indicator = Console.ReadLine();
                int action;
                var IsActionValid = int.TryParse(indicator, out action);
                if (!IsActionValid || (action < 0 && action > 5))
                {
                    Console.WriteLine("...");
                    continue;
                }
                switch ((menu)action)
                {
                    case menu.Addition:
                        new Addition();
                        break;
                    case menu.Division:
                        new Division();
                        break;
                    case menu.Multiplication:
                        new Multiplication();
                        break;
                    case menu.Substraction:
                        new Substraction();
                        break;
                    case menu.Modulo:
                        new Modulo();
                        break;
                    case menu.Exit:
                        Console.WriteLine("Ending Program");
                        return;
                }
            }
        }
    }
}