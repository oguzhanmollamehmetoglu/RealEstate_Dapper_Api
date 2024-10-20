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

        public async Task TAllDeletePropertyImage(int id)
        {
            await _propertyImageDal.AllDeletePropertyImage(id);
        }

        public async Task TCreatePropertyImage(PropertyImage propertyImage)
        {
            await _propertyImageDal.CreatePropertyImage(propertyImage);
        }

        public async Task TDeletePropertyImage(int id)
        {
            await _propertyImageDal.DeletePropertyImage(id);
        }

        public async Task<List<PropertyImage>> TGetAllPropertyImageAsync()
        {
            return await _propertyImageDal.GetAllPropertyImageAsync();
        }

        public async Task<PropertyImage> TGetPropertyImage(int id)
        {
            return await _propertyImageDal.GetPropertyImage(id);
        }

        public async Task<List<PropertyImage>> TGetPropertyImageByPropertyId(int id)
        {
            return await _propertyImageDal.GetPropertyImageByPropertyId(id);
        }

        public async Task TUpdatePropertyImage(PropertyImage propertyImage)
        {
            await _propertyImageDal.UpdatePropertyImage(propertyImage);
        }
    }
}