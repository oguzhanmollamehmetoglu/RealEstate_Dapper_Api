using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IPropertyImageDal
    {
        Task<List<PropertyImage>> GetPropertyImageByPropertyId(int id);

        Task<List<PropertyImage>> GetAllPropertyImageAsync();

        Task CreatePropertyImage(PropertyImage propertyImage);

        Task DeletePropertyImage(int id);

        Task AllDeletePropertyImage(int id);

        Task UpdatePropertyImage(PropertyImage propertyImage);

        Task<PropertyImage> GetPropertyImage(int id);
    }
}