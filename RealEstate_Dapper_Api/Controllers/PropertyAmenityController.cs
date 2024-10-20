using DataAccessLayer.Abstract;
using DataTransferObjectLayer.Dtos.PropertyAmenityDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyAmenityController : ControllerBase
    {
        private readonly IPropertyAmenityDal _propertyAmenityDal;

        public PropertyAmenityController(IPropertyAmenityDal propertyAmenityDal)
        {
            _propertyAmenityDal = propertyAmenityDal;
        }

        [HttpGet]
        public async Task<IActionResult> GetPropertyAmenityByStatusTrue(int id)
        {
            var values = await _propertyAmenityDal.GetPropertyAmenityByStatusTrue(id);
            return Ok(values);
        }

        [HttpGet("GetPropertyAmenityByPropertyId")]
        public async Task<IActionResult> GetPropertyAmenityByPropertyId(int id)
        {
            var values = await _propertyAmenityDal.GetPropertyAmenityByPropertyId(id);
            return Ok(values);
        }

        [HttpPost("CreatePropertyAmenity")]
        public async Task<IActionResult> CreatePropertyAmenity(CreatePropertyAmenityDto createPropertyAmenityDto)
        {
            await _propertyAmenityDal.CreatePropertyAmenity(createPropertyAmenityDto);
            return Ok("Başarıyla eklendi");
        }
    }
}