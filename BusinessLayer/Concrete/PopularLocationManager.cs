using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PopularLocationManager : IPopularLocationService
    {
        private readonly IPopularLocationDal _popularLocationDal;

        public PopularLocationManager(IPopularLocationDal popularLocationDal)
        {
            _popularLocationDal = popularLocationDal;
        }

        public async Task TCreatePopularLocation(PopularLocation popularLocation)
        {
            await _popularLocationDal.CreatePopularLocation(popularLocation);
        }

        public async Task TDeletePopularLocation(int id)
        {
            await _popularLocationDal.DeletePopularLocation(id);
        }

        public async Task<List<PopularLocation>> TGetAllPopularLocation()
        {
            return await _popularLocationDal.GetAllPopularLocation();
        }

        public async Task<PopularLocation> TGetPopularLocation(int id)
        {
            return await _popularLocationDal.GetPopularLocation(id);
        }

        public async Task TUpdatePopularLocation(PopularLocation popularLocation)
        {
            await _popularLocationDal.UpdatePopularLocation(popularLocation);
        }
    }
}