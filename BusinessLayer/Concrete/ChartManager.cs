using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataTransferObjectLayer.Dtos.EstateAgentDtos;

namespace BusinessLayer.Concrete
{
    public class ChartManager : IChartService
    {
        private readonly IChartDal _chartDal;

        public ChartManager(IChartDal chartDal)
        {
            _chartDal = chartDal;
        }

        public async Task<List<ResultEstateAgentDashboardChartDto>> TGetFiveCityForChart()
        {
            return await _chartDal.GetFiveCityForChart();
        }
    }
}