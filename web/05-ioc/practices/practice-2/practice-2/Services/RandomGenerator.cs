using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice_2.Services
{
    public class RandomGenerator : IGenerator
    {
        public int GenerateNegativeIntegerNumber()
        {
            var number = GeneratePositiveIntegerNumber();
            return -number;
        }

        public int GeneratePositiveIntegerNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next();
            return number;
        }

        public string GenerateString(int length)
        {
            Random ran = new Random();

            string b = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*~";
 
            string random = "";

            for (int i = 0; i < length; i++)          
            {  
                    int a = ran.Next(b.Length);
                    random += b[a];
              
            }

            return random;
        }
    }
}
