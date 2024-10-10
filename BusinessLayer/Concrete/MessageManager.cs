using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public async Task<List<Message>> TGetInBoxLastThreeMessageListByReceiver(int id)
        {
            return await _messageDal.GetInBoxLastThreeMessageListByReceiver(id);
        }
    }
}