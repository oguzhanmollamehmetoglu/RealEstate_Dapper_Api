using DataTransferObjectLayer.Dtos.EstateAgentDtos;

namespace BusinessLayer.Abstract
{
    public interface IChartService
    {
        Task<List<ResultEstateAgentDashboardChartDto>> TGetFiveCityForChart();
    }
}