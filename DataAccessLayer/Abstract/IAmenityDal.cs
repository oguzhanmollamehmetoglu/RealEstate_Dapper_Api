using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IAmenityDal
    {
        Task<List<Amenity>> GetAllAmenity();

        Task CreateAmenity(Amenity amenity);

        Task DeleteAmenity(int id);

        Task UpdateAmenity(Amenity amenity);

        Task<Amenity> GetAmenity(int id);
    }
}