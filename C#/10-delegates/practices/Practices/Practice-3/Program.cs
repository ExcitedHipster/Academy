using System;
namespace Practice_3
{
    class Program
    {
        //publicv
        public static bool isDeposit = false, isSkipped = false;
        public static string accountType,indicator="";
        public static int action;
            
        static void Main(string[] args)
        {
           
            int existence = default;


            var operations = new Operations();
            var NameInput = new NameInput();

            operations.NameInputEvent += NameInput.nameInput;

            operations.nameInputEvent();



            while (indicator != "0")
            {
                Console.WriteLine("==================================");
                Console.WriteLine("                Menu              ");
                Console.WriteLine("      1. Open an account          ");
                Console.WriteLine("      2. Withdraw funds           ");
                Console.WriteLine("      3. Add funds to the account ");
                Console.WriteLine("      4. Close account            ");
                if (isDeposit && !isSkipped) Console.WriteLine("      5. Skip the period          ");
                Console.WriteLine("      0. Exit                     ");
                Console.WriteLine("==================================");

                Console.Write("Select an action: ");
                indicator = Console.ReadLine();

                if (existence == 0 && indicator != "1")
                {
                    Console.WriteLine("You must create account first");
                    continue;
                }

                existence = 1;

                
                var IsActionValid = int.TryParse(indicator, out action);

                if (!IsActionValid || (action < 0 && action > 4))
                {
                    Console.WriteLine("Incorrect input.");
                    continue;
                }

                switch ((menu)action)
                {
                    case menu.Add:
                        if (!isSkipped)
                        {
                            Console.WriteLine("You are not allowed to add");
                            continue;
                        }
                        new Add();
                        break;
                    case menu.Withdraw:
                        if (!isSkipped)
                        {
                            Console.WriteLine("You are not allowed to withdraw");
                            continue;
                        }
                        new Withdraw();
                        break;
                    case menu.Open:
                        new Open();
                        break;

                    case menu.Close:
                        existence = 0;
                        isDeposit = isSkipped = false;
                        new Close();
                        break;
                    case menu.Skip:
                        isSkipped = true;
                        Console.WriteLine();
                        Console.WriteLine("Successfully skipped");
                        Console.WriteLine();
                        break;
                    case menu.Exit:
                        Console.WriteLine("Ending Program");
                        return;
                }
            }

        }
    }
}