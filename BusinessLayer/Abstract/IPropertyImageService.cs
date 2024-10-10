using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IPropertyImageService
    {
        Task<List<PropertyImage>> TGetPropertyImageByPropertyId(int id);
    }
}