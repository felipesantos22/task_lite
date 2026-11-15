using Microsoft.AspNetCore.Mvc;
using taskmvc.Models;
using taskmvc.Services.Interfaces;

namespace taskmvc.Controllers;

public class TaskController : Controller
{
    private readonly ITaskService _service;

    public TaskController(ITaskService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        var taskNames = _service.GetAll();

        return View(taskNames);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(TaskName taskName)
    {
        if (!ModelState.IsValid)
        {
            return View(taskName);
        }

        _service.Add(taskName);

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var taskName = _service.GetById(id);

        if (taskName == null)
        {
            return NotFound();
        }

        return View(taskName);
    }

    [HttpPost]
    public IActionResult Edit(TaskName taskName)
    {
        if (!ModelState.IsValid)
        {
            return View(taskName);
        }

        _service.Update(taskName);

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var taskName = _service.GetById(id);

        if (taskName == null)
        {
            return NotFound();
        }

        return View(taskName);
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        _service.Delete(id);

        return RedirectToAction(nameof(Index));
    }
}