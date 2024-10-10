using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        Task<List<Category>> GetAllCategory();

        Task CreateCategory(Category category);

        Task DeleteCategory(int id);

        Task UpdateCategory(Category category);

        Task<Category> GetCategory(int id);
    }
}