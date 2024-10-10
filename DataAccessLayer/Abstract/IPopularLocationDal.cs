using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IPopularLocationDal
    {
        Task<List<PopularLocation>> GetAllPopularLocation();

        Task CreatePopularLocation(PopularLocation popularLocation);

        Task DeletePopularLocation(int id);

        Task UpdatePopularLocation(PopularLocation popularLocation);

        Task<PopularLocation> GetPopularLocation(int id);
    }
}