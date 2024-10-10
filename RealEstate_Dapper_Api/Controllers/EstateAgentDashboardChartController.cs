using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentDashboardChartController : ControllerBase
    {
        private readonly IChartDal _chartDal;

        public EstateAgentDashboardChartController(IChartDal chartDal)
        {
            _chartDal = chartDal;
        }

        [HttpGet]
        public async Task<IActionResult> GetFiveCityForChart()
        {
            return Ok(await _chartDal.GetFiveCityForChart());
        }
    }
}