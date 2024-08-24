namespace nt.Domain.Entities
{
    public interface ITaskWriteOnlyRepository
    {
        Task Add(TaskEntity task);
    }
}
