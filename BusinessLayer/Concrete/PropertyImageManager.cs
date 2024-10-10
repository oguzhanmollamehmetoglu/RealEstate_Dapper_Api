using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PropertyImageManager : IPropertyImageService
    {
        private readonly IPropertyImageDal _propertyImageDal;

        public PropertyImageManager(IPropertyImageDal propertyImageDal)
        {
            _propertyImageDal = propertyImageDal;
        }

        public async Task<List<PropertyImage>> TGetPropertyImageByPropertyId(int id)
        {
            return await _propertyImageDal.GetPropertyImageByPropertyId(id);
        }
    }
}