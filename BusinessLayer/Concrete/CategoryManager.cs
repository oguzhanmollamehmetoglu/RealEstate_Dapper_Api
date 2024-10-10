using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task TCreateCategory(Category category)
        {
            await _categoryDal.CreateCategory(category);
        }

        public async Task TDeleteCategory(int id)
        {
            await _categoryDal.DeleteCategory(id);
        }

        public async Task<List<Category>> TGetAllCategory()
        {
            return await _categoryDal.GetAllCategory();
        }

        public async Task<Category> TGetCategory(int id)
        {
            return await _categoryDal.GetCategory(id);
        }

        public async Task TUpdateCategory(Category category)
        {
            await _categoryDal.UpdateCategory(category);
        }
    }
}