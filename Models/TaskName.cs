using System.ComponentModel.DataAnnotations;

namespace taskmvc.Models;

public class TaskName
{
    public int Id { get; set; }
    
    [Required]
    public string? Name { get; set; }
}