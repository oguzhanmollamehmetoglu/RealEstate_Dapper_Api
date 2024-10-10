using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IPopularLocationService
    {
        Task<List<PopularLocation>> TGetAllPopularLocation();

        Task TCreatePopularLocation(PopularLocation popularLocation);

        Task TDeletePopularLocation(int id);

        Task TUpdatePopularLocation(PopularLocation popularLocation);

        Task<PopularLocation> TGetPopularLocation(int id);
    }
}