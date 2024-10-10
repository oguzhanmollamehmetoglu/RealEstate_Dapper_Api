using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IAppUserDal
    {
        Task<AppUser> GetAppUserByPropertyId(int id);
    }
}