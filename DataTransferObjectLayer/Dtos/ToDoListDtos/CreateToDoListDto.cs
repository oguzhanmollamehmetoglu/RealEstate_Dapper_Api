namespace DataTransferObjectLayer.Dtos.ToDoListDtos
{
    public class CreateToDoListDto
    {
        public string Description { get; set; }

        public bool ToDoListStatus { get; set; }

        public DateTime ToDoListDate { get; set; }
    }
}