using System;

namespace BusinessLogic
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _contactRepository.GetContacts();
        }

        public void AddContact(Contact contact)
        {
            _contactRepository.AddContact(contact);
        }
    }
}
