using DataAccessLayer.Abstract;
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
    }
}