using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationController : ControllerBase
    {
        private readonly IPopularLocationDal _popularLocationDal;

        public PopularLocationController(IPopularLocationDal popularLocationDal)
        {
            _popularLocationDal = popularLocationDal;
        }

        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values = await _popularLocationDal.GetAllPopularLocation();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePopularLocation(PopularLocation popularLocation)
        {
            await _popularLocationDal.CreatePopularLocation(popularLocation);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePopularLocation(int id)
        {
            await _popularLocationDal.DeletePopularLocation(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePopularLocation(PopularLocation popularLocation)
        {
            await _popularLocationDal.UpdatePopularLocation(popularLocation);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPopularLocation(int id)
        {
            var values = await _popularLocationDal.GetPopularLocation(id);
            return Ok(values);
        }
    }
}