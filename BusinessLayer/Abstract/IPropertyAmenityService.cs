using DataTransferObjectLayer.Dtos.PropertyAmenityDtos;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IPropertyAmenityService
    {
        Task<List<PropertyAmenity>> TGetPropertyAmenityByStatusTrue(int id);

        Task<List<PropertyAmenity>> TGetPropertyAmenityByPropertyId(int id);

        Task TCreatePropertyAmenity(CreatePropertyAmenityDto createPropertyAmenityDto);
    }
}