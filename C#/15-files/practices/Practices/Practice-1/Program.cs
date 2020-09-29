using System;

namespace Practice_1
{
    class Program
    {
        public static bool ind = true;
        static void Main(string[] args)
        {
            while (ind)
            {
                Console.Write(">");
                string Operation = Console.ReadLine();
                Console.WriteLine("===============================================");
                ChooseOperation(Operation);
                Console.WriteLine("===============================================");
            }
        }

        public static void ChooseOperation(string operation)
        {       
            if (operation.ToLower() == "help") Operations.helpOut();
            if (operation.ToLower() == "disk") new Drive();
            if (operation.ToLower() == "exit") { ind = false;return; }
        }
    }
}
