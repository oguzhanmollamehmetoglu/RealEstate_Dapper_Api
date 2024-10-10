using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class MessageRepository : IMessageDal
    {
        private readonly Context _context;

        public MessageRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<Message>> GetInBoxLastThreeMessageListByReceiver(int id)
        {
            string query = "Select Top(3) MessageId,Sender,Receiver,Subject,Detail,SendDate,IsRead From Message Inner Join AppUser On Message.Sender=AppUser.UserId Where Receiver=@receiverId Order By MessageId Desc";
            var parameters = new DynamicParameters();
            parameters.Add("@receiverId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Message>(query, parameters);
                return values.ToList();
            }
        }
    }
}