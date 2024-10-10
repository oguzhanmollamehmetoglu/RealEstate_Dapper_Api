using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyDetailController : ControllerBase
    {
        private readonly IPropertyDetailDal _propertyDetailDal;

        public PropertyDetailController(IPropertyDetailDal propertyDetailDal)
        {
            _propertyDetailDal = propertyDetailDal;
        }

        [HttpGet]
        public async Task<IActionResult> PropertyDetailList()
        {
            var values = await _propertyDetailDal.GetAllPropertyDetail();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePropertyDetail(PropertyDetails propertyDetails)
        {
            await _propertyDetailDal.CreatePropertyDetail(propertyDetails);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePropertyDetail(int id)
        {
            await _propertyDetailDal.DeletePropertyDetail(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePropertyDetail(PropertyDetails propertyDetails)
        {
            await _propertyDetailDal.UpdatePropertyDetail(propertyDetails);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPropertyDetail(int id)
        {
            var values = await _propertyDetailDal.GetPropertyDetail(id);
            return Ok(values);
        }

        [HttpGet("GetPropertyDetailByPropertyId")]
        public async Task<IActionResult> GetPropertyDetailByProductId(int id)
        {
            var values = await _propertyDetailDal.GetPropertyDetailByPropertyId(id);
            return Ok(values);
        }
    }
}