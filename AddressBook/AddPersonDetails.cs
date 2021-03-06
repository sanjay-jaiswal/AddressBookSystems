using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBook
{
    /// <summary>
    /// Inheriting InterfaceDetails into AddPersonDetails
    /// </summary>
    public class AddPersonDetails : InterfaceDetails
    {
        //List is used to store contacts details
        public readonly List<Contacts> list = new List<Contacts>();

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
                        Console.WriteLine("Please Enter The Name Of Your Address Book : ");
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
                            addressBook.Menu();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Please enter Address book name : ");
                        string addressBookName = Console.ReadLine();
                        if (dictionary.ContainsKey(addressBookName))
                        {
                            dictionary[addressBookName].Menu();
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
        public void Menu()
        {
            InterfaceDetails addressBookDetails = new AddPersonDetails();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("*************PLEASE SELECT YOUR CHOICE**************");
                Console.WriteLine("1. Add Details");
                Console.WriteLine("2. Display Details");
                Console.WriteLine("3. Edit Details");
                Console.WriteLine("4. Delete Details");
                Console.WriteLine("5. Search Person In The State or City");
                Console.WriteLine("6. View Person By State or City");
                Console.WriteLine("7. Ability To Count Person By State or City");
                Console.WriteLine("8. Sort Details");
                Console.WriteLine("9. Write Into File");
                Console.WriteLine("10. Read From File");
                Console.WriteLine("11. Exit");

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
                        Console.WriteLine("Please Enter Your First Name : ");
                        string firstName = Console.ReadLine();
                        addressBookDetails.Edit(firstName);
                        break;
                    case 4:
                        Console.WriteLine("Please Enter Your First Name : ");
                        string firstname = Console.ReadLine();
                        addressBookDetails.Delete(firstname);
                        break;
                    case 5:
                        addressBookDetails.SearchPersonInStateOrCity();
                        break;
                    case 6:
                        addressBookDetails.ViewPersonsByStateOrCity();
                        break;
                    case 7:
                        addressBookDetails.PersonsCountByStateOrCity();
                        return;
                    case 8:
                        addressBookDetails.SortByName();
                        break;
                    case 9:
                        addressBookDetails.WriteIntoFileUsingFileIO();
                        break;
                    case 10:
                        addressBookDetails.ReadFromFileUsingFileIO();
                        break;
                    case 11:
                        return;
                }
            }
        }



        /// <summary>
        /// Adding details like first name,last name,address , pincode etc.
        /// </summary>
        public void AddDetails()
        {
            Console.WriteLine("Please enter your first name : ");
            string firstName = Console.ReadLine();
            if (!Regex.Match(firstName, "^[A-Z][a-z]{2,}$").Success)
                Console.WriteLine("Please enter first letter in Capital!!");
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    Console.WriteLine("You have entered a duplicate name!!");
                }
            }

            Console.WriteLine("Please enter your last name : ");
            string lastName = Console.ReadLine();
            if (!Regex.Match(lastName, "^[A-Z][a-z]{2,}$").Success)
                Console.WriteLine("Please enter first letter in Capital!!");

            //Check for duplicate name
            foreach (Contacts addressBook in list.FindAll(name => name.FirstName.Equals(firstName) && name.LastName.Equals(lastName)))
            {
                Console.WriteLine("You have entered a duplicate name!!");
                return;
            }

            Console.WriteLine("Please enter your address : ");
            string address = Console.ReadLine();

            Console.WriteLine("Please enter your city : ");
            string city = Console.ReadLine();

            Console.WriteLine("Please enter your state : ");
            string state = Console.ReadLine();

            Console.WriteLine("Please enter your Pin Code : ");
            int zipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your Mobile number : ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Please enter your email id : ");
            string emailID = Console.ReadLine();
            if (!Regex.Match(emailID, "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+[.]+([a-zA-Z]{2,4})+[.]*([a-zA-Z]{2})*$").Success)
                Console.WriteLine("You have entered invalid email id.\n");

            Console.WriteLine("Your entered details are added Successfully!!!");

            this.person = new Contacts(firstName, lastName, address, city, state, zipCode, phoneNumber, emailID);
            this.list.Add(this.person);
        }

        /// <summary>
        /// To display all the contacts from list.
        /// </summary>
        public void Display()
        {
            foreach (Contacts biodata in this.list)
            {
                Console.WriteLine(biodata);
            }
            if (list.Count == 0)
            {
                Console.WriteLine("There is no records in address book.");
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
                        Contacts addressBook = this.list[i];
                        Console.WriteLine(addressBook);
                        Console.WriteLine("Enter your choice for editing: ");
                        Console.WriteLine("1.Address 2.City 3.State 4.Zip Code 5.Phone Number 6.Email ID 7.Exit");
                        string choice = Console.ReadLine();
                        int ch = Convert.ToInt32(choice);
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("Please enter new address : ");
                                string address = Console.ReadLine();
                                addressBook.Address = address;
                                break;
                            case 2:
                                Console.WriteLine("Please enter new city : ");
                                string city = Console.ReadLine();
                                addressBook.City = city;
                                break;
                            case 3:
                                Console.WriteLine("Please enter new state : ");
                                string state = Console.ReadLine();
                                addressBook.State = state;
                                break;

                            case 4:
                                Console.WriteLine("Please enter new zip code : ");
                                int zipCode = Convert.ToInt32(Console.ReadLine());
                                addressBook.ZipCode = zipCode;
                                break;

                            case 5:
                                Console.WriteLine("Please enter new mobile number : ");
                                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                                addressBook.MobileNumber = phoneNumber;
                                break;

                            case 6:
                                Console.WriteLine("Please enter new email id  : ");
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
        public void Delete(string firstName)
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    this.list[i] = null;
                }
            }
            Console.WriteLine("You have deleted record successfully!!!");
        }

        /// <summary>
        /// Search a person by city or state
        /// </summary>
        public void SearchPersonInStateOrCity()
        {
            Console.WriteLine("Please Enter Your Choice Which You Want To search...");
            Console.WriteLine("1. State 2. City");
            string option = Console.ReadLine();
            int select = Convert.ToInt32(option);
            switch (select)
            {
                case 1:
                    Console.WriteLine("Please Enter Your First Name : ");
                    String nameToSearchInState = Console.ReadLine();
                    foreach (Contacts addressBook in list.FindAll(e => e.FirstName == nameToSearchInState))
                    {
                        Console.WriteLine("State of " + nameToSearchInState + " is : " + addressBook.State + "\n");
                    }
                    break;
                case 2:
                    Console.WriteLine("Please Enter Your First Name : ");
                    string searchFirstNameInStateOrCity = Console.ReadLine();
                    foreach (Contacts addressBook in list.FindAll(e => e.FirstName == searchFirstNameInStateOrCity))
                    {
                        Console.WriteLine("City of " + searchFirstNameInStateOrCity + " is : " + addressBook.City + "\n");
                    }
                    break;
            }

        }

        /// <summary>
        /// View person by state or city.
        /// </summary>
        public void ViewPersonsByStateOrCity()
        {
            Console.WriteLine("Please Select Your choice : ");
            Console.WriteLine("1. State  2. City");
            String choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Please Enter Your State : ");
                    String state = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].State.Equals(state))
                            Console.WriteLine(list[i]);
                    }
                    break;
                case 2:
                    Console.WriteLine("Please Enter Your City : ");
                    String city = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].City.Equals(city))
                            Console.WriteLine(list[i]);
                    }
                    break;
            }
        }

        /// <summary>
        /// Count person by state or city.
        /// </summary>
        public void PersonsCountByStateOrCity()
        {
            int count = 0;
            Console.WriteLine("Please Select An Option To Count Person By : ");
            Console.WriteLine("1. State  2. City");
            String choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Please Enter Your State : ");
                    String state = Console.ReadLine();
                    foreach (Contacts addressBook in list.FindAll(c => c.State == state))
                    {
                        //Will return total number of person in same state.
                        count = list.Count();
                    }
                    Console.WriteLine(count);
                    break;
                case 2:
                    Console.WriteLine("Please Enter Your City : ");
                    String city = Console.ReadLine();
                    foreach (Contacts addressBook in list.FindAll(c => c.City == city))
                    {
                        //Will return total number of person in same city.
                        count = list.Count();
                    }
                    Console.WriteLine(count);
                    break;
            }
        }

        /*

        /// <summary>
        /// Sorting details by first name.
        /// </summary>
        public void SortByFirstName()
        {
            List<string> sortList = new List<string>();
            foreach (Contacts contacts in list)
            {
                string sort = contacts.ToString();
                sortList.Add(sort);
            }
            sortList.Sort();
            foreach (string sort in sortList)
            {
                Console.WriteLine(sort);
            }
        }

        */


        public void SortByName()
        {
            list.Sort(this.SortByNameCityOrZip);
            this.Display();
        }

        /// <summary>
        /// Method to sort by name,city,state or zip.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int SortByNameCityOrZip(Contacts x, Contacts y)
        {
            Console.WriteLine("Please enter your choice for sorting : ");
            Console.WriteLine("1. First Name 2. City 3. State 4. Zip Code");
            String choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    return x.FirstName.CompareTo(y.FirstName);
                case 2:
                    return x.City.CompareTo(y.City);
                case 3:
                    return x.State.CompareTo(y.State);
                case 4:
                    return x.ZipCode.CompareTo(y.ZipCode);
            }
            return 0;
        }

        /// <summary>
        /// Writing into file using StreamWriter.
        /// </summary>
        public void WriteIntoFileUsingFileIO()
        {
            string path = "C:/Users/HP/Desktop/SanjuBridgelabz/AddressBookSystems/AddressBook/PersonDetails.txt";
            if (File.Exists(path))
            {

                //---Using----->keyword will automatically close the file after performing operation. No need to close it like dispose() method.
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    foreach (Contacts dataEntry in this.list)
                    {
                        streamWriter.WriteLine(dataEntry);
                    }
                }

                Console.WriteLine("SucessFully write into .txt file");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("File does not exist beacuse of wrong path or file name!!");
            }
        }

        /// <summary>
        /// Reading fro file using StreamReader.
        /// </summary>
        public void ReadFromFileUsingFileIO()
        {
            string path = "C:/Users/HP/Desktop/SanjuBridgelabz/AddressBookSystems/AddressBook/PersonDetails.txt";
            if (File.Exists(path))
            {

                //---Using----->keyword will automatically close the file after performing operation. No need to close it like dispose() method.
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string data = "";
                    while ((data = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(data);
                    }
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("File does not exists beacuse of wrong path or file name");
            }
        }
    }
}











