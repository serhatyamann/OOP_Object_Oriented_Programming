using Interface.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entities.Concrete
{
    public class Contact:Base //Contact class inherited from Base abstract class.
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
