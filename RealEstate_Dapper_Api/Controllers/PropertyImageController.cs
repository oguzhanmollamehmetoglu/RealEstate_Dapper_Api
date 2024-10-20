using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyImageController : ControllerBase
    {
        private readonly IPropertyImageDal _propertyImageDal;

        public PropertyImageController(IPropertyImageDal propertyImageDal)
        {
            _propertyImageDal = propertyImageDal;
        }

        [HttpGet]
        public async Task<IActionResult> PropertyImageList()
        {
            var values = await _propertyImageDal.GetAllPropertyImageAsync();
            return Ok(values);
        }

        [HttpGet("GetPropertyImageByPropertyId")]
        public async Task<IActionResult> GetPropertyImageByPropertyId(int id)
        {
            var values = await _propertyImageDal.GetPropertyImageByPropertyId(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePropertyImage(PropertyImage propertyImage)
        {
            await _propertyImageDal.CreatePropertyImage(propertyImage);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePropertyImage(int id)
        {
            await _propertyImageDal.DeletePropertyImage(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpDelete("AllDeletePropertyImage/{id}")]
        public async Task<IActionResult> AllDeletePropertyImage(int id)
        {
            await _propertyImageDal.AllDeletePropertyImage(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePropertyImage(PropertyImage propertyImage)
        {
            await _propertyImageDal.UpdatePropertyImage(propertyImage);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPropertyImage(int id)
        {
            var values = await _propertyImageDal.GetPropertyImage(id);
            return Ok(values);
        }
    }
}