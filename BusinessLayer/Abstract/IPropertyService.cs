using DataTransferObjectLayer.Dtos.PropertyDtos;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IPropertyService
    {
        Task<List<Property>> TGetAllPropertyAsync();

        Task TCreateProperty(Property property);

        Task TDeleteProperty(int id);

        Task TUpdateProperty(UpdatePropertyDtos updatePropertyDtos);

        Task<Property> TGetProperty(int id);

        Task<List<Property>> TGetPropertyAdvertListByAppUserAsyncByTrue(int id);

        Task<List<Property>> TGetPropertyAdvertListByAppUserAsyncByFalse(int id);

        Task<List<Property>> TGetPropertyAdvertListByAppUserAsyncByStatusFalse(int id);

        Task<List<Property>> TGetResultPropertyWithCategoryAsync();

        Task<List<ResultPropertyDtos>> TGetResultPropertyWithCategoryStatusByTrueAsync();

        Task<List<ResultPropertyDtos>> TGetPropertyByDealOfTheDayTrueWithCategoryAsync();

        Task<List<Property>> TGetPropertyWithSearchListAsync(string searchKeyValue, int propertyCategoryId, string city);

        Task TPropertyDealOfTheDayStatusChangeToTrue(int id);

        Task TPropertyDealOfTheDayStatusChangeToFalse(int id);

        Task TPropertyStatusChangeToTrue(int id);

        Task TPropertyStatusChangeToFalse(int id);

        Task TAdvertPropertyStatusChangeToFalse(int id);

        Task<List<ResultLastFivePropertyWithCategoryDto>> TGetLastFivePropertyAsync();

        Task<List<Property>> TGetLastThreePropertyAsync();

        Task<Property> TGetPropertyByPropertyId(int id);
    }
}