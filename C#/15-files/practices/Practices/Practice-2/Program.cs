using System;

namespace Practice_2
{
    class Program
    {
       
        public static string path;
        public static bool ind = true;
        static void Main(string[] args)
        {
            while (ind)
            {

                Console.Write(path+">");
                string Operation = Console.ReadLine();
                if(Operation!="cd")Console.WriteLine("===============================================");
                ChooseOperation(Operation);
                Console.WriteLine("===============================================");
               
            }
            

        }

        public static void ChooseOperation(string operation)
        {
            if (operation.ToLower() == "help") Operations.helpOut();
            if (operation.ToLower() == "disk") new Drive();
            if (operation.ToLower() == "dir") Operations.DirectorySearch(path);
            if (operation.ToLower() == "cd")  path = @Console.ReadLine();
            if (operation.ToLower() == "exit") { ind = false; return; }
        }
    }
}


