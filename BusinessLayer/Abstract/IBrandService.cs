
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IBrandService
    {
        Task<List<Brand>> TGetAllBrand();

        Task TCreateBrand(Brand brand);

        Task TDeleteBrand(int id);

        Task TUpdateBrand(Brand brand);

        Task<Brand> TGetBrand(int id);
    }
}