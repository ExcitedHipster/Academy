using System;
using System.Text;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random firstRand=new Random(), secondRand=new Random(), thirdRand=new Random();


            generateSmile(firstRand, 0, 114);
            generateSmile(secondRand, 115, 197);
            generateSmile(thirdRand, 198, 945);

        }

        public static void generateSmile(Random x,int min,int max)
        {
            int intValue= x.Next(min,max);
            byte[] intBytes = BitConverter.GetBytes(intValue);
            Array.Reverse(intBytes);
            byte[] emoji = intBytes;

            string Unicode = Encoding.Unicode.GetString(emoji);
            Console.WriteLine(Unicode);
        }
    }
}
