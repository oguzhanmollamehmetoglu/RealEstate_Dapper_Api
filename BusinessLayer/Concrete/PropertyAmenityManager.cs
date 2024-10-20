using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataTransferObjectLayer.Dtos.PropertyAmenityDtos;
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

        public async Task TCreatePropertyAmenity(CreatePropertyAmenityDto createPropertyAmenityDto)
        {
            await _propertyAmenityDal.CreatePropertyAmenity(createPropertyAmenityDto);
        }

        public async Task<List<PropertyAmenity>> TGetPropertyAmenityByPropertyId(int id)
        {
            return await _propertyAmenityDal.GetPropertyAmenityByPropertyId(id);
        }

        public async Task<List<PropertyAmenity>> TGetPropertyAmenityByStatusTrue(int id)
        {
            return await _propertyAmenityDal.GetPropertyAmenityByStatusTrue(id);
        }
    }
}