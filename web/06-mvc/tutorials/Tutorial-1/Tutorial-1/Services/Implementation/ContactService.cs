using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_1.Model;

namespace Tutorial_1.Services
{
    public class ContactService : IContactService
    {
        private List<Contact> _contacts = new List<Contact>
            {
                new Contact() { Name="Gigi",Phone="23466564"},
                new Contact() { Name="Sergii",Phone="341326635"},
                new Contact() { Name="Max",Phone="24645767"},

            };
        public void CreateContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _contacts;
        }
    }
}
