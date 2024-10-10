using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        private readonly IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public async Task TCreateToDoList(ToDoList toDoList)
        {
            await _toDoListDal.CreateToDoList(toDoList);
        }

        public async Task TDeleteToDoList(int id)
        {
            await _toDoListDal.DeleteToDoList(id);
        }

        public async Task<List<ToDoList>> TGetAllToDoList()
        {
            return await _toDoListDal.GetAllToDoList();
        }

        public async Task<ToDoList> TGetToDoList(int id)
        {
            return await _toDoListDal.GetToDoList(id);
        }

        public async Task<List<ToDoList>> TGetToDoListStatusAsyncByTrue()
        {
            return await _toDoListDal.GetToDoListStatusAsyncByTrue();
        }

        public async Task TToDoListStatusChangeToFalse(int id)
        {
            await _toDoListDal.ToDoListStatusChangeToFalse(id);
        }

        public async Task TToDoListStatusChangeToTrue(int id)
        {
            await _toDoListDal.ToDoListStatusChangeToTrue(id);
        }

        public async Task TUpdateToDoList(ToDoList toDoList)
        {
            await _toDoListDal.UpdateToDoList(toDoList);
        }
    }
}