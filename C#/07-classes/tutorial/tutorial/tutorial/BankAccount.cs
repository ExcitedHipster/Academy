using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial
{
    public class BankAccount
    {
        private List<Transaction> transactions = new List<Transaction>();
        public string number { get; set; }
        public string owner { get; set; }
        public decimal balance { get; private set; }
        public void MakeDeposit(decimal amount, string note = default)
        {
            var newTransaction = new Transaction(amount, note);
            transactions.Add(newTransaction);
            this.balance += amount;
        }
        public void PrintTransactionHistory()
        {
            transactions.ForEach(x => Console.WriteLine($"Amount: {x.amount}\nDate: {x.date}\nNote: {x.note}\n"));
        }
        public BankAccount(string number)
        {
            this.number = number;
        }
        public BankAccount(string number, string owner) : this(number)
        {
            this.owner = owner;
        }
        public BankAccount(string number, string owner, decimal balance) : this(number, owner)
        {
            this.balance = balance;
        }
    }
}
