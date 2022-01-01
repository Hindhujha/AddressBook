using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ADDRESS BOOK PROBLEMS");
            while (true)
            {             
                Console.WriteLine("-----------------");
                Console.WriteLine("1.CREATING ADDRESS BOOK");
                Console.WriteLine("2.ADDING NEW CONTACT IN ADDRESS BOOK");
                Console.WriteLine("3.EDITING A CONTACT");
                Console.WriteLine("ENTER YOUR OPTION");

                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Contacts create = new Contacts();
                        create.CreateContact();

                        break;
                    case 2:
                        Contacts adding = new Contacts();
                        adding.AddingContact();
                        break;
                    case 3:
                        Contacts editing = new Contacts();
                        editing.EditContact();
                        break;
                    default:
                        Console.WriteLine("ENTER A CORRECT OPTION");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
