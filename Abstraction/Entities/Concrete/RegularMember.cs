using Abstraction.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities.Concrete
{
    public class RegularMember : User //RegularMember class inherited from User abstract class.
    {
        public override string LogInString()
        {
            return "Member logged in successfully";
        }

        //I do not want to override my virtual function - VirtualLogInString() here. And there are not any errors. Because for virtual methods or functions, override is not a must but for abstract ones, it is.
    }
}
