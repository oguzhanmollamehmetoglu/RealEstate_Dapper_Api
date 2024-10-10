using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class PopularLocationRepository : IPopularLocationDal
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public async Task CreatePopularLocation(PopularLocation popularLocation)
        {
            string query = "insert into PopularLocation(CityName,ImageUrl) values(@cityName,@ımageUrl)";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", popularLocation.CityName);
            parameters.Add("@ımageUrl", popularLocation.ImageUrl);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeletePopularLocation(int id)
        {
            string query = "Delete From PopularLocation Where LocationID=@locationID";
            var parameters = new DynamicParameters();
            parameters.Add("@locationID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<PopularLocation>> GetAllPopularLocation()
        {
            string query = "Select * From PopularLocation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<PopularLocation>(query);
                return values.ToList();
            }
        }

        public async Task<PopularLocation> GetPopularLocation(int id)
        {
            string query = "Select * From PopularLocation Where LocationID=@locationID";
            var parameters = new DynamicParameters();
            parameters.Add("@locationID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<PopularLocation>(query, parameters);
                return values;
            }
        }

        public async Task UpdatePopularLocation(PopularLocation popularLocation)
        {
            string query = "Update PopularLocation Set CityName=@cityName,ImageUrl=@ımageUrl where LocationID=@locationID";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", popularLocation.CityName);
            parameters.Add("@ımageUrl", popularLocation.ImageUrl);
            parameters.Add("@locationID", popularLocation.LocationID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}