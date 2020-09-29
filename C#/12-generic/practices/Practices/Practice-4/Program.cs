using System;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
                var storage = new Storage<int>();
                var stringStorage = new Storage<string>("my test");
                var dateStorage = new Storage<DateTime>(DateTime.Now);
            try
            {
                Console.WriteLine(storage);
                Console.WriteLine(stringStorage);
                Console.WriteLine(dateStorage);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error");
                Console.WriteLine("please Input valid data");
            }

        }
    }
}
