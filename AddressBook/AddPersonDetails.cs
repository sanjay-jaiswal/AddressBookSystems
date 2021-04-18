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
            Console.WriteLine("Please enter your first name : ");
            string firstName = Console.ReadLine();
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    Console.WriteLine("You have entered a duplicate name.");
                }
            }

            Console.WriteLine("Please enter your last name : ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your address : ");
            string address = Console.ReadLine();

            Console.WriteLine("Please enter your city : ");
            string city = Console.ReadLine();

            Console.WriteLine("Please enter your state : ");
            string state = Console.ReadLine();

            Console.WriteLine("Please enter your Pincode : ");
            int zipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your mobile number : ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].PhoneNumber.Equals(phoneNumber))
                {
                    Console.WriteLine("You entered a duplicate phone number.");
                }
            }

            Console.WriteLine("Please enter your email id : ");
            string emailID = Console.ReadLine();

            Console.WriteLine("Your entered details are added Successfully!!!");

            this.person = new Contacts(firstName, lastName, address, city, state, zipCode, phoneNumber, emailID);
            this.list.Add(this.person);
        }
        
        /// <summary>
        /// To display all the contacts from list.
        /// </summary>
        public void Display()
        {
            foreach (Contacts entry in this.list)
            {
                Console.WriteLine(entry);
            }
        }
        
        /// <summary>
        /// This method is used to edit person's details using their first name
        /// </summary>
        /// <param name="firstName"></param>
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
                        Console.WriteLine("===>>>Please enter your choice to edit :  ");
                        Console.WriteLine(" 1.Address  2.City  3.State  4.Zip Code  5.Phone Number  6.Email ID  7.To exit");
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

        /// <summary>
        /// delete() method is used to delete records from address book using their first name.
        /// </summary>
        /// <param name="firstName"></param>
        public void Delete(string firstName)
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    this.list[i] = null;
                }
            }
            Console.WriteLine("You deleted your desired person successfully .");
        }

    }
}
