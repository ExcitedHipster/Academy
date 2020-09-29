using System;
using System.IO;
//using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
namespace Management
{
    class Program
    {
        public static string FilePath = @"../../../../questions.txt", ind = default, key = "b14ca5898a4e4133bbce2ea2315a1916";
        static void Main(string[] args)
        {
            File.Delete(FilePath);
            Console.Write("Hello. Let's start entering questions? (y/n): ");
            optionInput();
            if (ind == "Ending program")
            {
                Console.WriteLine(ind);
                return;
            }
            Input("$7,000");
            Input("$12,000");
            Input("$70,000");
            Input("$120,000");
            Input("$700,000");
            Input("$1000,000");
        }
        public static void optionInput()
        {
            string option = Console.ReadLine();
            if (option == "n")
            {
                ind = "Ending program";
                return;
            }
            if (option != "y")
            {
                Console.Write("Invalid input try again");
                while (option != "n" && option != "y")
                {
                    Console.WriteLine("(y/n)");
                    option = Console.ReadLine();
                    if (option == "n")
                    {
                        ind = "Ending program";
                        return;
                    }
                }
            }
        }
        public static void OverrideFile()
        {
            try
            {
                File.Delete(FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Input(string question)
        {
            Console.Write($"Enter question for {question}: ");
            string questionInput = Console.ReadLine();
            questionInput = InputCheck(questionInput);
            Console.WriteLine();
            Console.Write($"Enter correct answer: ");
            string answerInput = Console.ReadLine();
            answerInput = InputCheck(answerInput);
            Console.WriteLine();
            Console.Write($"Enter first wrong answer: ");
            string firstWrongInput = Console.ReadLine();
            firstWrongInput = InputCheck(firstWrongInput);
            Console.WriteLine();
            Console.Write($"Enter second wrong answer: ");
            string secondWrongInput = Console.ReadLine();
            secondWrongInput = InputCheck(secondWrongInput);
            Console.WriteLine();
            Console.Write($"Enter third wrong answer: ");
            string thirdWrongInput = Console.ReadLine();
            thirdWrongInput = InputCheck(thirdWrongInput);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();
            Encrypt(questionInput, key);
            Encrypt(answerInput, key);
            Encrypt(firstWrongInput, key);
            Encrypt(secondWrongInput, key);
            Encrypt(thirdWrongInput, key);
        }
        public static string InputCheck(string input)
        {
            while (input == "")
            {
                Console.Write("Invalid input Try again: ");
                input = Console.ReadLine();
            }
            return input;
        }
        public static void Encrypt(string plainText, string key)
        {
            byte[] iv = new byte[16];
            byte[] array;
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }
                        array = memoryStream.ToArray();
                    }
                }
            }
            SaveData(Convert.ToBase64String(array));
        }
        public static void SaveData(string data)
        {
            data += "\n";
            using var fstream = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
            var bytes = System.Text.Encoding.Default.GetBytes(data);
            fstream.Write(bytes, 0, bytes.Length);
        }
    }
}
