using Interface.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public static class FakeData
    {
        public static List<Contact> contacts = new List<Contact>()
        {
            new Contact {ID = 1, FirstName = "Mike", LastName="Tyson", Phone="22221111" },
            new Contact {ID = 2, FirstName = "John", LastName="Robert", Phone="22221111" },
            new Contact {ID = 3, FirstName = "Victoria", LastName="Beckham", Phone="22221111"}
        };
    }
}
