using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public async Task TCreateContact(Contact contact)
        {
            await _contactDal.CreateContact(contact);
        }

        public async Task TDeleteContact(int id)
        {
            await _contactDal.DeleteContact(id);
        }

        public async Task<List<Contact>> TGetAllContact()
        {
            return await _contactDal.GetAllContact();
        }

        public async Task<Contact> TGetContact(int id)
        {
            return await _contactDal.GetContact(id);
        }

        public async Task<List<Contact>> TGetLastForeContact()
        {
            return await _contactDal.GetLastForeContact();
        }
    }
}