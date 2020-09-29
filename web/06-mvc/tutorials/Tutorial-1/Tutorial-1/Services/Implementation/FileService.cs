using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial_1.Model;
using Tutorial_1.Services.Interfaces;

namespace Tutorial_1.Services.Implementation
{
    public class FileService : IFileService
    {
        public void SaveToFile(IEnumerable<Contact> contacts)
        {
            var sBuilder = new StringBuilder();

            foreach (var contact in contacts)
            {
                sBuilder.AppendFormat("Contact Name: {0},\t Phone {1},\t Position {2},\t Salary {3} \t", contact.Name, contact.Phone, contact.position.Name, contact.position.Salary);
            }

            File.WriteAllText("Contacts.txt",sBuilder.ToString());
        }
    }
}
