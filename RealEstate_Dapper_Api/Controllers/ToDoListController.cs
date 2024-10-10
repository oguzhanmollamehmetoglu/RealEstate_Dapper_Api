using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IToDoListDal _toDoListDal;

        public ToDoListController(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        [HttpGet]
        public async Task<IActionResult> ToDoList()
        {
            var values = await _toDoListDal.GetAllToDoList();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateToDoList(ToDoList toDoList)
        {
            await _toDoListDal.CreateToDoList(toDoList);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDoList(int id)
        {
            await _toDoListDal.DeleteToDoList(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateToDoList(ToDoList toDoList)
        {
            await _toDoListDal.UpdateToDoList(toDoList);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetToDoList(int id)
        {
            var values = await _toDoListDal.GetToDoList(id);
            return Ok(values);
        }

        [HttpGet("ToDoListStatusChangeToTrue/{id}")]
        public async Task<IActionResult> ToDoListStatusChangeToTrue(int id)
        {
            await _toDoListDal.ToDoListStatusChangeToTrue(id);
            return Ok("Durumu Güncellendi");
        }

        [HttpGet("ToDoListStatusChangeToFalse/{id}")]
        public async Task<IActionResult> ToDoListStatusChangeToFalse(int id)
        {
            await _toDoListDal.ToDoListStatusChangeToFalse(id);
            return Ok("Durumu Güncellendi");
        }

        [HttpGet("GetToDoListStatusAsyncByTrue")]
        public async Task<IActionResult> GetToDoListStatusAsyncByTrue()
        {
            var values = await _toDoListDal.GetToDoListStatusAsyncByTrue();
            return Ok(values);
        }
    }
}