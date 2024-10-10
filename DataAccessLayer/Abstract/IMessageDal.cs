using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDal
    {
        Task<List<Message>> GetInBoxLastThreeMessageListByReceiver(int id);
    }
}