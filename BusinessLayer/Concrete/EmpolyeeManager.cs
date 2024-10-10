using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class EmpolyeeManager : IEmpolyeeService
    {
        private readonly IEmpolyeeDal _empolyeeDal;

        public EmpolyeeManager(IEmpolyeeDal empolyeeDal)
        {
            _empolyeeDal = empolyeeDal;
        }

        public async Task TCreateEmployee(Employee employee)
        {
            await _empolyeeDal.CreateEmployee(employee);
        }

        public async Task TDeleteEmployee(int id)
        {
            await _empolyeeDal.DeleteEmployee(id);
        }

        public async Task<List<Employee>> TGetAllEmployee()
        {
            return await _empolyeeDal.GetAllEmployee();
        }

        public async Task<Employee> TGetEmployee(int id)
        {
            return await _empolyeeDal.GetEmployee(id);
        }

        public async Task TUpdateEmployee(Employee employee)
        {
            await _empolyeeDal.UpdateEmployee(employee);
        }
    }
}