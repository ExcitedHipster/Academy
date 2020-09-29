using System;

namespace tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            cat.MakeVoice();
            cat.PawCount();

            

            Console.WriteLine();

            var snake = new Snake();
            snake.MakeVoice();
            snake.PawCount();
        }
    }
}
