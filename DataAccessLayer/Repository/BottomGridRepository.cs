using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class BottomGridRepository : IBottomGridDal
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateBottomGrid(BottomGrid bottomGrid)
        {
            string query = "insert into BottomGrid(Title,Icon,Description) values(@title,@ıcon,@description)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", bottomGrid.Title);
            parameters.Add("@ıcon", bottomGrid.Icon);
            parameters.Add("@description", bottomGrid.Description);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteBottomGrid(int id)
        {
            string query = "Delete From BottomGrid Where BottomGridID=@bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<BottomGrid>> GetAllBottomGrid()
        {
            string query = "Select * From BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<BottomGrid>(query);
                return values.ToList();
            }
        }

        public async Task<BottomGrid> GetBottomGrid(int id)
        {
            string query = "Select * From BottomGrid Where BottomGridID=@bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<BottomGrid>(query, parameters);
                return values;
            }
        }

        public async Task UpdateBottomGrid(BottomGrid bottomGrid)
        {
            string query = "Update BottomGrid Set Title=@title,Icon=@ıcon,Description=@description where BottomGridID=@bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@title", bottomGrid.Title);
            parameters.Add("@ıcon", bottomGrid.Icon);
            parameters.Add("@description", bottomGrid.Description);
            parameters.Add("@bottomGridID", bottomGrid.BottomGridID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}