using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Game
{
    class Tips : Program
    {
        public static char[] Ar = new char[101];
        public static List<char> audienceList = new List<char>(Ar);
        public bool ifFiftyFifty { get; set; }
        public bool ifPhoneAFriend { get; set; }
        public bool ifAskTheAudience { get; set; }
        public Tips()
        {
            ifFiftyFifty = true;
            ifPhoneAFriend = true;
            ifAskTheAudience = true;
        }
        public static void TipsOutput()
        {
            if (tip.ifFiftyFifty == true) Console.WriteLine("1:   50:50");
            if (tip.ifPhoneAFriend == true) Console.WriteLine("2:   Phone-A-friend");
            if (tip.ifAskTheAudience == true) Console.WriteLine("3:   Ask the audience");
        }
        public static void tips(string option, int questionNumber)
        {
            if (option == "1" && tip.ifFiftyFifty == true)
            {
                tip.FiftyFifty(correctAnswer(questionNumber), fileData, questionNumber);
                return;
            }
            if (option == "2" && tip.ifPhoneAFriend == true)
            {
                tip.PhoneAFriend();
                return;
            }
            if (option == "3" && tip.ifAskTheAudience == true)
            {
                tip.AskTheAudience(correctAnswer(questionNumber));
                return;
            }
            Console.WriteLine("Invalid option try again!");
            Console.WriteLine();
        }
        public void Makelist(char answer)
        {
            for (int k = 0; k < 100; k++)
            {
                if (k < 85) audienceList[k] = answer;
                else audienceList[k] = '1';
            }
        }
        public void AskTheAudience(char answer)
        {
            Makelist(answer);
            Random rnd = new Random();
            int suggestion1 = rnd.Next(0, 100);
            char[] suggestion = { 'A', 'B', 'C', 'D' };
            if (audienceList[suggestion1] == '1')
            {
                while (true)
                {
                    int wrongSuggestion = rnd.Next(0, 4);
                    if (answer != suggestion[wrongSuggestion])
                    {
                        Console.WriteLine($"Audience suggests {suggestion[wrongSuggestion]}");
                        return;
                    }
                }
            }
            Console.WriteLine($"Audience suggests {answer}");
            ifAskTheAudience = false;
        }
        public void PhoneAFriend()
        {
            Random rnd = new Random();
            int suggestion1 = rnd.Next(0, 4);
            string[] suggestion = { "A", "B", "C", "D" };
            Console.WriteLine($"I don't know maybe, {suggestion[suggestion1]}?");
            ifPhoneAFriend = false;
        }
        public void FiftyFifty(char answer, List<string> answers, int questionumber)
        {
            Random rnd = new Random();
            int suggestion1 = rnd.Next(0, 3);
            char[] suggestion = { 'A', 'B', 'C', 'D' };
            suggestion = suggestion.Where(val => val != answer).ToArray();
            char firstTip = answer, SecondTip = suggestion[suggestion1];
            int random = rnd.Next(3, 50);
            for (int i = 1; i <= random; i++)
            {
                (firstTip, SecondTip) = (SecondTip, firstTip);
            }
            Console.WriteLine($"{firstTip}: {Decrypt(answers[(questionumber - 1) * 5 + firstTip - 'A' + 1], Program.key)}" + "\n" + $"{SecondTip}: {Decrypt(answers[(questionumber - 1) * 5 + SecondTip - 'A' + 1], Program.key)}" + "\n");
            ifFiftyFifty = false;
        }
    }
}