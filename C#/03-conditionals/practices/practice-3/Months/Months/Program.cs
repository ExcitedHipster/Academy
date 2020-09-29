using System;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the nuumber of months: ");
            string stringMonthNumber = Console.ReadLine();
            int monthNumber;
            var isNumber = int.TryParse(stringMonthNumber, out monthNumber);

            if (!isNumber) { Console.WriteLine("Incorrect format!"); }

            switch ((Months)monthNumber)
            {
                case Months.January:
                    Console.WriteLine($"Month: {Months.January.ToString()}");
                    break;

                case Months.February:
                    Console.WriteLine($"Month: {Months.February.ToString()}");
                    break;

                case Months.March:
                    Console.WriteLine($"Month: {Months.March.ToString()}");
                    break;

                case Months.April:
                    Console.WriteLine($"Month: {Months.April.ToString()}");
                    break;

                case Months.May:
                    Console.WriteLine($"Month: {Months.May.ToString()}");
                    break;

                case Months.June:
                    Console.WriteLine($"Month: {Months.June.ToString()}");
                    break;

                case Months.July:
                    Console.WriteLine($"Month: {Months.July.ToString()}");
                    break;

                case Months.August:
                    Console.WriteLine($"Month: {Months.August.ToString()}");
                    break;

                case Months.September:
                    Console.WriteLine($"Month: {Months.September.ToString()}");
                    break;

                case Months.October:
                    Console.WriteLine($"Month: {Months.October.ToString()}");
                    break;

                case Months.November:
                    Console.WriteLine($"Month: {Months.November.ToString()}");
                    break;

                case Months.December:
                    Console.WriteLine($"Month: {Months.December.ToString()}");
                    break;

                default:
                    Console.WriteLine($"Month {monthNumber} does not exist");
                    break;
            }
        }
    }
}
