using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IPropertyDetailDal
    {
        Task<PropertyDetails> GetPropertyDetailByPropertyId(int id);

        Task<List<PropertyDetails>> GetAllPropertyDetail();

        Task CreatePropertyDetail(PropertyDetails propertyDetails);

        Task DeletePropertyDetail(int id);

        Task UpdatePropertyDetail(PropertyDetails propertyDetails);

        Task<PropertyDetails> GetPropertyDetail(int id);
    }
}