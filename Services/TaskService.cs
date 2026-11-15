using taskmvc.Models;
using taskmvc.Repositories.Interfaces;
using taskmvc.Services.Interfaces;

namespace taskmvc.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRespository _repository;

    public TaskService(ITaskRespository repository)
    {
        _repository = repository;
    }

    public IEnumerable<TaskName> GetAll()
    {
        return _repository.GetAll();
    }

    public TaskName? GetById(int id)
    {
        return _repository.GetById(id);
    }

    public void Add(TaskName taskName)
    {
        _repository.Add(taskName);
        _repository.Save();
    }

    public void Update(TaskName taskName)
    {
        _repository.Update(taskName);
        _repository.Save();
    }

    public void Delete(int id)
    {
        _repository.Delete(id);
        _repository.Save();
    }
}