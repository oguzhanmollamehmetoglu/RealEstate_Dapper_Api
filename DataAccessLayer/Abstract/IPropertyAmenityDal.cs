using DataTransferObjectLayer.Dtos.PropertyAmenityDtos;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IPropertyAmenityDal
    {
        Task<List<PropertyAmenity>> GetPropertyAmenityByStatusTrue(int id);

        Task<List<PropertyAmenity>> GetPropertyAmenityByPropertyId(int id);

        Task CreatePropertyAmenity(CreatePropertyAmenityDto createPropertyAmenityDto);
    }
}