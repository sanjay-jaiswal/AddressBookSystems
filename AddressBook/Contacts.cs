using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    /// <summary>
    /// Variables declarations
    /// </summary>
    public class Contacts
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private int zipCode;
        private long phoneNumber;
        private string emailID;

        /// <summary>
        /// Passing value through constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="emailID"></param>
        public Contacts(string firstName, string lastName, string address, string city, string state, int zipCode, long phoneNumber, string emailID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.emailID = emailID;
        }

        /// <summary>
        /// Using lmbda expression to get and set values
        /// </summary>
        public string FirstName { get => this.firstName; set => this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string Address { get => this.address; set => this.address = value; }
        public string City { get => this.city; set => this.city = value; }
        public string State { get => this.state; set => this.state = value; }
        public int ZipCode { get => this.zipCode; set => this.zipCode = value; }
        public long PhoneNumber { get => this.phoneNumber; set => this.phoneNumber = value; }
        public string EmailID { get => this.emailID; set => this.emailID = value; }



        /// <summary>
        /// toString method is used to read object into string format.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[FirstName=" + this.firstName + ", LastName=" + this.lastName + ", Address=" + this.address + ", City=" + this.city + ", State=" + this.state + ", ZipCode=" + this.zipCode + ", PhoneNumber=" + this.phoneNumber + ", EmailID=" + this.emailID + "]" + "\n";
        }
    }
}
