using nt.Domain.Entities;

namespace nt.Infrastructure.DataAccess.Repositories
{
    public class TaskEntityRepository : ITaskReadOnlyRepository, ITaskWriteOnlyRepository
    {
        private readonly NiceTaskDbContext _dbContext;

        public TaskEntityRepository(NiceTaskDbContext dbContext) => _dbContext = dbContext;

        public async Task Add(TaskEntity task) => await _dbContext.AddAsync(task);
        public void Update(TaskEntity task) => _dbContext.Update(task);
        public async Task Delete(long id)
        {
            var task = await _dbContext.Tasks.FindAsync(id);

            _dbContext.Tasks.Remove(task!);
        }

        public Task<List<TaskEntity>> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public Task<TaskEntity> GetTaskByDueDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<TaskEntity> GetTaskById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
