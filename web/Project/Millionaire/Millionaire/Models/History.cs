using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionaire.Models
{
    public class History
    {
        public int CorrectAnswers { get; set; }
        public DateTime StartDate { get; set; }
        public int Money { get; set; }
        public int[] moneyList = new int[] { 7000, 12000, 70000, 120000, 700000, 1000000 };
        public string ReturnGamePage { get; set; } = "Back";
        public string ReturnLostPage { get; set; } = "";
        public string ReturnWonPage { get; set; } = "";

    }
}
