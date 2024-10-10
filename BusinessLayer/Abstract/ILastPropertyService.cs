using DataTransferObjectLayer.Dtos.EstateAgentDtos;

namespace BusinessLayer.Abstract
{
    public interface ILastPropertyService
    {
        Task<List<ResultDashboardLastPropertyDto>> TGetLastFivePropertyAsync(int id);
    }
}