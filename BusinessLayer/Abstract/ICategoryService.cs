using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        Task<List<Category>> TGetAllCategory();

        Task TCreateCategory(Category category);

        Task TDeleteCategory(int id);

        Task TUpdateCategory(Category category);

        Task<Category> TGetCategory(int id);
    }
}