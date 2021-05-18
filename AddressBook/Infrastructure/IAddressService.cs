using System;
using System.Collections.Generic;

namespace AddressBook.Infrastructure
{
    public interface IAddressService
    {
        public List<Address> GetAddresses();
        public Address AddAddresses(Address address);
        public Address RemoveAddress(Guid id);
    }
}
