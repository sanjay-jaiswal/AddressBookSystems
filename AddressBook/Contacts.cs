﻿using System;
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
        private string zipCode;
        private string mobileNumber;
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
        public Contacts(string firstName, string lastName, string address, string city, string state, string zipCode, string mobileNumber, string emailID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.ZipCode = zipCode;
            this.mobileNumber = mobileNumber;
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
        public string ZipCode { get => this.zipCode; set => this.zipCode = value; }
        public string MobileNumber { get => this.mobileNumber; set => this.mobileNumber = value; }
        public string EmailID { get => this.emailID; set => this.emailID = value; }



        /// <summary>
        /// toString method is used to read object into string format.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "\n  FirstName    : " + this.firstName
                 + "\n  LastName     : " + this.lastName
                 + "\n  Address      : " + this.address
                 + "\n  City         : " + this.city
                 + "\n  State        : " + this.state
                 + "\n  ZipCode      : " + this.zipCode
                 + "\n  MobileNumber : " + this.mobileNumber
                 + "\n  EmailID      : " + this.emailID + "\n" +
                   "/****************************************/";
        }
    }
}
