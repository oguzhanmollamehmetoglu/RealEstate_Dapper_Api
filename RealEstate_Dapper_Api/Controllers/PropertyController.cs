using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyDal _propertyDal;

        public PropertyController(IPropertyDal propertyDal)
        {
            _propertyDal = propertyDal;
        }

        [HttpGet]
        public async Task<IActionResult> PropertyList()
        {
            var values = await _propertyDal.GetAllPropertyAsync();
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            await _propertyDal.DeleteProperty(id);
            return Ok("Kayıt başarılı bir şekilde silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProperty(int id)
        {
            var values = await _propertyDal.GetProperty(id);
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProperty(Property property)
        {
            await _propertyDal.UpdateProperty(property);
            return Ok("Kayıt başarılı bir şekilde güncellendi.");
        }

        [HttpGet("LastFivePropertyList")]
        public async Task<IActionResult> LastFivePropertyList()
        {
            var values = await _propertyDal.GetLastFivePropertyAsync();
            return Ok(values);
        }

        [HttpGet("GetLastThreePropertyList")]
        public async Task<IActionResult> GetLastThreePropertyList()
        {
            var values = await _propertyDal.GetLastThreePropertyAsync();
            return Ok(values);
        }

        [HttpGet("PropertyListWithCategoryStatusByTrue")]
        public async Task<IActionResult> PropertyListWithCategoryStatusByTrue()
        {
            var values = await _propertyDal.GetResultPropertyWithCategoryStatusByTrueAsync();
            return Ok(values);
        }

        [HttpGet("PropertyListWithCategory")]
        public async Task<IActionResult> PropertyListWithCategory()
        {
            var values = await _propertyDal.GetResultPropertyWithCategoryAsync();
            return Ok(values);
        }

        [HttpGet("GetPropertyByDealOfTheDayTrueWithCategoryAsync")]
        public async Task<IActionResult> GetPropertyByDealOfTheDayTrueWithCategoryAsync()
        {
            var values = await _propertyDal.GetPropertyByDealOfTheDayTrueWithCategoryAsync();
            return Ok(values);
        }

        [HttpGet("PropertyDealofTheDayStatusChangeToTrue/{id}")]
        public async Task<IActionResult> PropertyDealofTheDayStatusChangeToTrue(int id)
        {
            await _propertyDal.PropertyDealOfTheDayStatusChangeToTrue(id);
            return Ok("İlan Durumu Güncellendi");
        }

        [HttpGet("PropertyDealofTheDayStatusChangeToFalse/{id}")]
        public async Task<IActionResult> PropertyDealofTheDayStatusChangeToFalse(int id)
        {
            await _propertyDal.PropertyDealOfTheDayStatusChangeToFalse(id);
            return Ok("İlan Durumu Güncellendi");
        }

        [HttpGet("PropertyStatusChangeToTrue/{id}")]
        public async Task<IActionResult> PropertyStatusChangeToTrue(int id)
        {
            await _propertyDal.PropertyStatusChangeToTrue(id);
            return Ok("İlan Durumu Güncellendi");
        }

        [HttpGet("PropertyStatusChangeToFalse/{id}")]
        public async Task<IActionResult> PropertyStatusChangeToFalse(int id)
        {
            await _propertyDal.PropertyStatusChangeToFalse(id);
            return Ok("İlan Durumu Güncellendi");
        }

        [HttpGet("AdvertPropertyStatusChangeToFalse/{id}")]
        public async Task<IActionResult> AdvertPropertyStatusChangeToFalse(int id)
        {
            await _propertyDal.AdvertPropertyStatusChangeToFalse(id);
            return Ok("İlan Durumu Güncellendi");
        }

        [HttpGet("PropertyAdvertsListByAppUserByTrue")]
        public async Task<IActionResult> PropertyAdvertsListByAppUserByTrue(int id)
        {
            var values = await _propertyDal.GetPropertyAdvertListByAppUserAsyncByTrue(id);
            return Ok(values);
        }

        [HttpGet("PropertyAdvertsListByAppUserByFalse")]
        public async Task<IActionResult> PropertyAdvertsListByAppUserByFalse(int id)
        {
            var values = await _propertyDal.GetPropertyAdvertListByAppUserAsyncByFalse(id);
            return Ok(values);
        }

        [HttpGet("PropertyAdvertsListByAppUserByStatusFalse")]
        public async Task<IActionResult> PropertyAdvertsListByAppUserByStatusFalse(int id)
        {
            var values = await _propertyDal.GetPropertyAdvertListByAppUserAsyncByStatusFalse(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProperty(Property property)
        {
            await _propertyDal.CreateProperty(property);
            return Ok("İlan başarıyla eklendi");
        }

        [HttpGet("GetPropertyByPropertyId")]
        public async Task<IActionResult> GetPropertyByPropertyId(int id)
        {
            var values = await _propertyDal.GetPropertyByPropertyId(id);
            return Ok(values);
        }

        [HttpGet("GetPropertyWithSearchListAsync")]
        public async Task<IActionResult> GetPropertyWithSearchListAsync(string searchKeyValue, int propertyCategoryId, string city)
        {
            var values = await _propertyDal.GetPropertyWithSearchListAsync(searchKeyValue,propertyCategoryId,city);
            return Ok(values);
        }
    }
}