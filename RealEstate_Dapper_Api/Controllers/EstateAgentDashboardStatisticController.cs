using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentDashboardStatisticController : ControllerBase
    {
        private readonly IStatisticDal _statisticDal;

        public EstateAgentDashboardStatisticController(IStatisticDal statisticDal)
        {
            _statisticDal = statisticDal;
        }

        [HttpGet("AllPropertyCount")]
        public IActionResult AllPropertyCount()
        {
            return Ok(_statisticDal.AllPropertyCount());
        }
        [HttpGet("PropertyCountByEmployeeId")]
        public IActionResult PropertyCountByEmployeeId(int id)
        {
            return Ok(_statisticDal.PropertyCountByEmployeeId(id));
        }
        [HttpGet("PropertyCountByStatusTrue")]
        public IActionResult PropertyCountByStatusTrue(int id)
        {
            return Ok(_statisticDal.PropertyCountByStatusTrue(id));
        }
        [HttpGet("PropertyCountByStatusFalse")]
        public IActionResult PropertyCountByStatusFalse(int id)
        {
            return Ok(_statisticDal.PropertyCountByStatusFalse(id));
        }
    }
}