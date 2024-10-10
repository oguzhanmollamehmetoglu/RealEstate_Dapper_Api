using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentDashboardLastPropertyController : ControllerBase
    {
        private readonly ILastPropertyDal _lastPropertyDal;

        public EstateAgentDashboardLastPropertyController(ILastPropertyDal lastPropertyDal)
        {
            _lastPropertyDal = lastPropertyDal;
        }

        [HttpGet("GetLastFivePropertyAsync")]
        public async Task<IActionResult> GetLastFivePropertyAsync(int id)
        {
            var values = await _lastPropertyDal.GetLastFivePropertyAsync(id);
            return Ok(values);
        }
    }
}