namespace DataAccessLayer.Abstract
{
    public interface IStatisticsDal
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
        int PropertyCount();
        int ApartmentCount();
        string EmployeeNameByMaxPropertyCount();
        string CategoryNameByMaxPropertyCount();
        decimal AveragePropertyPriceByRent();
        decimal AveragePropertyPriceBySale();
        string CityNameByMaxPropertyCount();
        int DifferehtCityCount();
        decimal LastPropertyPrice();
        string NewestBuildingYear();
        string OldestBuildingYear();
        int ActiveEmployeeCount();
        int AverageRoomCount();
    }
}