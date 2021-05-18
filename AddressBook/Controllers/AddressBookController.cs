using AddressBook.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressBookController
    {
        private IAddressService _addressService;
        public AddressBookController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpGet]
        public IEnumerable<Address> Get()
        {
            return _addressService.GetAddresses();
        }

        [HttpPost]
        public Address AddRecord(Address address)
        {
            return _addressService.AddAddresses(address);
        }

        [HttpDelete("{id}")]
        public Address RemoveRecord(Guid id)
        {
            return _addressService.RemoveAddress(id);
        }
    }
}
