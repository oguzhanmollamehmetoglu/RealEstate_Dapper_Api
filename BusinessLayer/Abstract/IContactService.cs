using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        Task<List<Contact>> TGetAllContact();

        Task<List<Contact>> TGetLastForeContact();

        Task TCreateContact(Contact contact);

        Task TDeleteContact(int id);

        Task<Contact> TGetContact(int id);
    }
}