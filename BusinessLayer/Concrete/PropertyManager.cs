using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataTransferObjectLayer.Dtos.PropertyDtos;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PropertyManager : IPropertyService
    {
        private readonly IPropertyDal _propertyDal;

        public PropertyManager(IPropertyDal propertyDal)
        {
            _propertyDal = propertyDal;
        }

        public async Task TAdvertPropertyStatusChangeToFalse(int id)
        {
            await _propertyDal.AdvertPropertyStatusChangeToFalse(id);
        }

        public async Task TCreateProperty(Property property)
        {
             await _propertyDal.CreateProperty(property);
        }

        public async Task TDeleteProperty(int id)
        {
            await _propertyDal.DeleteProperty(id);
        }

        public async Task<List<Property>> TGetAllPropertyAsync()
        {
            return await _propertyDal.GetAllPropertyAsync();
        }

        public async Task<List<ResultLastFivePropertyWithCategoryDto>> TGetLastFivePropertyAsync()
        {
            return await _propertyDal.GetLastFivePropertyAsync();
        }

        public async Task<List<Property>> TGetLastThreePropertyAsync()
        {
            return await _propertyDal.GetLastThreePropertyAsync();
        }

        public async Task<Property> TGetProperty(int id)
        {
            return await _propertyDal.GetProperty(id);
        }

        public async Task<List<Property>> TGetPropertyAdvertListByAppUserAsyncByFalse(int id)
        {
            return await _propertyDal.GetPropertyAdvertListByAppUserAsyncByFalse(id);
        }

        public async Task<List<Property>> TGetPropertyAdvertListByAppUserAsyncByStatusFalse(int id)
        {
            return await _propertyDal.GetPropertyAdvertListByAppUserAsyncByStatusFalse(id);
        }

        public async Task<List<Property>> TGetPropertyAdvertListByAppUserAsyncByTrue(int id)
        {
            return await _propertyDal.GetPropertyAdvertListByAppUserAsyncByTrue(id);
        }

        public async Task<List<ResultPropertyDtos>> TGetPropertyByDealOfTheDayTrueWithCategoryAsync()
        {
            return await _propertyDal.GetPropertyByDealOfTheDayTrueWithCategoryAsync();
        }

        public async Task<Property> TGetPropertyByPropertyId(int id)
        {
            return await _propertyDal.GetPropertyByPropertyId(id);
        }

        public async Task<List<Property>> TGetPropertyWithSearchListAsync(string searchKeyValue, int propertyCategoryId, string city)
        {
            return await _propertyDal.GetPropertyWithSearchListAsync(searchKeyValue,propertyCategoryId,city);
        }

        public async Task<List<ResultPropertyDtos>> TGetResultPropertyWithCategoryAsync()
        {
            return await _propertyDal.GetResultPropertyWithCategoryAsync();
        }

        public async Task<List<ResultPropertyDtos>> TGetResultPropertyWithCategoryStatusByTrueAsync()
        {
            return await _propertyDal.GetResultPropertyWithCategoryStatusByTrueAsync();
        }

        public async Task TPropertyDealOfTheDayStatusChangeToFalse(int id)
        {
             await _propertyDal.PropertyDealOfTheDayStatusChangeToFalse(id);
        }

        public async Task TPropertyDealOfTheDayStatusChangeToTrue(int id)
        {
            await _propertyDal.PropertyDealOfTheDayStatusChangeToTrue(id);
        }

        public async Task TPropertyStatusChangeToFalse(int id)
        {
            await _propertyDal.PropertyStatusChangeToFalse(id);
        }

        public async Task TPropertyStatusChangeToTrue(int id)
        {
            await _propertyDal.PropertyStatusChangeToTrue(id);
        }

        public async Task TUpdateProperty(UpdatePropertyDtos updatePropertyDtos)
        {
            await _propertyDal.UpdateProperty(updatePropertyDtos);
        }
    }
}