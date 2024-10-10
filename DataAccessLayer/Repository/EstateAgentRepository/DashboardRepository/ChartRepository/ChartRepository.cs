using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataTransferObjectLayer.Dtos.EstateAgentDtos;

namespace DataAccessLayer.Repository.EstateAgentRepository.DashboardRepository.ChartRepository
{
    public class ChartRepository : IChartDal
    {
        private readonly Context _context;

        public ChartRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultEstateAgentDashboardChartDto>> GetFiveCityForChart()
        {
            string query = "Select top(5) City,Count(*) as 'CityCount' From Property Group By City order By CityCount Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEstateAgentDashboardChartDto>(query);
                return values.ToList();
            }
        }
    }
}