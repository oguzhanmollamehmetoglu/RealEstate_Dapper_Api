using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataTransferObjectLayer.Dtos.EstateAgentDtos;

namespace BusinessLayer.Concrete
{
    public class LastPropertyManager : ILastPropertyService
    {
        private readonly ILastPropertyDal _lastPropertyDal;

        public LastPropertyManager(ILastPropertyDal lastPropertyDal)
        {
            _lastPropertyDal = lastPropertyDal;
        }

        public async Task<List<ResultDashboardLastPropertyDto>> TGetLastFivePropertyAsync(int id)
        {
            return await _lastPropertyDal.GetLastFivePropertyAsync(id);
        }
    }
}