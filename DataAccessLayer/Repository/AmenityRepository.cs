using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class AmenityRepository : IAmenityDal
    {
        private readonly Context _context;

        public AmenityRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateAmenity(Amenity amenity)
        {
            string query = "insert into Amenity(Title) values(@title)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", amenity.Title);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteAmenity(int id)
        {
            string query = "Delete From Amenity Where AmenityID=@amenityID";
            var parameters = new DynamicParameters();
            parameters.Add("@amenityID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<Amenity>> GetAllAmenity()
        {
            string query = "Select * From Amenity";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Amenity>(query);
                return values.ToList();
            }
        }

        public async Task<Amenity> GetAmenity(int id)
        {
            string query = "Select * From Amenity Where AmenityID=@amenityID";
            var parameters = new DynamicParameters();
            parameters.Add("@amenityID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<Amenity>(query, parameters);
                return values;
            }
        }

        public async Task UpdateAmenity(Amenity amenity)
        {
            string query = "Update Amenity Set Title=@title where AmenityID=@amenityID";
            var parameters = new DynamicParameters();
            parameters.Add("@title", amenity.Title);
            parameters.Add("@amenityID", amenity.AmenityID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}