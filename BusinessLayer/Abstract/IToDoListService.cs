using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IToDoListService
    {
        Task<List<ToDoList>> TGetAllToDoList();

        Task TCreateToDoList(ToDoList toDoList);

        Task TDeleteToDoList(int id);

        Task TUpdateToDoList(ToDoList toDoList);

        Task<ToDoList> TGetToDoList(int id);

        Task TToDoListStatusChangeToTrue(int id);

        Task TToDoListStatusChangeToFalse(int id);

        Task<List<ToDoList>> TGetToDoListStatusAsyncByTrue();
    }
}