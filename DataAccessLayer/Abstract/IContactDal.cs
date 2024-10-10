using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IContactDal
    {
        Task<List<Contact>> GetAllContact();

        Task<List<Contact>> GetLastForeContact();

        Task CreateContact(Contact contact);

        Task DeleteContact(int id);

        Task<Contact> GetContact(int id);
    }
}