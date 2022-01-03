using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contacts:Person
    {
  


        //Creating A Contact by get the input from USER
        public void CreateContact()
        {

            Person person = new Person();

            Console.WriteLine("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            person.Address = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            person.City = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            person.State = Console.ReadLine();

            Console.WriteLine("Enter Zip Code: ");
            person.Zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number: ");
            person.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Email Id: ");
            person.email = Console.ReadLine();

            Console.WriteLine("-------------------------------------------");

            Contacts show = new Contacts();

            show.Display(person);


        }
        //Display the contacts
        public void Display(Person person)
        {
            Console.WriteLine("PERSON DETAILS ARE:");
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Address : " + person.Address);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("Zip Code: " + person.Zip);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email Id : " + person.email);
            Console.WriteLine("-------------------------------------------");
        }



        //ADDING NEW CONTACT

        public void AddingContact()
        {
            Person person = new Person();

            person.FirstName = "REENA";
            person.LastName = "THOMAS";
            person.Address = "SK NAGAR";
            person.City = "SALEM";
            person.State = "TAMILNADU";
            person.Zip = 636402;
            person.PhoneNumber = 9992345613;
            person.email = "reena@gmail.com";
            Console.WriteLine("NEW CONTACT ADDED");
            Contacts show = new Contacts();
            show.Display(person);
        }

        //EDIT CONTACT
        public void EditContact()
        {


            Console.WriteLine("CONTACTS IN ADDRESS BOOK ARE :");
            Contacts show = new Contacts();
            show.AddressBook();
      
            foreach (var person in People)
            {
                show.Display(person);
            }
            Console.WriteLine("ENTER A PERSONS FIRST NAME TO EDIT THE DETAILS");
            string name = Console.ReadLine();
            Person person1 = new Person();
            if (name == "REENA")
            {
                Console.WriteLine("ENTER A DETAIL TO EDIT:1.City 2.State 3.Zip");
                int select = Convert.ToInt32(Console.ReadLine());
                
                switch (select)
                {
                          
                    case 1:
                      
                        Console.WriteLine("ENTER A CITY NAME");
                        string city = Console.ReadLine();
                        person1.City = city;
                       
                        break;
                    case 2:
                   
                        Console.WriteLine("ENTER A STATE NAME");
                        string state = Console.ReadLine();
                        person1. State = state;
                        break;
                    case 3:
                        Console.WriteLine("ENTER A STATE NAME");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        person1.Zip = zip;
                        break;
                    default:
                        Console.WriteLine("ENTER CORRECT OPTION");
                        break;

                }
                Console.WriteLine("AFTER EDITING CONTACTS IN ADDRESS BOOK");
                foreach (var person in People)
                {
                    Contacts book = new Contacts();
                    book.AddressBook();
                    show.Display(person);
                }
            }
            else if (name == "SITA")
            {
                Console.WriteLine("ENTER A DETAIL TO EDIT:1.City 2.State 3.Zip");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.WriteLine("ENTER A CITY NAME");
                        string city = Console.ReadLine();
                        person1.City = city;
                        break;
                    case 2:
                        Console.WriteLine("ENTER A STATE NAME");
                        string state = Console.ReadLine();
                        person1.State = state;
                        break;
                    case 3:
                        Console.WriteLine("ENTER A STATE NAME");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        person1.Zip = zip;
                        break;
                    default:
                        Console.WriteLine("ENTER CORRECT OPTION");
                        break;
                }
                Console.WriteLine("AFTER EDITING CONTACTS IN ADDRESS BOOK");
                foreach (var person in People)
                {
                    show.Display(person);
                }
            }
        }

        //CONTACTS IN ADDRESS BOOK 
        public static List<Person> People = new List<Person>();

        public void Add(Person person)
        {
            People.Add(person);
        }

        public void AddressBook()
        {
            Contacts create = new Contacts();
            create.Add(new Person()
            {
                FirstName = "REENA",
                LastName = "THOMAS",
                Address = "SK NAGAR",
                City = "SALEM",
                State = "TAMILNADU",
                Zip = 636402,
                PhoneNumber = 9992345613,
                email = "reena@gmail.com"

            });
            create.Add(new Person()
            {
                FirstName = "SITA",
                LastName = "DANIEL",
                Address = "PO NAGAR",
                City = "BANGALORE",
                State = "KARNATAKA",
                Zip = 636700,
                PhoneNumber = 9992345983,
                email = "sitadanie@gmail.com"

            });
            create.Add(new Person()
            {
                FirstName = "RAM",
                LastName = "KUMAR",
                Address = "AK NAGAR",
                City = "CHENNAI",
                State = "TAMILNADU",
                Zip = 632007,
                PhoneNumber = 9992345603,
                email = "ram1234@gmail.com"
            });
        }

    }

    //Declaring datatype for Person
    public class Person
    {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }

            public int Zip { get; set; }
            public long PhoneNumber { get; set; }
            public string email { get; set; }
   
    } 
}


