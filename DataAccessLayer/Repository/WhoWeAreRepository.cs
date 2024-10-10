using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class WhoWeAreRepository : IWhoWeAreDal
    {
        private readonly Context _context;

        public WhoWeAreRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateWhoWeAreDetail(WhoWeAreDetail whoWeAreDetail)
        {
            string query = "insert into WhoWeAreDetail(Title,Subtitle,Description1,Description2) values(@title,@subtitle,@description1,@description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", whoWeAreDetail.Title);        
            parameters.Add("@subtitle", whoWeAreDetail.Subtitle);
            parameters.Add("@description1", whoWeAreDetail.Description1);
            parameters.Add("@description2", whoWeAreDetail.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteWhoWeAreDetail(int id)
        {
            string query = "Delete From WhoWeAreDetail Where WhoWeAreDetailID=@whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<WhoWeAreDetail>> GetAllWhoWeAreDetail()
        {
            string query = "Select * From WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<WhoWeAreDetail>(query);
                return values.ToList();
            }
        }

        public async Task<WhoWeAreDetail> GetWhoWeAreDetail(int id)
        {
            string query = "Select * From WhoWeAreDetail Where WhoWeAreDetailID=@whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<WhoWeAreDetail>(query, parameters);
                return values;
            }
        }

        public async Task UpdateWhoWeAreDetail(WhoWeAreDetail whoWeAreDetail)
        {
            string query = "Update WhoWeAreDetail Set Title=@title,Subtitle=@subtitle,Description1=@description1,Description2=@description2 where WhoWeAreDetailID=@whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@title", whoWeAreDetail.Title);
            parameters.Add("@subtitle", whoWeAreDetail.Subtitle);
            parameters.Add("@description1", whoWeAreDetail.Description1);
            parameters.Add("@description2", whoWeAreDetail.Description2);
            parameters.Add("@whoWeAreDetailID", whoWeAreDetail.WhoWeAreDetailID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}