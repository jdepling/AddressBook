using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Address
    {
        public Address()
        {

        }

        public Address(string firstName, string lastName, string streetAddress, string city, string state, string zipCode)
        {
            FirstName     = firstName     ?? throw new ArgumentNullException(nameof(firstName));
            LastName      = lastName      ?? throw new ArgumentNullException(nameof(lastName));
            StreetAddress = streetAddress ?? throw new ArgumentNullException(nameof(streetAddress));
            City          = city          ?? throw new ArgumentNullException(nameof(city));
            State         = state         ?? throw new ArgumentNullException(nameof(state));
            ZipCode       = zipCode       ?? throw new ArgumentNullException(nameof(zipCode));
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }


    }
}
