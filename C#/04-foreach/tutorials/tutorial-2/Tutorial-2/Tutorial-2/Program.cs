using System;

namespace Tutorial_2
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
                for (int length = 0; length < MatrixLength; length++)
                {
                    if (incrementIndex == length)
                    {
                        matrix[height, length]++;
                    }
                    Console.Write(matrix[height,length]+"\t");
                }
                incrementIndex++;
                Console.WriteLine();
            }
        }
    }
}
