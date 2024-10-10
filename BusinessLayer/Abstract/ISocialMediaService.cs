
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ISocialMediaService
    {
        Task<List<SocialMedia>> TGetAllSocialMedia();

        Task TCreateSocialMedia(SocialMedia socialMedia);

        Task TDeleteSocialMedia(int id);

        Task TUpdateSocialMedia(SocialMedia socialMedia);

        Task<SocialMedia> TGetSocialMedia(int id);
    }
}