using Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class ContactsInFileRepository : IContactsRepository
    {
        private readonly string _filePath;
        private List<Contact> _contacts;

        public ContactsInFileRepository(string filePath)
        {
            _filePath = filePath;
            _contacts = LoadContactsFromFile();
        }

        public IQueryable<Contact> GetContacts()
        {
            return _contacts.AsQueryable();
        }

        public void AddContact(Contact c)
        {
            _contacts.Add(c);
            SaveContactsToFile();
        }

        private List<Contact> LoadContactsFromFile()
        {
            // Read the contents of the file and deserialize it into a List of Contact objects
            var fileContents = System.IO.File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Contact>>(fileContents);
        }

        private void SaveContactsToFile()
        {
            // Serialize the List of Contact objects and write it to the file
            var fileContents = JsonConvert.SerializeObject(_contacts);
            System.IO.File.WriteAllText(_filePath, fileContents);
        }
    }
}
