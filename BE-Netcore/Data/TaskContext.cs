using Microsoft.EntityFrameworkCore;

namespace BE_Netcore.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext (DbContextOptions<TaskContext> options)
: base(options)
{
        }

        public DbSet<BE_Netcore.Models.Task> Task { get; set; }
    }
}
