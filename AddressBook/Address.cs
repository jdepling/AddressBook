using System;

namespace AddressBook
{
    public class Address
    {
        /// <summary>
        /// Deserialization requires a parameterless constructor
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Constructor for c# code
        /// </summary>
        public Address(string firstName, string lastName, string streetAddress, string city, string state, string zipCode)
        {
            FirstName     = firstName     ?? throw new ArgumentNullException(nameof(firstName));
            LastName      = lastName      ?? throw new ArgumentNullException(nameof(lastName));
            StreetAddress = streetAddress ?? throw new ArgumentNullException(nameof(streetAddress));
            City          = city          ?? throw new ArgumentNullException(nameof(city));
            State         = state         ?? throw new ArgumentNullException(nameof(state));
            ZipCode       = zipCode       ?? throw new ArgumentNullException(nameof(zipCode));
            Id            = Guid.NewGuid();
        }

        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }


    }
}
