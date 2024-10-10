using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandDal _brandDal;

        public BrandController(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [HttpGet]
        public async Task<IActionResult> BrandList()
        {
            var values = await _brandDal.GetAllBrand();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(Brand brand)
        {
            await _brandDal.CreateBrand(brand);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            await _brandDal.DeleteBrand(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(Brand brand)
        {
            await _brandDal.UpdateBrand(brand);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrand(int id)
        {
            var values = await _brandDal.GetBrand(id);
            return Ok(values);
        }
    }
}