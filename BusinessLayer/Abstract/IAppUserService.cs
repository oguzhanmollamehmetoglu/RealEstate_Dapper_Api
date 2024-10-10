using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IAppUserService
    {
        Task<AppUser> TGetAppUserByPropertyId(int id);
    }
}