using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class AddressRepository : IAddressDal
    {
        private readonly Context _context;

        public AddressRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateAddress(Address address)
        {
            string query = "insert into Address(AddressFull,Phone1,Phone2,Email,Location) values(@addressFull,@phone1,@phone2,@email,@location)";
            var parameters = new DynamicParameters();
            parameters.Add("@addressFull", address.AddressFull);
            parameters.Add("@phone1", address.Phone1);
            parameters.Add("@phone2", address.Phone2);
            parameters.Add("@email", address.Email);
            parameters.Add("@location", address.Location);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteAddress(int id)
        {
            string query = "Delete From Address Where AddressID=@addressID";
            var parameters = new DynamicParameters();
            parameters.Add("@addressID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<Address> GetAddress(int id)
        {
            string query = "Select * From Address Where AddressID=@addressID";
            var parameters = new DynamicParameters();
            parameters.Add("@addressID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<Address>(query, parameters);
                return values;
            }
        }

        public async Task<List<Address>> GetAllAddress()
        {
            string query = "Select * From Address";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Address>(query);
                return values.ToList();
            }
        }

        public async Task UpdateAddress(Address address)
        {
            string query = "Update Address Set AddressFull=@addressFull,Phone1=@phone1,Phone2=@phone2,Email=@email,Location=@location where AddressID=@addressID";
            var parameters = new DynamicParameters();
            parameters.Add("@addressFull", address.AddressFull);
            parameters.Add("@phone1", address.Phone1);
            parameters.Add("@phone2", address.Phone2);
            parameters.Add("@email", address.Email);
            parameters.Add("@location", address.Location);
            parameters.Add("@addressID", address.AddressID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}