using System;
using System.Text;
namespace practice_2
{
    class Program
    {
        public static string Year = "", Month = "", WeekDay = "", Hour = "", Minute = "", Second = "";
        public static DateTime InputDate = DateTime.Now;

        static void Main(string[] args)
        {

            MenuOutput();

            string MenuOption = Console.ReadLine();
      
            Console.WriteLine();
            Console.WriteLine();

            if (MenuOption == "2")
            {
                Option2Input();
                InputDate = new DateTime(int.Parse(Year), int.Parse(Month), int.Parse(WeekDay), int.Parse(Hour), int.Parse(Minute), int.Parse(Second));
            }
            
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();

                AvailableFormatsOutput();

                string FormatOption = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine();

                var result = castFormatOnDate(FormatOption, InputDate);
                if (result == "break") return;
                Console.WriteLine(castFormatOnDate(FormatOption, InputDate));
            }
        }

        public static void MenuOutput()
        {
            Console.WriteLine("========================= MENU ==============================");
            Console.WriteLine("1. Use current date");
            Console.WriteLine("2. Enter the date");
            Console.WriteLine("=============================================================");
            Console.Write("Select your choose: ");
        }

        public static void Option2Input()
        {
            Console.Write("Enter the year: ");
            // string iput = Console.ReadLine();
            Year = Console.ReadLine();

            Console.Write("Enter the Month: ");
            Month = Console.ReadLine();

            Console.Write("Enter the day: ");
            WeekDay = Console.ReadLine();

            Console.Write("Enter the Hour: ");
            Hour = Console.ReadLine();

            Console.Write("Enter the Minute: ");
            Minute = Console.ReadLine();

            Console.Write("Enter the Second: ");
            Second = Console.ReadLine();
        }

        public static void AvailableFormatsOutput()
        {
            Console.WriteLine("Available formats:");
            Console.WriteLine("1. Short date pattern");
            Console.WriteLine("2. Long date pattern");
            Console.WriteLine("3. Full date/time pattern (short time)");
            Console.WriteLine("4. Full date/time pattern (long time): ");
            Console.WriteLine("5. General date/time pattern (short time): ");
            Console.WriteLine("6. General date/time pattern (long time): ");
            Console.WriteLine("7. Month/day pattern: ");
            Console.WriteLine("8. Round-trip date/time pattern: ");
            Console.WriteLine("9. RFC1123 pattern: ");
            Console.WriteLine("10. Sortable date/time pattern: ");
            Console.WriteLine("11. Short time pattern: ");
            Console.WriteLine("12. Long time pattern: ");
            Console.WriteLine("0. Exit. ");
            Console.Write("Select your choose: ");
        }

        public static string castFormatOnDate(string option,DateTime date) 
        {
            if (option == "1") return InputDate.ToString("d");
            if (option == "2") return InputDate.ToString("D");
            if (option == "3") return InputDate.ToString("f");
            if (option == "4") return InputDate.ToString("F");
            if (option == "5") return InputDate.ToString("g");
            if (option == "6") return InputDate.ToString("G");
            if (option == "7") return InputDate.ToString("m");
            if (option == "8") return InputDate.ToString("o");
            if (option == "9") return InputDate.ToString("r");
            if (option == "10") return InputDate.ToString("s");
            if (option == "11") return InputDate.ToString("t");
            if (option == "12") return InputDate.ToString("T");
            else return "break";
        }
    }
}