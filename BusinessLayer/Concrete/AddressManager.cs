using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public async Task TCreateAddress(Address address)
        {
            await _addressDal.CreateAddress(address);
        }

        public async Task TDeleteAddress(int id)
        {
            await _addressDal.DeleteAddress(id);
        }

        public async Task<Address> TGetAddress(int id)
        {
            return await _addressDal.GetAddress(id);
        }

        public async Task<List<Address>> TGetAllAddress()
        {
            return await _addressDal.GetAllAddress();
        }

        public async Task TUpdateAddress(Address address)
        {
            await _addressDal.UpdateAddress(address);
        }
    }
}