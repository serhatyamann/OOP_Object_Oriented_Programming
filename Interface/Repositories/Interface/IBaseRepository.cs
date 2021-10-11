using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Repositories.Interface
{
    public interface IBaseRepository<T>
    {
        //Here is a generic type List method, but it does not have a body.
        List<T> GetContacts(); 
    }
}
