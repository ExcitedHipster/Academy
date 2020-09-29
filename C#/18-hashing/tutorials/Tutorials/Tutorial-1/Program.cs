using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write string to hash: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            var hash = GetSha1(input);
            Console.WriteLine("Your hash: {0}",hash);
            Console.WriteLine();

            var salt = GenerateSalt();
            Console.WriteLine("Generate Salt: {0}",salt);
            Console.WriteLine();

            var saltedHash = GetSha1(hash + salt);
            Console.WriteLine("Salted hash: {0}",saltedHash);
            Console.WriteLine();

        }

        private static string GenerateSalt()
        {
            string alphabet = "ABCDEFGHIjKLMNOPQRSTUVWXYZ".ToLower();
            var chars = alphabet.ToCharArray();

            var random = new Random();

            var saltBuilder = new StringBuilder();

            chars.ToList().ForEach(c =>
                 saltBuilder = random.Next(0, 10) % 2 == 0
                       ? saltBuilder.Append(c)
                       : saltBuilder);
            return saltBuilder.ToString();
        }

        public static string GetSha1(string input)
        {
            using var sha1 = new SHA1Managed();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input)).ToList();

            var sbuilder = new StringBuilder();

            hash.ForEach(x=>sbuilder.Append(x.ToString("x2")));

            return sbuilder.ToString();
        }
    }
}
