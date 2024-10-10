using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PropertyDetailManager : IPropertyDetailService
    {
        private readonly IPropertyDetailDal _propertyDetailDal;

        public PropertyDetailManager(IPropertyDetailDal propertyDetailDal)
        {
            _propertyDetailDal = propertyDetailDal;
        }

        public async Task TCreatePropertyDetail(PropertyDetails propertyDetails)
        {
            await _propertyDetailDal.CreatePropertyDetail(propertyDetails);
        }

        public async Task TDeletePropertyDetail(int id)
        {
            await _propertyDetailDal.DeletePropertyDetail(id);
        }

        public async Task<List<PropertyDetails>> TGetAllPropertyDetail()
        {
            return await _propertyDetailDal.GetAllPropertyDetail();
        }

        public async Task<PropertyDetails> TGetPropertyDetail(int id)
        {
            return await _propertyDetailDal.GetPropertyDetail(id);
        }

        public async Task<PropertyDetails> TGetPropertyDetailByPropertyId(int id)
        {
            return await _propertyDetailDal.GetPropertyDetailByPropertyId(id);
        }

        public async Task TUpdatePropertyDetail(PropertyDetails propertyDetails)
        {
            await _propertyDetailDal.UpdatePropertyDetail(propertyDetails);
        }
    }
}