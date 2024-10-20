using DataTransferObjectLayer.Dtos.PropertyDtos;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IPropertyDal
    {
        Task<List<Property>> GetAllPropertyAsync();

        Task CreateProperty(Property property);

        Task DeleteProperty(int id);

        Task UpdateProperty(UpdatePropertyDtos updatePropertyDtos);

        Task<Property> GetProperty(int id);

        Task<List<Property>> GetPropertyAdvertListByAppUserAsyncByTrue(int id);

        Task<List<Property>> GetPropertyAdvertListByAppUserAsyncByFalse(int id);

        Task<List<Property>> GetPropertyAdvertListByAppUserAsyncByStatusFalse(int id);

        Task<List<Property>> GetResultPropertyWithCategoryAsync();

        Task<List<ResultPropertyDtos>> GetResultPropertyWithCategoryStatusByTrueAsync();

        Task<List<ResultPropertyDtos>> GetPropertyByDealOfTheDayTrueWithCategoryAsync();

        Task<List<Property>> GetPropertyWithSearchListAsync(string searchKeyValue, int propertyCategoryId, string city);

        Task PropertyDealOfTheDayStatusChangeToTrue(int id);

        Task PropertyDealOfTheDayStatusChangeToFalse(int id);

        Task PropertyStatusChangeToTrue(int id);

        Task PropertyStatusChangeToFalse(int id);

        Task AdvertPropertyStatusChangeToFalse(int id);

        Task<List<ResultLastFivePropertyWithCategoryDto>> GetLastFivePropertyAsync();

        Task<List<Property>> GetLastThreePropertyAsync();

        Task<Property> GetPropertyByPropertyId(int id);
    }
}