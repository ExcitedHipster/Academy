using System;

namespace tutorial
{
    class Program
    {
        
            static void Main(string[] args)
            {
                var myBankAccount = new BankAccount("GE83BG054642GEL", "Grigoli Tsirekidze", 3000);
                myBankAccount.MakeDeposit(3, "No notes");
                myBankAccount.MakeDeposit(2, "Sorry, That's all I have now...");
                myBankAccount.MakeDeposit(45684, "Money");
                myBankAccount.PrintTransactionHistory();
            }
     
    }
}
