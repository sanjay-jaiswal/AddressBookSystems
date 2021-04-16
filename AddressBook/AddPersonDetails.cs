using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    /// <summary>
    /// Inheriting InterfaceDetails into AddPersonDetails
    /// </summary>
    public class AddPersonDetails : InterfaceDetails
    {
        //List is used to store contacts details
        private readonly List<Contacts> list = new List<Contacts>(); 
        private Contacts person = null;

      /// <summary>
      /// Adding details like first name , pincode etc.
      /// </summary>
        public void AddDetails()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    Console.WriteLine("You entered the duplicate name...");
                }
            }

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip Code");
            int zipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter phoneNumber");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].PhoneNumber.Equals(phoneNumber))
                {
                    Console.WriteLine("You entered the duplicate phone number...");
                }
            }

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
        /// <summary>
        /// Edit method.
        /// </summary>
        /// <param name="firstName">first name.</param>
        public void Edit(string firstName)
        {
            int check = 0;
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    while (check == 0)
                    {
                        Contacts person = this.list[i];
                        Console.WriteLine(person);
                        Console.WriteLine("Enter your choice for editing: ");
                        Console.WriteLine("1.Address 2.City 3.State 4.Zip Code 5.Phone Number 6.Email ID 7.Exit");
                        string choice = Console.ReadLine();
                        int ch = Convert.ToInt32(choice);
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("enter new address");
                                string address = Console.ReadLine();
                                person.Address = address;
                                break;
                            case 2:
                                Console.WriteLine("enter new city");
                                string city = Console.ReadLine();
                                person.City = city;
                                break;
                            case 3:
                                Console.WriteLine("enter new state");
                                string state = Console.ReadLine();
                                person.State = state;
                                break;

                            case 4:
                                Console.WriteLine("enter new zipCode");
                                int zipCode = Convert.ToInt32(Console.ReadLine());
                                person.ZipCode = zipCode;
                                break;

                            case 5:
                                Console.WriteLine("enter new phoneNumber");
                                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                                person.PhoneNumber = phoneNumber;
                                break;

                            case 6:
                                Console.WriteLine("enter new Email ID");
                                string emailID = Console.ReadLine();
                                person.EmailID = emailID;
                                break;

                            case 7:
                                check = 1;
                                break;
                        }
                    }
                }
            }
        }
    }
}
