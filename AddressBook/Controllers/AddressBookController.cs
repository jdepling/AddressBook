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
        [HttpGet]
        public IEnumerable<Address> Get()
        {
            return new List<Address>()
            {
                new Address("Harry", "Potter", "123 A Street", "New York", "New York", "8555"),
                new Address("Ronald", "Smith", "1234 B Street", "San Jose", "California", "76543"),
                new Address("Ryan", "Andrews", "1234 C Street", "San Jose", "California", "76543"),
            };
        }
    }
}
