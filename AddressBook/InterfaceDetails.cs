using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public interface InterfaceDetails
    {
        public void AddDetails();

        public void Display();

        public void Edit(string firstName);

        public void Delete(string firstName);
    }
}
