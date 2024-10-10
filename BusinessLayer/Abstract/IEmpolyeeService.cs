using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IEmpolyeeService
    {
        Task<List<Employee>> TGetAllEmployee();

        Task TCreateEmployee(Employee employee);

        Task TDeleteEmployee(int id);

        Task TUpdateEmployee(Employee employee);

        Task<Employee> TGetEmployee(int id);
    }
}