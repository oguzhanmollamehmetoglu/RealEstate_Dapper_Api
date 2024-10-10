using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MailSubscribeManager : IMailSubscribeService
    {
        private readonly IMailSubscribeDal _mailSubscribeDal;

        public MailSubscribeManager(IMailSubscribeDal mailSubscribeDal)
        {
            _mailSubscribeDal = mailSubscribeDal;
        }

        public async Task TCreateMailSubscribe(MailSubscribe mailSubscribe)
        {
            await _mailSubscribeDal.CreateMailSubscribe(mailSubscribe);
        }

        public async Task TDeleteMailSubscribe(int id)
        {
            await _mailSubscribeDal.DeleteMailSubscribe(id);
        }

        public async Task<List<MailSubscribe>> TGetAllMailSubscribe()
        {
            return await _mailSubscribeDal.GetAllMailSubscribe();
        }

        public async Task<MailSubscribe> TGetMailSubscribe(int id)
        {
            return await _mailSubscribeDal.GetMailSubscribe(id);
        }

        public async Task TUpdateMailSubscribe(MailSubscribe mailSubscribe)
        {
            await _mailSubscribeDal.UpdateMailSubscribe(mailSubscribe);
        }
    }
}