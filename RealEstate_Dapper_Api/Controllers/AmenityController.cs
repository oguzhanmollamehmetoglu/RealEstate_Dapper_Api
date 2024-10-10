using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmenityController : ControllerBase
    {
        private readonly IAmenityDal _amenityDal;

        public AmenityController(IAmenityDal amenityDal)
        {
            _amenityDal = amenityDal;
        }

        [HttpGet]
        public async Task<IActionResult> AmenityList()
        {
            var values = await _amenityDal.GetAllAmenity();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAmenity(Amenity amenity)
        {
            await _amenityDal.CreateAmenity(amenity);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAmenity(int id)
        {
            await _amenityDal.DeleteAmenity(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAmenity(Amenity amenity)
        {
            await _amenityDal.UpdateAmenity(amenity);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAmenity(int id)
        {
            var values = await _amenityDal.GetAmenity(id);
            return Ok(values);
        }
    }
}