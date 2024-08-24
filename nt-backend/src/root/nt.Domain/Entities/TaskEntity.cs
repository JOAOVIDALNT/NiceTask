namespace nt.Domain.Entities
{
    public class TaskEntity : EntityBase
    {
        public string Title { get; set; } = string.Empty;
        public DateTime? DueDate { get; set; } = null;
    }
}
