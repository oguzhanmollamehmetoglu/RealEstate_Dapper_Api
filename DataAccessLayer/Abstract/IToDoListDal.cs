using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IToDoListDal
    {
        Task<List<ToDoList>> GetAllToDoList();

        Task CreateToDoList(ToDoList toDoList);

        Task DeleteToDoList(int id);

        Task UpdateToDoList(ToDoList toDoList);

        Task<ToDoList> GetToDoList(int id);

        Task ToDoListStatusChangeToTrue(int id);

        Task ToDoListStatusChangeToFalse(int id);

        Task<List<ToDoList>> GetToDoListStatusAsyncByTrue();
    }
}