using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IPropertyDetailService
    {
        Task<PropertyDetails> TGetPropertyDetailByPropertyId(int id);

        Task<List<PropertyDetails>> TGetAllPropertyDetail();

        Task TCreatePropertyDetail(PropertyDetails propertyDetails);

        Task TDeletePropertyDetail(int id);

        Task TUpdatePropertyDetail(PropertyDetails propertyDetails);

        Task<PropertyDetails> TGetPropertyDetail(int id);
    }
}