using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public async Task TCreateSocialMedia(SocialMedia socialMedia)
        {
            await _socialMediaDal.CreateSocialMedia(socialMedia);
        }

        public async Task TDeleteSocialMedia(int id)
        {
            await _socialMediaDal.DeleteSocialMedia(id);
        }

        public async Task<List<SocialMedia>> TGetAllSocialMedia()
        {
            return await _socialMediaDal.GetAllSocialMedia();
        }

        public async Task<SocialMedia> TGetSocialMedia(int id)
        {
            return await _socialMediaDal.GetSocialMedia(id);
        }

        public async Task TUpdateSocialMedia(SocialMedia socialMedia)
        {
            await _socialMediaDal.UpdateSocialMedia(socialMedia);
        }
    }
}