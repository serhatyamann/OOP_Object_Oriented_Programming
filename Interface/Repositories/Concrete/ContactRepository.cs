using Interface.Entities.Concrete;
using Interface.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Repositories.Concrete
{
    public class ContactRepository : IContactRepository, IBaseRepository<Contact>
    //ContactRepository inherited from both IContactRepository and IBaseRepository<T> interfaces.
    {

        public void CreateContact(int id, string firstName, string lastName, string phone)
        //The body of CreateContact() is provided here
        {
            Contact contact = new Contact
            {
                ID = id,
                FirstName = firstName,
                LastName = lastName,
                Phone = phone
            };
            FakeData.contacts.Add(contact);
        }

        public void DeleteContact(int id)
        //The body of DeleteContact() is provided here
        {
            foreach (Contact contact in FakeData.contacts.ToList())
            {
                if (contact.ID == id)
                {
                    FakeData.contacts.Remove(contact);
                }
            }
        }

        public List<Contact> GetContacts()
        //The body of GetContacts() is provided here
        {
            return FakeData.contacts.ToList();
        }
    }
}
