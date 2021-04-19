using Microsoft.EntityFrameworkCore;

namespace TaskManagerPrototype.Models
{
    public class TasksDbContext: DbContext
    {
        public TasksDbContext(DbContextOptions<TasksDbContext> options): base(options)
        {
            
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}