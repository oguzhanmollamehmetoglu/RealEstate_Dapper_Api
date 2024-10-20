using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IPropertyImageService
    {
        Task<List<PropertyImage>> TGetPropertyImageByPropertyId(int id);

        Task<List<PropertyImage>> TGetAllPropertyImageAsync();

        Task TCreatePropertyImage(PropertyImage propertyImage);

        Task TDeletePropertyImage(int id);

        Task TAllDeletePropertyImage(int id);

        Task TUpdatePropertyImage(PropertyImage propertyImage);

        Task<PropertyImage> TGetPropertyImage(int id);
    }
}