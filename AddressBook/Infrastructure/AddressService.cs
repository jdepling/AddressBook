using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Infrastructure
{
    public class AddressService : IAddressService
    {
        private readonly List<Address> _addresses;

        public AddressService()
        {
            _addresses = new List<Address>()
            {
                new Address("Harry", "Potter", "123 A Street", "New York", "New York", "8555"),
                new Address("Ronald", "Smith", "1234 B Street", "San Jose", "California", "76543"),
                new Address("Ryan", "Andrews", "1234 C Street", "San Jose", "California", "76543"),
            };
        }

        public Address AddAddresses(Address address)
        {
            _addresses.Add(address);
            return address;
        }

        public List<Address> GetAddresses()
        {
            return _addresses;
        }

        public Address RemoveAddress(Guid id)
        {
            var address = _addresses.Where(a => a.Id == id).FirstOrDefault();
            _addresses.Remove(address);
            return address;
        }
    }
}
