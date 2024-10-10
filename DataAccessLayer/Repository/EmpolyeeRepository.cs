using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class EmpolyeeRepository : IEmpolyeeDal
    {
        private readonly Context _context;

        public EmpolyeeRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateEmployee(Employee employee)
        {
            string query = "insert into Employee(Name,Title,Mail,PhoneNumber,ImageUrl,Status) values(@name,@title,@mail,@phoneNumber,@ımageUrl,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", employee.Name);
            parameters.Add("@title", employee.Title);
            parameters.Add("@mail", employee.Mail);
            parameters.Add("@phoneNumber", employee.PhoneNumber);
            parameters.Add("@ımageUrl", employee.ImageUrl);
            parameters.Add("@status", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteEmployee(int id)
        {
            string query = "Delete From Employee Where EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            string query = "Select * From Employee";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Employee>(query);
                return values.ToList();
            }
        }

        public async Task<Employee> GetEmployee(int id)
        {
            string query = "Select * From Employee Where EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<Employee>(query, parameters);
                return values;
            }
        }

        public async Task UpdateEmployee(Employee employee)
        {
            string query = "Update Employee Set Name=@name,Title=@title,Mail=@mail,PhoneNumber=@phoneNumber,ImageUrl=@ımageUrl,Status=@status where EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@name", employee.Name);
            parameters.Add("@title", employee.Title);
            parameters.Add("@mail", employee.Mail);
            parameters.Add("@phoneNumber", employee.PhoneNumber);
            parameters.Add("@ımageUrl", employee.ImageUrl);
            parameters.Add("@status", employee.Status);
            parameters.Add("@employeeID", employee.EmployeeID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}