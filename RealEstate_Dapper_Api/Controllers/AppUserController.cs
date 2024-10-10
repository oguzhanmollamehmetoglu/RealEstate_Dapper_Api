using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Abstract;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserController(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        [HttpGet]
        public async Task<IActionResult> GetAppUserByPropertyId(int id)
        {
            var values = await _appUserDal.GetAppUserByPropertyId(id);
            return Ok(values);
        }
    }
}