
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IAddressService
    {
        Task<List<Address>> TGetAllAddress();

        Task TCreateAddress(Address address);

        Task TDeleteAddress(int id);

        Task TUpdateAddress(Address address);

        Task<Address> TGetAddress(int id);
    }
}