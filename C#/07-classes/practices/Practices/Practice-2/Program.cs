using System;
using System.Collections.Generic;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> carCharacteristic = new List<Cars>(); ;

            string option = "";

            while (option != "3")
            { 
                Console.WriteLine("=====================================");
                Console.WriteLine("1. CHECK ALL CARS");
                Console.WriteLine("2. ADD NEW CAR");
                Console.WriteLine("3. Exit");

                Console.Write("Select option: ");
                option=Console.ReadLine();
                int optionNumber;
                var isValid = int.TryParse(option, out optionNumber);
                if (!isValid || optionNumber>3 || optionNumber<1)
                {
                    Console.WriteLine("Incorrect input format. try again");
                    continue;
                }

                if (optionNumber == 3) return;

                if (optionNumber == 2)
                {
                    Console.WriteLine("ADD NEW CAR:");

                    Console.Write("Number of model: ");
                    string modelStringNumber = Console.ReadLine();
                    int modelNumber;
                    var isValidModelNumber = int.TryParse(modelStringNumber, out modelNumber);
                    if (!isValidModelNumber)
                    {
                        Console.WriteLine("Incorrect input format. try again");
                        continue;
                    }

                    Console.Write("Brand: ");
                    string Brand = Console.ReadLine();

                    Console.Write("Year: ");
                    string yearString = Console.ReadLine();
                    int year;
                    var isValidYear = int.TryParse(yearString, out year);
                    if (!isValidYear)
                    {
                        Console.WriteLine("Incorrect input format. try again");
                        continue;
                    }

                    Console.Write("Price: ");
                    string PriceInStrings = Console.ReadLine();
                    decimal Price;
                    var isValidPrice = decimal.TryParse(PriceInStrings, out Price);
                    if (!isValidPrice)
                    {
                        Console.WriteLine("Incorrect input format. try again");
                        continue;
                    }

                    Cars SingleCar = new Cars(modelNumber,Brand,year,Price);
                    carCharacteristic.Add(SingleCar);
                    Console.WriteLine();
                    Console.WriteLine("Car was added");
                    continue;
                }

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|  Number of model  |  Brand  |  Year  |  Price  |");
                Console.WriteLine("--------------------------------------------------");
                for(int i = 0; i < carCharacteristic.Count; i++)
                {
                    Console.WriteLine($"|        {carCharacteristic[i].NumberModel}       |  {carCharacteristic[i].Brand}  |  {carCharacteristic[i].Year}  |  {carCharacteristic[i].Price}  |");
                }
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
