using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class StatisticsManager : IStatisticsService
    {
        private readonly IStatisticsDal _statisticsDal;

        public StatisticsManager(IStatisticsDal statisticsDal)
        {
            _statisticsDal = statisticsDal;
        }

        public int TActiveCategoryCount()
        {
            return _statisticsDal.ActiveCategoryCount();
        }

        public int TActiveEmployeeCount()
        {
            return _statisticsDal.ActiveEmployeeCount();
        }

        public int TApartmentCount()
        {
            return _statisticsDal.ApartmentCount();
        }

        public decimal TAveragePropertyPriceByRent()
        {
            return _statisticsDal.AveragePropertyPriceByRent();
        }

        public decimal TAveragePropertyPriceBySale()
        {
            return _statisticsDal.AveragePropertyPriceBySale();
        }

        public int TAverageRoomCount()
        {
            return _statisticsDal.AverageRoomCount();
        }

        public int TCategoryCount()
        {
            return _statisticsDal.CategoryCount();
        }

        public string TCategoryNameByMaxPropertyCount()
        {
            return _statisticsDal.CategoryNameByMaxPropertyCount();
        }

        public string TCityNameByMaxPropertyCount()
        {
            return _statisticsDal.CityNameByMaxPropertyCount();
        }

        public int TDifferehtCityCount()
        {
            return _statisticsDal.DifferehtCityCount();
        }

        public string TEmployeeNameByMaxPropertyCount()
        {
            return _statisticsDal.EmployeeNameByMaxPropertyCount();
        }

        public decimal TLastPropertyPrice()
        {
            return _statisticsDal.LastPropertyPrice();
        }

        public string TNewestBuildingYear()
        {
            return _statisticsDal.NewestBuildingYear();
        }

        public string TOldestBuildingYear()
        {
            return _statisticsDal.OldestBuildingYear();
        }

        public int TPassiveCategoryCount()
        {
            return _statisticsDal.PassiveCategoryCount();
        }

        public int TPropertyCount()
        {
            return _statisticsDal.PropertyCount();
        }
    }
}