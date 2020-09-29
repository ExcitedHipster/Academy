using System;
using System.IO;

namespace tutorials
{
    class Program
    {
        private const string FilePath = @"d:\data.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter data: ");
            string data = Console.ReadLine();
            SaveData(data);

            Console.WriteLine("Data was saved");
            Console.WriteLine();
            Console.WriteLine();

            string result = ReadData();
            Console.WriteLine(result);
        }
        public static void SaveData(string data)
        {
            data += "\n";
            using var fstream = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
            var bytes = System.Text.Encoding.Default.GetBytes(data);
            fstream.Write(bytes, 0, bytes.Length);

        }

        public static string ReadData()
        {


            using var fStream = File.OpenRead(FilePath);
            var bytes = new byte[fStream.Length];
            fStream.Read(bytes,0,bytes.Length);

            string data = System.Text.Encoding.Default.GetString(bytes);
            return data;
        }
    }

}
