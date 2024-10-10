using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PropertyAmenityManager : IPropertyAmenityService
    {
        private readonly IPropertyAmenityDal _propertyAmenityDal;

        public PropertyAmenityManager(IPropertyAmenityDal propertyAmenityDal)
        {
            _propertyAmenityDal = propertyAmenityDal;
        }

        public async Task<List<PropertyAmenity>> TGetPropertyAmenityByStatusTrue(int id)
        {
            return await _propertyAmenityDal.GetPropertyAmenityByStatusTrue(id);
        }
    }
}