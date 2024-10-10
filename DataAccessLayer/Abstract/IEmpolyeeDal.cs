using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IEmpolyeeDal
    {
        Task<List<Employee>> GetAllEmployee();

        Task CreateEmployee(Employee employee);

        Task DeleteEmployee(int id);

        Task UpdateEmployee(Employee employee);

        Task<Employee> GetEmployee(int id);
    }
}