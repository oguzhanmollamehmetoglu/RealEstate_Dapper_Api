using DataTransferObjectLayer.Dtos.EstateAgentDtos;

namespace DataAccessLayer.Abstract
{
    public interface IChartDal
    {
        Task<List<ResultEstateAgentDashboardChartDto>> GetFiveCityForChart();
    }
}