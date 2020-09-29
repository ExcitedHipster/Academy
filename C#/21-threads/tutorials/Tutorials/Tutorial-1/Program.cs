using System;
using System.Threading;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteDot);

            Console.WriteLine("Thread is alive: {0}",thread.IsAlive);
            Console.WriteLine("Thread is background: {0}", thread.IsBackground);

            thread.Start();

            Console.WriteLine();
            Console.WriteLine("Thread is alive: {0}", thread.IsAlive);
            Console.WriteLine("Thread is background: {0}", thread.IsBackground);
            Console.WriteLine();

            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("-");
                    Thread.Sleep(10);

                    //if (i>500)
                    //{
                    //    thread.Join();
                    //}
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void WriteDot()
        {
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(".");
                    Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
