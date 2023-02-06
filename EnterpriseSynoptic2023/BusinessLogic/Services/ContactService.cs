
using DataAccess.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class ContactService
    {
        private IContactsRepository repository;

        public ContactService(ContactRepository repository)
        {
            this.repository = (IContactsRepository)repository;
        }

        public IQueryable<Contact> GetContacts()
        {
            return repository.GetContacts();
        }

        public void AddContact(Contact contact)
        {
            repository.AddContact(contact);
        }
    }
}
