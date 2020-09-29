using Millionaire.Controllers;
using Millionaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Services.Implementations
{
    public class TipsImplementation
    {

        public static Tip RemainingTips = new Tip { FiftyFifty = true, Friend = true, Audience = true };
        public static Question ImplementFiftyFifty(Question question)
        {
            int cnt = 0;
            while (cnt != 2)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, 4);
                if (!question.Answers[index].IsRight && question.Answers[index].AnswerContent != "")
                {
                    cnt++;
                    question.Answers[index].AnswerContent = "";
                }
            }
            return question;
        }

        public static void ImplementAudience(Question question)
        {
            Random rnd = new Random();
            int suggestion = rnd.Next(1, 101);
            bool isRight = suggestion <= 85;
            while (true)
            {
                int index = rnd.Next(0, 4);
                if((isRight && question.Answers[index].IsRight) || (!isRight && !question.Answers[index].IsRight))
                {
                    question.suggestion = $"Audience suggests {question.Answers[index].AnswerContent}";
                    break;
                }
            }
        }

        public static void ImplementFriend(Question question)
        {
            Random rnd = new Random();
            int suggestion1 = rnd.Next(0, 4);
            string[] suggestion = { "A", "B", "C", "D" };
            while(question.Answers[suggestion1].AnswerContent=="") suggestion1 = rnd.Next(0, 4);
            question.suggestion=$"I don't know maybe, {suggestion[suggestion1]}?";
        }

        public static void GetTip(Question question)
        {
            if (GameController.TipsIndicator.FiftyFifty)
            {
                TipsImplementation.ImplementFiftyFifty(question);
                GameController.TipsIndicator.FiftyFifty = false;
            }
            if (GameController.TipsIndicator.Friend == true)
            {
                TipsImplementation.ImplementFriend(question);
                GameController.TipsIndicator.Friend = false;
            }
            if (GameController.TipsIndicator.Audience == true)
            {
                TipsImplementation.ImplementAudience(question);
                GameController.TipsIndicator.Audience = false;
            }
        }

        
}
}
