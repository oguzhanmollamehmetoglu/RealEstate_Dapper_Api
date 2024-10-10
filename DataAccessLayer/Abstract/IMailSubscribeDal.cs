using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IMailSubscribeDal
    {
        Task<List<MailSubscribe>> GetAllMailSubscribe();

        Task CreateMailSubscribe(MailSubscribe mailSubscribe);

        Task DeleteMailSubscribe(int id);

        Task UpdateMailSubscribe(MailSubscribe mailSubscribe);

        Task<MailSubscribe> GetMailSubscribe(int id);
    }
}