using System;
using System.Threading.Tasks;

namespace Tutorial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int breakeIndex = 3;
            var random =new Random();
            var locker = new object();

            Parallel.For(1, 20, (i, state) =>
              {
                  Console.WriteLine($"Beginning iteration {i}");

                  lock (locker)
                  {
                      var delay = random.Next(1, 1000);
                      Task.Delay(delay).GetAwaiter().GetResult();
                  }

                  if (i == breakeIndex)
                  {
                      Console.WriteLine("Breaking iteration {i}");
                      state.Break();
                  }

                  Console.WriteLine($"Completed iteration {i}");
              });
        }
    }
}
