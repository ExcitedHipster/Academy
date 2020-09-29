using System;

namespace _04_foreach_tutorial02
{
    class Program
    {
        private const int MatrixLength = 5;
        private const int MatrixHeight = 5;

        static void Main(string[] args)
        {
            var matrix = new int[MatrixHeight, MatrixLength];

            int incrementIndex = 0;

            for (int height = 0; height < MatrixHeight; height++)
            {
                for (int length = MatrixLength - 1; length >= 0; length--)
                {
                    if (incrementIndex == length)
                    {
                        Console.Write("1" + "\t");
                    }
                    else
                    {
                        Console.Write("0" + "\t");
                    }
                }
                incrementIndex++;
                Console.WriteLine();
            }
        }
    }
}