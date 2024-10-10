using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsDal _statisticsDal;

        public StatisticsController(IStatisticsDal statisticsDal)
        {
            _statisticsDal = statisticsDal;
        }

        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_statisticsDal.ActiveCategoryCount());
        }

        [HttpGet("ActiveEmployeeCount")]
        public IActionResult ActiveEmployeeCount()
        {
            return Ok(_statisticsDal.ActiveEmployeeCount());
        }

        [HttpGet("ApartmentCount")]
        public IActionResult ApartmentCount()
        {
            return Ok(_statisticsDal.ApartmentCount());
        }

        [HttpGet("AveragePropertyPriceByRent")]
        public IActionResult AveragePropertyPriceByRent()
        {
            return Ok(_statisticsDal.AveragePropertyPriceByRent());
        }

        [HttpGet("AveragePropertyPriceBySale")]
        public IActionResult AveragePropertyPriceBySale()
        {
            return Ok(_statisticsDal.AveragePropertyPriceBySale());
        }

        [HttpGet("AverageRoomCount")]
        public IActionResult AverageRoomCount()
        {
            return Ok(_statisticsDal.AverageRoomCount());
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_statisticsDal.CategoryCount());
        }

        [HttpGet("CategoryNameByMaxPropertyCount")]
        public IActionResult CategoryNameByMaxPropertyCount()
        {
            return Ok(_statisticsDal.CategoryNameByMaxPropertyCount());
        }

        [HttpGet("CityNameByMaxPropertyCount")]
        public IActionResult CityNameByMaxPropertyCount()
        {
            return Ok(_statisticsDal.CityNameByMaxPropertyCount());
        }

        [HttpGet("DifferehtCityCount")]
        public IActionResult DifferehtCityCount()
        {
            return Ok(_statisticsDal.DifferehtCityCount());
        }

        [HttpGet("EmployeeNameByMaxPropertyCount")]
        public IActionResult EmployeeNameByMaxPropertyCount()
        {
            return Ok(_statisticsDal.EmployeeNameByMaxPropertyCount());
        }

        [HttpGet("LastPropertyPrice")]
        public IActionResult LastPropertyPrice()
        {
            return Ok(_statisticsDal.LastPropertyPrice());
        }

        [HttpGet("NewestBuildingYear")]
        public IActionResult NewestBuildingYear()
        {
            return Ok(_statisticsDal.NewestBuildingYear());
        }

        [HttpGet("OldestBuildingYear")]
        public IActionResult OldestBuildingYear()
        {
            return Ok(_statisticsDal.OldestBuildingYear());
        }

        [HttpGet("PassiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            return Ok(_statisticsDal.PassiveCategoryCount());
        }

        [HttpGet("PropertyCount")]
        public IActionResult PropertyCount()
        {
            return Ok(_statisticsDal.PropertyCount());
        }
    }
}