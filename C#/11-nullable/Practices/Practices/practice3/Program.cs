using Practice_3;
using System;

namespace Practice3
{
    class Program
    {
        public static Myform userInfo = new Myform();
        static void Main(string[] args)
        {
            UserNameInput();
            userInfo.AreProposalEmailsNeeded = true;
            variousInput();
            output();
        }

        public static void UserNameInput()
        {
            Console.Write("Input your name: ");
            string name = Console.ReadLine();
            userInfo.Name = name;
            if (name == "") { Console.WriteLine("Name is required! Let's try one more time"); Console.WriteLine(); Console.WriteLine(); UserNameInput(); }

        }

        public static void variousInput()
        {
            Console.Write("Input your date of birth: ");
            string date = Console.ReadLine();
            if (date != "") userInfo.DateOfBirth = Convert.ToDateTime(date);
            else userInfo.DateOfBirth = null;

            Console.Write("How many childrens do you have? ");
            string childNumber = Console.ReadLine();
            if (childNumber != "") userInfo.CountOfChildrens = Convert.ToInt32(childNumber);
            else userInfo.CountOfChildrens = null;


            Console.Write("How many pets do you have? ");
            string petsNumber = Console.ReadLine();
            if (petsNumber != "") userInfo.CountOfPets = Convert.ToInt32(petsNumber);
            else userInfo.CountOfPets = null;

            Console.Write("Do you want to get proposal emails? (y/n) ");
            string proposalAsk = Console.ReadLine();
            if (proposalAsk != "") userInfo.AreProposalEmailsNeeded = Convert.ToBoolean(proposalAsk);
        }

        public static void output()
        {
            Console.WriteLine("Form is completed.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("|  " + userInfo.Name + "  |  " + userInfo.DateOfBirth + "  |  " + userInfo.CountOfChildrens + "  |  " + userInfo.CountOfPets + "  |  " + userInfo.AreProposalEmailsNeeded);
        }

    }
}
