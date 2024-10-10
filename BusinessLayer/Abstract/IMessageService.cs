using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        Task<List<Message>> TGetInBoxLastThreeMessageListByReceiver(int id);
    }
}