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

        Dictionary<string, AddPersonDetails> dictionary = new Dictionary<string, AddPersonDetails>();

        private Contacts person = null;



        public void CreateMultipleUniqueAddressBook()
        {
            while (true)
            {
                Console.WriteLine("Please enter your Choice.......");
                Console.WriteLine("1.Add Address Book");
                Console.WriteLine("2.Use Existing Address Book");
                Console.WriteLine("3.Exit");

                String choice = Console.ReadLine();
                int choice1 = Convert.ToInt32(choice);
                switch (choice1)
                {
                    case 1:
                        Console.WriteLine("Please enter the Name of Your Address Book : ");
                        string name = Console.ReadLine();
                        if (dictionary.ContainsKey(name))
                        {
                            Console.WriteLine("Address Book Already exists!!!");
                        }
                        else
                        {
                            AddPersonDetails addressBook = new AddPersonDetails();
                            dictionary.Add(name, addressBook);
                            Console.WriteLine("Your Address Book is Created.");
                            addressBook.AddressBookMenu();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Please enter Address book name : ");
                        string addressBookName = Console.ReadLine();
                        if (dictionary.ContainsKey(addressBookName))
                        {
                            dictionary[addressBookName].AddressBookMenu();
                        }
                        else
                        {
                            Console.WriteLine("Address book does not exists!!!");
                        }
                        break;
                    case 3:
                        return;
                }
            }
        }

        /// <summary>
        /// AddressBook Menu to show multiple choice
        /// </summary>
        public void AddressBookMenu()
        {
            InterfaceDetails addressBookDetails = new AddPersonDetails();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("*************PLEASE SELECT YOUR CHOICE**************");
                Console.WriteLine("1.Add Details");
                Console.WriteLine("2.Display Details");
                Console.WriteLine("3.Edit Details");
                Console.WriteLine("4.Delete Details");
                Console.WriteLine("5.Exit");

                string choice = Console.ReadLine();
                int ch = Convert.ToInt32(choice);

                switch (ch)
                {
                    case 1:
                        addressBookDetails.AddDetails();
                        break;
                    case 2:
                        addressBookDetails.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name:");
                        string lastName = Console.ReadLine();
                        addressBookDetails.Edit(firstName,lastName);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name:");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Enter Last Name:");
                        string lastname = Console.ReadLine();
                        addressBookDetails.Delete(firstname,lastname);
                        break;
                    case 5:
                        return;
                }
            }
        }



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

            Console.WriteLine("Please enter your state : ");
            string zipCode = Console.ReadLine();

           

            Console.WriteLine("Please enter your Pincode : ");
            string phoneNumber = Console.ReadLine();

            /*

            Console.WriteLine("Please enter your mobile number : ");
            str phoneNumber = Convert.ToInt64(Console.ReadLine());
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].PhoneNumber.Equals(phoneNumber))
                {
                    Console.WriteLine("You entered a duplicate phone number.");
                }
            }


            */


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
            if (list.Count == 0)
            {
                Console.WriteLine("No Records in Address Book");
            }
        }

        /// <summary>
        /// This method is used to edit person's details using their first name
        /// </summary>
        /// <param name="firstName"></param>
        public void Edit(string firstName, string lastName)
        {
            int check = 0;
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName) && this.list[i].LastName.Equals(lastName))
                {
                    while (check == 0)
                    {
                        Contacts addressBook = this.list[i];
                        Console.WriteLine(addressBook);
                        Console.WriteLine("Enter your choice for editing: ");
                        Console.WriteLine("1.Address 2.City 3.State 4.Zip Code 5.Phone Number 6.Email ID 7.Exit");
                        string choice = Console.ReadLine();
                        int ch = Convert.ToInt32(choice);
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("enter new address");
                                string address = Console.ReadLine();
                                addressBook.Address = address;
                                break;
                            case 2:
                                Console.WriteLine("enter new city");
                                string city = Console.ReadLine();
                                addressBook.City = city;
                                break;
                            case 3:
                                Console.WriteLine("enter new state");
                                string state = Console.ReadLine();
                                addressBook.State = state;
                                break;

                            case 4:
                                Console.WriteLine("enter new zipCode");
                                string zipCode = Console.ReadLine();
                                addressBook.ZipCode = zipCode;
                                break;

                            case 5:
                                Console.WriteLine("enter new phoneNumber");
                                string mobileNumber = Console.ReadLine();
                                addressBook.MobileNumber = mobileNumber;
                                break;

                            case 6:
                                Console.WriteLine("enter new Email ID");
                                string emailID = Console.ReadLine();
                                addressBook.EmailID = emailID;
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
        public void Delete(string firstname, string lastname)
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstname) && this.list[i].LastName.Equals(lastname))
                {
                    this.list[i] = null;
                }
            }
            Console.WriteLine("Your expected entry is deleted from records!");
        }

    }
}


