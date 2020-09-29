using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch= new Stopwatch();
           

            long totalMemoryBefore = GC.GetTotalMemory(false);
            Console.WriteLine("Count of bytes in heap: {0}", totalMemoryBefore);
            Console.WriteLine();

            watch.Start();

            CreateArray();

            watch.Stop();

            Console.WriteLine("array was created in {0} ms",watch.ElapsedMilliseconds);
            Console.WriteLine();

            watch.Reset();


            watch.Start();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            watch.Stop();

            Console.WriteLine("collection time: {0}",watch.ElapsedTicks);
            Console.WriteLine();

            long totalMemoryAfter = GC.GetTotalMemory(false);
            Console.WriteLine("count of bytes in heap: {0}", totalMemoryAfter);
            Console.WriteLine();

            ShowGarbageCollectionState();
        }

        private static void CreateArray()
        {
            var array = new int[10000000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next();
            }

            long totalMemoryAfter = GC.GetTotalMemory(false);
            Console.WriteLine("count of bytes in heap: {0}", totalMemoryAfter);
            Console.WriteLine();
        }

        public static void Tutorial1()
        {
            int maxGen = GC.MaxGeneration;
            Console.WriteLine("Max generation: {0}", maxGen);
            Console.WriteLine();

            long totalMemoryBefore = GC.GetTotalMemory(false);
            Console.WriteLine("Count of bytes in heap: {0}", totalMemoryBefore);
            Console.WriteLine();

            var battery = new Battery("Power - 1");
            Console.WriteLine("Battery was created");
            Console.WriteLine();
            var batteryList = new List<long>();
            for (int i = 0; i < 1000; i++)
            {
                batteryList.Add(1);
            }



            int batteryGeneration = GC.GetGeneration(battery);
            Console.WriteLine("Battery Generation: {0}", batteryGeneration);
            Console.WriteLine();

            long totalMemoryAfter = GC.GetTotalMemory(false);
            Console.WriteLine("count of bytes in heap: {0}", totalMemoryAfter);

        }

        private static void ShowGarbageCollectionState()
        {
            Console.WriteLine("Generation 0 was checked {0} times",GC.CollectionCount(0));
            Console.WriteLine("Generation 1 was checked {0} times", GC.CollectionCount(1));
            Console.WriteLine("Generation 2 was checked {0} times", GC.CollectionCount(2));
        }
    }
}
