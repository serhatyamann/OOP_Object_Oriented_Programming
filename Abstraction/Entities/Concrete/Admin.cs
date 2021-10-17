using Abstraction.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities.Concrete
{
    public class Admin : User //Admin class inherited from User abstract class.
    {
        public override string LogInString()
        {
            return "Admin logged in successfully";
        }

        //I want to override my virtual function - VirtualLogInString() here.

        public override string VirtualLogInString()
        {
            return "Overridden.";
        }
    }
}
