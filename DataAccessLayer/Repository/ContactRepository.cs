using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class ContactRepository : IContactDal
    {
        private readonly Context _context;

        public ContactRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateContact(Contact contact)
        {
            string query = "insert into Contact(Name,Email,Subject,Message,SendDate,ContactStatus) values(@name,@email,@subject,@message,@sendDate,@contactStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", contact.Name);
            parameters.Add("@email", contact.Email);
            parameters.Add("@subject", contact.Subject);
            parameters.Add("@message", contact.Message);
            parameters.Add("@sendDate", contact.SendDate);
            parameters.Add("@contactStatus", contact.ContactStatus);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteContact(int id)
        {
            string query = "Delete From Contact Where ContactID=@contactID";
            var parameters = new DynamicParameters();
            parameters.Add("@contactID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<Contact>> GetAllContact()
        {
            string query = "Select * From Contact";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Contact>(query);
                return values.ToList();
            }
        }

        public async Task<Contact> GetContact(int id)
        {
            string query = "Select * From Contact Where ContactID=@contactID";
            var parameters = new DynamicParameters();
            parameters.Add("@contactID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<Contact>(query, parameters);
                return values;
            }
        }

        public async Task<List<Contact>> GetLastForeContact()
        {
            string query = "Select Top(4) * From Contact order by ContactID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Contact>(query);
                return values.ToList();
            }
        }
    }
}