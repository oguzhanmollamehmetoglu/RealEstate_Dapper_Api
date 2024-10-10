using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IPropertyAmenityDal
    {
        Task<List<PropertyAmenity>> GetPropertyAmenityByStatusTrue(int id);
    }
}