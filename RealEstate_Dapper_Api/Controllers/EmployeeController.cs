using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmpolyeeDal _empolyeeDal;

        public EmployeeController(IEmpolyeeDal empolyeeDal)
        {
            _empolyeeDal = empolyeeDal;
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _empolyeeDal.GetAllEmployee();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            await _empolyeeDal.CreateEmployee(employee);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await _empolyeeDal.DeleteEmployee(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Employee employee)
        {
            await _empolyeeDal.UpdateEmployee(employee);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var values = await _empolyeeDal.GetEmployee(id);
            return Ok(values);
        }
    }
}