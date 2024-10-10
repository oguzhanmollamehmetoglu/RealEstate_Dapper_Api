using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class MailSubscribeRepository : IMailSubscribeDal
    {
        private readonly Context _context;

        public MailSubscribeRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateMailSubscribe(MailSubscribe mailSubscribe)
        {
            string query = "insert into MailSubscribe(Email) values(@email)";
            var parameters = new DynamicParameters();
            parameters.Add("@email", mailSubscribe.Email);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteMailSubscribe(int id)
        {
            string query = "Delete From MailSubscribe Where MailID=@mailID";
            var parameters = new DynamicParameters();
            parameters.Add("@mailID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<MailSubscribe>> GetAllMailSubscribe()
        {
            string query = "Select * From MailSubscribe";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<MailSubscribe>(query);
                return values.ToList();
            }
        }

        public async Task<MailSubscribe> GetMailSubscribe(int id)
        {
            string query = "Select * From MailSubscribe Where MailID=@mailID";
            var parameters = new DynamicParameters();
            parameters.Add("@mailID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<MailSubscribe>(query, parameters);
                return values;
            }
        }

        public async Task UpdateMailSubscribe(MailSubscribe mailSubscribe)
        {
            string query = "Update MailSubscribe Set Email=@email where MailID=@mailID";
            var parameters = new DynamicParameters();
            parameters.Add("@email", mailSubscribe.Email);
            parameters.Add("@mailID", mailSubscribe.MailID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}