using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataTransferObjectLayer.Dtos.EstateAgentDtos;

namespace DataAccessLayer.Repository.EstateAgentRepository.DashboardRepository.LastPropertyRepository
{
    public class LastPropertyRepository : ILastPropertyDal
    {
        private readonly Context _context;

        public LastPropertyRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultDashboardLastPropertyDto>> GetLastFivePropertyAsync(int id)
        {
            string query = "Select Top(5) PropertyID,Title,SlugUrl,Coverİmage,Price,City,District,PropertyCategory,CategoryName,AdvertisementDate From Property Inner Join Category On Property.PropertyCategory=Category.CategoryID Where AppUserID=@appUserID and PropertyStatus=1 Order By PropertyID Desc";
            var parameters = new DynamicParameters();
            parameters.Add("@appUserID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultDashboardLastPropertyDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}