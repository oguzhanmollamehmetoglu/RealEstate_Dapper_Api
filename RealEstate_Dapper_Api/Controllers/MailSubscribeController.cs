using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailSubscribeController : ControllerBase
    {
        private readonly IMailSubscribeDal _mailSubscribeDal;

        public MailSubscribeController(IMailSubscribeDal mailSubscribeDal)
        {
            _mailSubscribeDal = mailSubscribeDal;
        }

        [HttpGet]
        public async Task<IActionResult> MailSubscribeList()
        {
            var values = await _mailSubscribeDal.GetAllMailSubscribe();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMailSubscribe(MailSubscribe mailSubscribe)
        {
            await _mailSubscribeDal.CreateMailSubscribe(mailSubscribe);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMailSubscribe(int id)
        {
            await _mailSubscribeDal.DeleteMailSubscribe(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMailSubscribe(MailSubscribe mailSubscribe)
        {
            await _mailSubscribeDal.UpdateMailSubscribe(mailSubscribe);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMailSubscribe(int id)
        {
            var values = await _mailSubscribeDal.GetMailSubscribe(id);
            return Ok(values);
        }
    }
}