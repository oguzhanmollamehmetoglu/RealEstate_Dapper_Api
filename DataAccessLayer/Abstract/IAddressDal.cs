using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IAddressDal
    {
        Task<List<Address>> GetAllAddress();

        Task CreateAddress(Address address);

        Task DeleteAddress(int id);

        Task UpdateAddress(Address address);

        Task<Address> GetAddress(int id);
    }
}