using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor_And_Destructor
{
    public class User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        
        public User()
        {
            MessageBox.Show("An Instance of class created.");
        }
        //Overloaded one.
        public User(int _id)
        {
            this.ID = _id;
            MessageBox.Show($"ID: {this.ID}");
        }
        //Overloaded another one.
        public User(int _id, string _fullName, int _age)
        {
            this.ID = _id;
            this.FullName = _fullName;
            this.Age = _age;
            MessageBox.Show($"ID: {this.ID}\nFull Name: {this.FullName}\nAge: {this.Age}");
        }
        //Destructor
        ~User()
        {
            MessageBox.Show("An Instance of class destroyed");
        }
    }
}
