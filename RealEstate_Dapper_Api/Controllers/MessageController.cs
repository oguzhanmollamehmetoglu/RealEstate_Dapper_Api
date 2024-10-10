using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageDal _messageDal;

        public MessageController(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        [HttpGet]
        public async Task<IActionResult> GetInBoxLastThreeMessageListByReceiver(int id)
        {
            var values = await _messageDal.GetInBoxLastThreeMessageListByReceiver(id);
            return Ok(values);
        }
    }
}