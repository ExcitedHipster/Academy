using System;
using System.Globalization;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {

           


            var condition = true;
            do
            { 
                Console.WriteLine(Resources.Resources.Greeting);
                Console.WriteLine(Resources.Resources.Language);
                Console.WriteLine(Resources.Resources.English);
                Console.WriteLine(Resources.Resources.Russian);
                Console.WriteLine(Resources.Resources.Choice);
                //print output here
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-Us");
                        break;

                    case "2":
                        CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("ru-RU");
                        break;

                    default:
                        Console.WriteLine(Resources.Resources.Bye);
                        condition = false;
                        break;
                }

            } while (condition);
        }
    }
}
