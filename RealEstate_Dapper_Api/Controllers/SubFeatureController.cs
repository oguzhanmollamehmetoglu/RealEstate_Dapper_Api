using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubFeatureController : ControllerBase
    {
        private readonly ISubFeatureDal _subFeatureDal;

        public SubFeatureController(ISubFeatureDal subFeatureDal)
        {
            _subFeatureDal = subFeatureDal;
        }

        [HttpGet]
        public async Task<IActionResult> SubFeatureList()
        {
            var values = await _subFeatureDal.GetAllSubFeature();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubFeature(SubFeature subFeature)
        {
            await _subFeatureDal.CreateSubFeature(subFeature);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubFeature(int id)
        {
            await _subFeatureDal.DeleteSubFeature(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSubFeature(SubFeature subFeature)
        {
            await _subFeatureDal.UpdateSubFeature(subFeature);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubFeature(int id)
        {
            var values = await _subFeatureDal.GetSubFeature(id);
            return Ok(values);
        }
    }
}