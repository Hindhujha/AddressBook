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
                Console.WriteLine("4.REMOVE A CONTACT IN ADDRESS BOOK");
                Console.WriteLine("5.MULTIPLE CONTACTS IN ADDRESS BOOK");
                Console.WriteLine("6.MULTIPLE  ADDRESS BOOKS");
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
                    case 4:
                        Contacts remove = new Contacts();
                        remove.RemoveContact();
                        break;
                    case 5:
                        Contacts multiple_contacts = new Contacts();
                        multiple_contacts.Multiple_Contacts();                   
                        break;
                    case 6:
                        Contacts multiple_addressbook = new Contacts();
                        multiple_addressbook.Multiple_Address();
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
