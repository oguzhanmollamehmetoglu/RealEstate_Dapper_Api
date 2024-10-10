using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public async Task TCreateBrand(Brand brand)
        {
            await _brandDal.CreateBrand(brand);
        }

        public async Task TDeleteBrand(int id)
        {
            await _brandDal.DeleteBrand(id);
        }

        public async Task<List<Brand>> TGetAllBrand()
        {
            return await _brandDal.GetAllBrand();
        }

        public async Task<Brand> TGetBrand(int id)
        {
            return await _brandDal.GetBrand(id);
        }

        public async Task TUpdateBrand(Brand brand)
        {
            await _brandDal.UpdateBrand(brand);
        }
    }
}