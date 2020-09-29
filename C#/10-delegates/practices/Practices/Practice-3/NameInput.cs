using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    public class NameInput:Operations
    {
        public void nameInput()
        {
            Console.Write("First Name: ");
            FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            LastName = Console.ReadLine();
        }
    }
}
