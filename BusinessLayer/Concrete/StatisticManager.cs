using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class StatisticManager : IStatisticService
    {
        private readonly IStatisticDal _statisticDal;

        public StatisticManager(IStatisticDal statisticDal)
        {
            _statisticDal = statisticDal;
        }

        public int TAllPropertyCount()
        {
            return _statisticDal.AllPropertyCount();
        }

        public int TPropertyCountByEmployeeId(int id)
        {
            return _statisticDal.PropertyCountByEmployeeId(id);
        }

        public int TPropertyCountByStatusFalse(int id)
        {
            return _statisticDal.PropertyCountByStatusFalse(id);
        }

        public int TPropertyCountByStatusTrue(int id)
        {
            return _statisticDal.PropertyCountByStatusTrue(id);
        }
    }
}