using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities.Abstract
{
    public abstract class User //An abstract base class.
    {
        //Defining its properties.
        public int ID { get; set; }
        public string Username { get; set; }
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        public abstract string LogInString(); //An abstract function which has to be overridden in classes that inherit from this abstract class.
        public virtual string VirtualLogInString()
        {
            return "You can use this virtual function in sub classes either as it is or by providing a new body.";
        }
    }
}
