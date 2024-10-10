using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridDal _bottomGridDal;

        public BottomGridsController(IBottomGridDal bottomGridDal)
        {
            _bottomGridDal = bottomGridDal;
        }

        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomGridDal.GetAllBottomGrid();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBottomGrid(BottomGrid bottomGrid)
        {
            await _bottomGridDal.CreateBottomGrid(bottomGrid);
            return Ok("Kayıt başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBottomGrid(int id)
        {
            await _bottomGridDal.DeleteBottomGrid(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBottomGrid(BottomGrid bottomGrid)
        {
            await _bottomGridDal.UpdateBottomGrid(bottomGrid);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottomGrid(int id)
        {
            var values = await _bottomGridDal.GetBottomGrid(id);
            return Ok(values);
        }
    }
}