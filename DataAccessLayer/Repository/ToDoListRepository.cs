using Dapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class ToDoListRepository : IToDoListDal
    {
        private readonly Context _context;

        public ToDoListRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateToDoList(ToDoList toDoList)
        {
            string query = "insert into ToDoList(Description,ToDoListStatus,ToDoListDate) values(@description,@toDoListStatus,@toDoListDate)";
            var parameters = new DynamicParameters();
            parameters.Add("@description", toDoList.Description);
            parameters.Add("@toDoListStatus", toDoList.ToDoListStatus);
            parameters.Add("@toDoListDate", toDoList.ToDoListDate);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteToDoList(int id)
        {
            string query = "Delete From ToDoList Where ToDoListID=@toDoListID";
            var parameters = new DynamicParameters();
            parameters.Add("@toDoListID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ToDoList>> GetAllToDoList()
        {
            string query = "Select * From ToDoList";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ToDoList>(query);
                return values.ToList();
            }
        }

        public async Task<ToDoList> GetToDoList(int id)
        {
            string query = "Select * From ToDoList Where ToDoListID=@toDoListID";
            var parameters = new DynamicParameters();
            parameters.Add("@toDoListID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<ToDoList>(query, parameters);
                return values;
            }
        }

        public async Task<List<ToDoList>> GetToDoListStatusAsyncByTrue()
        {
            string query = "SELECT ToDoListDate FROM ToDoList WHERE ToDoListStatus=1";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ToDoList>(query);
                return values.ToList();
            }
        }

        public async Task ToDoListStatusChangeToFalse(int id)
        {
            string query = "Update ToDoList Set ToDoListStatus=0 where ToDoListID=@toDoListID";
            var parameters = new DynamicParameters();
            parameters.Add("@toDoListID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task ToDoListStatusChangeToTrue(int id)
        {
            string query = "Update ToDoList Set ToDoListStatus=1 where ToDoListID=@toDoListID";
            var parameters = new DynamicParameters();
            parameters.Add("@toDoListID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task UpdateToDoList(ToDoList toDoList)
        {
            string query = "Update ToDoList Set Description=@description,ToDoListStatus=@toDoListStatus,ToDoListDate=@toDoListDate where ToDoListID=@toDoListID";
            var parameters = new DynamicParameters();
            parameters.Add("@description", toDoList.Description);
            parameters.Add("@toDoListStatus", toDoList.ToDoListStatus);
            parameters.Add("@toDoListDate", toDoList.ToDoListDate);
            parameters.Add("@toDoListID", toDoList.ToDoListID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}