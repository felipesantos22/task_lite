using Microsoft.EntityFrameworkCore;
using taskmvc.Data;
using taskmvc.Models;
using taskmvc.Repositories.Interfaces;

namespace taskmvc.Repositories;

public class TaskRepository : ITaskRespository
{
    private readonly AppDbContext _context;

    public TaskRepository(AppDbContext context)
    {
        _context = context;
    }


    public IEnumerable<TaskName> GetAll()
    {
        return _context.TaskNames.ToList();
    }

    public TaskName? GetById(int id)
    {
        return _context.TaskNames.Find(id);
    }

    public void Add(TaskName taskName)
    {
        _context.TaskNames.Add(taskName);
    }

    public void Update(TaskName taskName)
    {
        _context.TaskNames.Update(taskName);
    }

    public void Delete(int id)
    {
        var taskName = GetById(id);

        if (taskName != null)
        {
            _context.TaskNames.Remove(taskName);
        }
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}