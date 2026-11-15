using taskmvc.Models;

namespace taskmvc.Repositories.Interfaces;

public interface ITaskRespository
{
    IEnumerable<TaskName> GetAll();

    TaskName? GetById(int id);

    void Add(TaskName taskName);

    void Update(TaskName taskName);

    void Delete(int id);

    void Save();
}