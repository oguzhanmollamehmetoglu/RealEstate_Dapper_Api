using DataTransferObjectLayer.Dtos.EstateAgentDtos;

namespace DataAccessLayer.Abstract
{
    public interface ILastPropertyDal
    {
        Task<List<ResultDashboardLastPropertyDto>> GetLastFivePropertyAsync(int id);
    }
}