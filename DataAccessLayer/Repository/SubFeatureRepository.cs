using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class SubFeatureRepository : ISubFeatureDal
    {
        private readonly Context _context;

        public SubFeatureRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateSubFeature(SubFeature subFeature)
        {
            string query = "insert into SubFeature(Icon,TopTitle,MainTitle,Description) values(@ıcon,@topTitle,@mainTitle,@description)";
            var parameters = new DynamicParameters();
            parameters.Add("@ıcon", subFeature.Icon);
            parameters.Add("@topTitle", subFeature.TopTitle);
            parameters.Add("@mainTitle", subFeature.MainTitle);
            parameters.Add("@description", subFeature.Description);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteSubFeature(int id)
        {
            string query = "Delete From SubFeature Where SubFeatureID=@subFeatureID";
            var parameters = new DynamicParameters();
            parameters.Add("@subFeatureID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<SubFeature>> GetAllSubFeature()
        {
            string query = "Select * From SubFeature";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<SubFeature>(query);
                return values.ToList();
            }
        }

        public async Task<SubFeature> GetSubFeature(int id)
        {
            string query = "Select * From SubFeature Where SubFeatureID=@subFeatureID";
            var parameters = new DynamicParameters();
            parameters.Add("@subFeatureID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<SubFeature>(query, parameters);
                return values;
            }
        }

        public async Task UpdateSubFeature(SubFeature subFeature)
        {
            string query = "Update SubFeature Set Icon=@ıcon,TopTitle=@topTitle,MainTitle=@mainTitle,Description=@description where SubFeatureID=@subFeatureID";
            var parameters = new DynamicParameters();
            parameters.Add("@ıcon", subFeature.Icon);
            parameters.Add("@topTitle", subFeature.TopTitle);
            parameters.Add("@mainTitle", subFeature.MainTitle);
            parameters.Add("@description", subFeature.Description);
            parameters.Add("@subFeatureID", subFeature.SubFeatureID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}