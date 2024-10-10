using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IPropertyAmenityService
    {
        Task<List<PropertyAmenity>> TGetPropertyAmenityByStatusTrue(int id);
    }
}