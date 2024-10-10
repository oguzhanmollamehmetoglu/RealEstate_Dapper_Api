using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactDal _contactDal;

        public ContactController(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var values = await _contactDal.GetAllContact();
            return Ok(values);
        }

        [HttpGet("GetLastForeContactList")]
        public async Task<IActionResult> GetLastForeContactList()
        {
            var values = await _contactDal.GetLastForeContact();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(Contact contact)
        {
            await _contactDal.CreateContact(contact);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _contactDal.DeleteContact(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var values = await _contactDal.GetContact(id);
            return Ok(values);
        }
    }
}