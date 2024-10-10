using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMailSubscribeService
    {
        Task<List<MailSubscribe>> TGetAllMailSubscribe();

        Task TCreateMailSubscribe(MailSubscribe mailSubscribe);

        Task TDeleteMailSubscribe(int id);

        Task TUpdateMailSubscribe(MailSubscribe mailSubscribe);

        Task<MailSubscribe> TGetMailSubscribe(int id);
    }
}