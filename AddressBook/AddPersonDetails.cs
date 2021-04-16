using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddPersonDetails : InterfaceDetails
    {
        private readonly List<Contacts> list = new List<Contacts>();
        private Contacts person = null;

        /// <summary>
        /// Adding person in Address Book
        /// </summary>
        public void AddDetails()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip Code");
            string zipCode = Console.ReadLine();

            Console.WriteLine("Enter phoneNumber");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter EmailID");
            string emailID = Console.ReadLine();

            Console.WriteLine("Your details are Added Successfully...");

            this.person = new Contacts(firstName, lastName, address, city, state, zipCode, phoneNumber, emailID);
            this.list.Add(this.person);
        }

        /// <summary>
        /// Display method.
        /// </summary>
        public void Display()
        {
            foreach (Contacts entry in this.list)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
