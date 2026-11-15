using Microsoft.EntityFrameworkCore;
using taskmvc.Models;
namespace taskmvc.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<TaskName> TaskNames { get; set; }
}