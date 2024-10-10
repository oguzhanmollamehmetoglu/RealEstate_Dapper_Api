using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IAmenityService
    {
        Task<List<Amenity>> TGetAllAmenity();

        Task TCreateAmenity(Amenity amenity);

        Task TDeleteAmenity(int id);

        Task TUpdateAmenity(Amenity amenity);

        Task<Amenity> TGetAmenity(int id);
    }
}