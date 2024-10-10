namespace BusinessLayer.Abstract
{
    public interface IStatisticsService
    {
        int TCategoryCount();
        int TActiveCategoryCount();
        int TPassiveCategoryCount();
        int TPropertyCount();
        int TApartmentCount();
        string TEmployeeNameByMaxPropertyCount();
        string TCategoryNameByMaxPropertyCount();
        decimal TAveragePropertyPriceByRent();
        decimal TAveragePropertyPriceBySale();
        string TCityNameByMaxPropertyCount();
        int TDifferehtCityCount();
        decimal TLastPropertyPrice();
        string TNewestBuildingYear();
        string TOldestBuildingYear();
        int TActiveEmployeeCount();
        int TAverageRoomCount();
    }
}