using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaController(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        [HttpGet]
        public async Task<IActionResult> SocialMediaList()
        {
            var values = await _socialMediaDal.GetAllSocialMedia();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSocialMedia(SocialMedia socialMedia)
        {
            await _socialMediaDal.CreateSocialMedia(socialMedia);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSocialMedia(int id)
        {
            await _socialMediaDal.DeleteSocialMedia(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSocialMedia(SocialMedia socialMedia)
        {
            await _socialMediaDal.UpdateSocialMedia(socialMedia);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSocialMedia(int id)
        {
            var values = await _socialMediaDal.GetSocialMedia(id);
            return Ok(values);
        }
    }
}