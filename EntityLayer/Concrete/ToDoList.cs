namespace EntityLayer.Concrete
{
    public class ToDoList
    {
        public int ToDoListID { get; set; }

        public string Description { get; set; }

        public bool ToDoListStatus { get; set; }

        public DateTime ToDoListDate { get; set; }
    }
}