using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Repositories.Interface
{
    public interface IContactRepository
    {
        //Here are 2 interface methods that do not have a body. But we defined their parameters and we are going to implement those when a class inherits from this Interface.
        void CreateContact(int id, string firstName, string lastName, string phone);
        void DeleteContact(int id);
    }
}
