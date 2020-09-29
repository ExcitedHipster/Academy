using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
namespace Game
{
    class Program
    {
        public static string FilePath = @"../../../../questions.txt", historyPath = @"../../../../game-history.txt", ind = default, key = "b14ca5898a4e4133bbce2ea2315a1916";
        public static List<string> fileData = new List<string>(), nonUpdated = new List<string>(), answerList = new List<string>();
        public static int cost = default, ifChoice0 = default;
        public static Tips tip = new Tips();
        static void Main(string[] args)
        {
            File.Delete(historyPath);
            Console.WriteLine("Welcome to game `Who Wants to be a Millionaire ?`");
            SaveHistoryData("Start date of the game: " + DateTime.Now.ToString());
            optionInput();
            if (ind == "Ending program")
            {
                Console.WriteLine(ind);
                return;
            }
            ReadFromFile();
            question(1, 7000);
            Answer(1);
            if (ind == "Ending program")
            {
                Console.WriteLine(ind);
                HistoryData(1, 0, 0);
                return;
            }
            Console.Clear();
            question(2, 12000);
            cost = 7000;
            Answer(2);
            if (ind == "Ending program")
            {
                Console.WriteLine(ind);
                HistoryData(2, 1, cost);
                return;
            }
            Console.Clear();
            question(3, 70000);
            cost = 12000;
            Answer(3);
            if (ind == "Ending program")
            {
                Console.WriteLine(ind);
                HistoryData(3, 2, cost);
                return;
            }
            Console.Clear();
            question(4, 120000);
            cost = 70000;
            Answer(4);
            if (ind == "Ending program")
            {
                Console.WriteLine(ind);
                HistoryData(4, 3, cost);
                return;
            }
            Console.Clear();
            question(5, 700000);
            cost = 120000;
            Answer(5);
            if (ind == "Ending program")
            {
                Console.WriteLine(ind);
                HistoryData(5, 4, cost);
                return;
            }
            Console.Clear();
            question(6, 1000000);
            cost = 700000;
            Answer(6);
            if (ind == "Ending program")
            {
                Console.WriteLine(ind);
                HistoryData(6, 5, cost);
                return;
            }
            SaveHistoryData("Total amount of questions: 6");
            SaveHistoryData("Total amount of right answers: 6");
            SaveHistoryData("Total amount of wrong answers: 0");
            SaveHistoryData("The amount of money that the player took: 1,000,000");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Congrats!!! You won $1,000,000");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void question(int index, int cost)
        {
            Console.WriteLine($"Question {index} for ${cost}:");
            Console.WriteLine();
            randomize((index - 1) * 5 + 1);
            Output((index - 1) * 5, index);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
        }
        public static void optionInput()
        {
            Console.Write("Are you ready yo start? (y/n): ");
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
                    Console.Write("(y/n)");
                    option = Console.ReadLine();
                    if (option == "n")
                    {
                        ind = "Ending program";
                        return;
                    }
                }
            }
        }
        public static void ReadFromFile()
        {
            string fromFile = ReadData();
            fileData = fromFile.Split("\n").ToList();
            nonUpdated = fromFile.Split("\n").ToList();
        }
        public static string ReadData()
        {
            using var fStream = File.OpenRead(FilePath);
            var bytes = new byte[fStream.Length];
            fStream.Read(bytes, 0, bytes.Length);
            string data = System.Text.Encoding.Default.GetString(bytes);
            return data;
        }
        public static string Decrypt(string cipherText, string key)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
        public static void randomize(int start)
        {
            var end = start + 4;
            for (int k = 1; k <= 1000; k++)
            {
                Random rnd = new Random();
                int first = rnd.Next(start, end), second = rnd.Next(start, end);
                (fileData[first], fileData[second]) = (fileData[second], fileData[first]);
            }
        }
        public static void Output(int start, int questionNumber)
        {
            Console.WriteLine(Decrypt(fileData[start], key));
            Console.WriteLine("A: " + Decrypt(fileData[start + 1], key));
            Console.WriteLine("B: " + Decrypt(fileData[start + 2], key));
            Console.WriteLine("C: " + Decrypt(fileData[start + 3], key));
            Console.WriteLine("D: " + Decrypt(fileData[start + 4], key));
            Console.WriteLine();
            Console.WriteLine("--------------------------Other options--------------------------");
            Console.WriteLine();
            if (questionNumber > 2) Console.WriteLine("0: Take money");
            Console.WriteLine();
            Tips.TipsOutput();
        }
        public static void Answer(int questionNumber)
        {
            while (true)
            {
                int ind1 = default;
                Console.Write("Your choice: ");
                string choice = Console.ReadLine(), answer = default;
                int index = (questionNumber - 1) * 5 + 1;
                if (choice == "0")
                {
                    Console.WriteLine("\n" + "Congrats! you won $" + cost + "\n" + "-----------------------------------------------------------------");
                    ind = "Ending program";
                    ifChoice0 = 1;
                    return;
                }
                if (choice == "1" || choice == "2" || choice == "3")
                {
                    Tips.tips(choice, questionNumber);
                    continue;
                }
                if (choice.ToUpper() == "A") answer = fileData[index];
                else if (choice.ToUpper() == "B") answer = fileData[index + 1];
                else if (choice.ToUpper() == "C") answer = fileData[index + 2];
                else if (choice.ToUpper() == "D") answer = fileData[index + 3];
                else
                {
                    Console.WriteLine("Invalid input try again" + "\n");
                    ind1 = 1;
                }
                if (ind1 == 0)
                    if (answer == nonUpdated[index])
                    {
                        Console.WriteLine("You are gorgeous" + "\n" + "\n" + "-----------------------------------------------------------------");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately, this is the wrong answer... Game over." + "\n" + "-----------------------------------------------------------------");
                        ind = "Ending program";
                        return;
                    }
            }
        }
        public static char correctAnswer(int questionNumber)
        {
            char answer = 'A';
            int index = (questionNumber - 1) * 5 + 1;
            if (fileData[index + 1] == nonUpdated[index]) answer = 'B';
            if (fileData[index + 2] == nonUpdated[index]) answer = 'C';
            if (fileData[index + 3] == nonUpdated[index]) answer = 'D';
            return answer;
        }
        public static void HistoryData(int questions, int rightAnswers, int Money)
        {
            SaveHistoryData($"Total amount of questions: {questions}");
            SaveHistoryData($"Total amount of right answers: {rightAnswers}");
            if (ifChoice0 == 1)
            {
                SaveHistoryData($"Total amount of wrong answers: {0}");
                SaveHistoryData($"The amount of money that the player took: {Money}");
            }
            else
            {
                SaveHistoryData($"Total amount of wrong answers: {1}");
                SaveHistoryData($"The amount of money that the player took: {0}");
            }
        }
        public static void SaveHistoryData(string data)
        {
            data += "\n";
            using var fstream = new FileStream(historyPath, FileMode.Append, FileAccess.Write);
            var bytes = System.Text.Encoding.Default.GetBytes(data);
            fstream.Write(bytes, 0, bytes.Length);
        }
    }
}