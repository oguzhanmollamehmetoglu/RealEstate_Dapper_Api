
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IBrandDal
    {
        Task<List<Brand>> GetAllBrand();

        Task CreateBrand(Brand brand);

        Task DeleteBrand(int id);

        Task UpdateBrand(Brand brand);

        Task<Brand> GetBrand(int id);
    }
}