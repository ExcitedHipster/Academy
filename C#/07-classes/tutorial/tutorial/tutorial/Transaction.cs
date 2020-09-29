using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial
{
    class Transaction
    {
        public decimal amount { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        public string note { get; set; }
        public Transaction(decimal amount, string note = default)
        {
            this.amount = amount;
            this.note = note;
        }
    }
}
