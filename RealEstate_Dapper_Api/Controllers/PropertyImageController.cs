using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Abstract;

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

        [HttpGet("GetPropertyImageByPropertyId")]
        public async Task<IActionResult> GetPropertyImageByPropertyId(int id)
        {
            var values = await _propertyImageDal.GetPropertyImageByPropertyId(id);
            return Ok(values);
        }
    }
}