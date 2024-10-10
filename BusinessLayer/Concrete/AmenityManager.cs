using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AmenityManager : IAmenityService
    {
        private readonly IAmenityDal _amenityDal;

        public AmenityManager(IAmenityDal amenityDal)
        {
            _amenityDal = amenityDal;
        }

        public async Task TCreateAmenity(Amenity amenity)
        {
            await _amenityDal.CreateAmenity(amenity);
        }

        public async Task TDeleteAmenity(int id)
        {
            await _amenityDal.DeleteAmenity(id);
        }

        public async Task<List<Amenity>> TGetAllAmenity()
        {
            return await _amenityDal.GetAllAmenity();
        }

        public async Task<Amenity> TGetAmenity(int id)
        {
            return await _amenityDal.GetAmenity(id);
        }

        public async Task TUpdateAmenity(Amenity amenity)
        {
            await _amenityDal.UpdateAmenity(amenity);
        }
    }
}