using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly Context _context;

        public ContactRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _context.Contacts.ToList();
        }

        public void AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }
    } 
}
