using DataAccessLib.classes;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLib.DataBase
{
    public class DatabaseModel : IDataBase
    {
        public DatabaseModel()
        {
            using (var db = new AppDbContext())
            {
                if (!db.Database.EnsureCreated())
                {
                    db.Database.EnsureCreated();
                }
            }
        }
        async public void Add(Taska taska)
        {
            using (var db = new AppDbContext())
            {
                if (!(from task in db.Tasks
                      where task.Id == taska.Id
                      select task).Any())
                {
                    db.Add(taska);
                    db.SaveChanges();
                }
                else
                {
                    var task = db.Tasks.First(t => t.Id == taska.Id);

                    db.Tasks.Remove(task);
                    db.Tasks.Add(taska);
                    await db.SaveChangesAsync();
                }
            }

        }
        async public void Delete(Taska taska)
        {
            using (var db = new AppDbContext())
            {
                if ((from task in db.Tasks
                     where task.Id == taska.Id
                     select task).Any())
                {
                    db.Remove(taska);
                    await db.SaveChangesAsync();
                }
            }
        }
        public DbSet<Taska> GetTasks()
        {
            return new AppDbContext().Tasks;
        }
        public DbSet<Executor> GetExecutors()
        {
            return new AppDbContext().Executors;
        }
    }
}
