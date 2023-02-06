using Domain.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repositories
{
    public interface IContactsRepository
    {
        IQueryable<Contact> GetContacts();
        void AddContact(Contact c);
    }

   
}