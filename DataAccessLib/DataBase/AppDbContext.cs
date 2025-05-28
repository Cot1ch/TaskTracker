using DataAccessLib.classes;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLib.DataBase
{
    public class AppDbContext : DbContext
    {
        public DbSet<Executor> Executors { get; set; }
        public DbSet<Taska> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mytasks.db");
        }
    }
}
