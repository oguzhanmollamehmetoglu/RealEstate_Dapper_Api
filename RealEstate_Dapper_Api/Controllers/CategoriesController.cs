using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryDal _categoryDal;

        public CategoriesController(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryDal.GetAllCategory();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            await _categoryDal.CreateCategory(category);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryDal.DeleteCategory(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(Category category)
        {
            await _categoryDal.UpdateCategory(category);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var values = await _categoryDal.GetCategory(id);
            return Ok(values);
        }
    }
}