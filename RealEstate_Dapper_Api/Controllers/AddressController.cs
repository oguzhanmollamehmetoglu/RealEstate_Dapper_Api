using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressDal _addressDal;

        public AddressController(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        [HttpGet]
        public async Task<IActionResult> AddressList()
        {
            var values = await _addressDal.GetAllAddress();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress(Address address)
        {
            await _addressDal.CreateAddress(address);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            await _addressDal.DeleteAddress(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAddress(Address address)
        {
            await _addressDal.UpdateAddress(address);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddress(int id)
        {
            var values = await _addressDal.GetAddress(id);
            return Ok(values);
        }
    }
}