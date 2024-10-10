using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IPropertyImageDal
    {
        Task<List<PropertyImage>> GetPropertyImageByPropertyId(int id);
    }
}