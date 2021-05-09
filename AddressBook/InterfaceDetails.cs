using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public interface InterfaceDetails
    {
        /// <summary>
        /// Add person details.
        /// </summary>
        public void AddDetails();

        /// <summary>
        /// Display details.
        /// </summary>
        public void Display();

        /// <summary>
        /// Edit details.
        /// </summary>
        /// <param name="firstName"></param>
        public void Edit(string firstName);

        /// <summary>
        /// Delete contact.
        /// </summary>
        /// <param name="firstName"></param>
        public void Delete(string firstName);

        /// <summary>
        /// Search person in state or city.
        /// </summary>
        public void SearchPersonInStateOrCity();

        /// <summary>
        /// View person by state or city.
        /// </summary>
        public void ViewPersonsByStateOrCity();

        /// <summary>
        /// Get person count by state or city.
        /// </summary>
        public void PersonsCountByStateOrCity();

        /// <summary>
        /// Sorting entries by first ame.
        /// </summary>
        public void SortByFirstName();    
    }
}
