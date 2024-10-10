namespace DataAccessLayer.Abstract
{
    public interface IStatisticDal
    {
        int PropertyCountByEmployeeId(int id);
        int PropertyCountByStatusTrue(int id);
        int PropertyCountByStatusFalse(int id);
        int AllPropertyCount();
    }
}