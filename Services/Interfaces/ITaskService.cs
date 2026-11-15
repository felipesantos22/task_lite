using taskmvc.Models;

namespace taskmvc.Services.Interfaces

{
    public interface ITaskService
    {
        IEnumerable<TaskName> GetAll();

        TaskName? GetById(int id);

        void Add(TaskName taskName);

        void Update(TaskName taskName);

        void Delete(int id);
    }
}