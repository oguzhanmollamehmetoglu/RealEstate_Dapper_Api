using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceDal _serviceDal;

        public ServiceController(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await _serviceDal.GetAllService();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(Service service)
        {
            await _serviceDal.CreateService(service);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            await _serviceDal.DeleteService(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(Service service)
        {
            await _serviceDal.UpdateService(service);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var values = await _serviceDal.GetService(id);
            return Ok(values);
        }
    }
}