using System;
using System.Threading;

namespace Tutorial_2
{
    class Program
    {
        static int count = 0;
        static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[100];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Proceed);
                threads[i].Start(i);
            }
        }

        static void Proceed(object numberOfThread)
        {
            while (true)
            {
                mutex.WaitOne();
                var temp = count;

                 Console.WriteLine("Thread {0} is here reading", numberOfThread);
                 Thread.Sleep(100);

                 count=temp+1;

                 Console.WriteLine("Thread {0} is here to increment count to {1}", numberOfThread, count);
                 Thread.Sleep(100);

                mutex.ReleaseMutex();

            }
            
            
            
        }
    }
}
