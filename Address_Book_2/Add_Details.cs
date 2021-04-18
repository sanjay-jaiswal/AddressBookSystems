using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Address_Book_2
{
    class AddressBook
    {
        public List<Contact> ContactList;
        public AddressBook()
        {
            this.ContactList = new List<Contact>();
        }
        /* public void AddContact(Contact contactObj)
         {
             this.ContactList.Add(contactObj);
         }*/
        public int FindByPhoneNum(long phoneNumber)
        {
            return this.ContactList.FindIndex(contact => contact.PhoneNumber.Equals(phoneNumber));
        }
        //Find Contact Object Index By FirstName
        public int FindByFirstName(string firstName)
        {
            return this.ContactList.FindIndex(contact => contact.FirstName.Equals(firstName));
        }
        //Delete a Give Contact By Index
        public void DeleteContact(int index)
        {
            this.ContactList.RemoveAt(index);
        }
        //for checking dupicate data alredy presnt or not 
        public void AddContact(Contact contactObj)
        {
            if (this.ContactList.Find(e => e.Equals(contactObj)) != null)
                Console.WriteLine("=====oppsss sorry !!! The Contact Already Exists! Please Try Again with Diffrent Contact.=====");
            else
                this.ContactList.Add(contactObj);
        }

    }
}