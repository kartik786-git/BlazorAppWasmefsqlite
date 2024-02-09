using Microsoft.EntityFrameworkCore;

namespace BlazorAppWasmefsqlite.Data
{
    public class TaskDBContext : DbContext
    {
        public TaskDBContext(DbContextOptions<TaskDBContext> contextOptions )
            :base( contextOptions )
        {
            
        }

        public DbSet<MyTask> Tasks { get; set; }
    }
}
