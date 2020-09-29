using System;
namespace Practice_2
{
    class Program
    {
        //publicv
            
        static void Main(string[] args)
        {
            string  indicator = "";
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
                Console.WriteLine("      0. Exit                     ");
                Console.WriteLine("==================================");

                Console.Write("Select an action: ");
                indicator = Console.ReadLine();

                if(existence == 0 && indicator != "1")
                {
                    Console.WriteLine("You must create account first");
                    continue;
                }

                existence = 1;

                int action;
                var IsActionValid = int.TryParse(indicator, out action);

                if (!IsActionValid || (action < 0 && action > 4))
                {
                    Console.WriteLine("Incorrect input.");
                    continue;
                }

                switch ((menu)action)
                {
                    case menu.Add:
                        new Add();
                        break;
                    case menu.Withdraw:
                        new Withdraw();
                        break;
                    case menu.Open:
                        new Open();
                        break;
                    case menu.Close:
                        existence = 0;
                        new Close();
                        break;
                    case menu.Exit:
                        Console.WriteLine("Ending Program");
                        return;
                }
            }
        }
    }
}