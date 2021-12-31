using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public  class Contacts
    {
      //Creating A Contact by get the input from USER
        public  void CreateContact()
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
            person.State =Console.ReadLine();

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
        public  void Display(Person person)
        {
            Console.WriteLine("PERSON DETAILS ARE:");
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Address : " + person);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("Zip Code: " + person.Zip);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email Id : " + person.email);
            Console.WriteLine("-------------------------------------------");
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
