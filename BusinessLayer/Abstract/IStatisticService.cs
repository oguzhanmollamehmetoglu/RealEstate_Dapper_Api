namespace BusinessLayer.Abstract
{
    public interface IStatisticService
    {
        int TPropertyCountByEmployeeId(int id);
        int TPropertyCountByStatusTrue(int id);
        int TPropertyCountByStatusFalse(int id);
        int TAllPropertyCount();
    }
}