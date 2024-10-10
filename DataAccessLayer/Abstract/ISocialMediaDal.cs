
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ISocialMediaDal
    {
        Task<List<SocialMedia>> GetAllSocialMedia();

        Task CreateSocialMedia(SocialMedia socialMedia);

        Task DeleteSocialMedia(int id);

        Task UpdateSocialMedia(SocialMedia socialMedia);

        Task<SocialMedia> GetSocialMedia(int id);
    }
}