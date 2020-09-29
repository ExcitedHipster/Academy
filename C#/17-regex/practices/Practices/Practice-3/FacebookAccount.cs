using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    public class FacebookAccount
    {
        public static string FullName { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string UserName { get; set; }
        public static string PhoneNumber { get; set; }
        public static string Password { get; set; }
        public static DateTime? DateOfBirth { get; set; }

        public static void account()
        {

            do
            {
                Console.Write("Your first name*:");
                FirstName = Console.ReadLine();
                FirstName = FacebookAccountValidator.Validate(FirstName, 0);
            } while (FirstName == default);


            do
            {

                Console.Write("Your last name*:");
                LastName = Console.ReadLine();
                LastName = FacebookAccountValidator.Validate(LastName, 1);
            } while (LastName == default);

            do
            {

                Console.Write("User name:");
                UserName = Console.ReadLine();
                UserName = FacebookAccountValidator.Validate(UserName, 2);
            } while (UserName == default);

            string date = default;
            while(true){
                Console.WriteLine("Date of birth: ");
                date = Console.ReadLine();
                try
                {
                    DateOfBirth = DateTime.Parse(date);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Invalid date format try again");
                    continue;
                }
                break;
            }

            do
            {

                Console.Write("Phone number*:");
                PhoneNumber = Console.ReadLine();
                PhoneNumber = FacebookAccountValidator.Validate(PhoneNumber, 3);
            } while (PhoneNumber == default);

            do
            {
                Console.Write("password*:");
                Password = Console.ReadLine();
                Password = FacebookAccountValidator.Validate(Password, 4);
            } while (Password == default);

            Console.WriteLine("Registation is completed.");
            Console.WriteLine();
            Console.WriteLine($"| { FirstName} | { LastName} | { UserName} | { PhoneNumber} | { Password} | { date} | ");
        }

    }
}
