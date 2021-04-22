using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Infrastructure
{
    public interface IAddressService
    {
        public List<Address> GetAddresses();
        public Address AddAddresses(Address address);
    }
}
