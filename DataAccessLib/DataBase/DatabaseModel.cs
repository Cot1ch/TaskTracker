using DataAccessLib.classes;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLib.DataBase
{
    public class DatabaseModel : IDataBase
    {
        public DatabaseModel()
        {
            using (var db = new AppDbContextSQLite())
            {

                if (!db.Database.EnsureCreated())
                {
                    db.Database.EnsureCreated();
                }
            }
        }
        async public void Add(Taska taska)
        {
            using (var db = new AppDbContextSQLite())
            {
                if (!(from task in db.Tasks
                      where task.Id == taska.Id
                      && task.Title == taska.Title
                      && task.Executor == taska.Executor
                      select task).Any())
                {
                    db.Entry(taska.Executor).State = EntityState.Unchanged;
                    db.Tasks.Add(taska);
                    await db.SaveChangesAsync();
                }
                else
                {
                    var task = db.Tasks.First(t => t.Id == taska.Id);

                    db.Entry(taska.Executor).State = EntityState.Unchanged;
                    db.Tasks.Remove(task);
                    db.Tasks.Add(taska);
                    await db.SaveChangesAsync();
                }
            }
        }
        async public void Add(Executor executor)
        {
            using (var db = new AppDbContextSQLite())
            {
                if (!(from execut in db.Executors
                      where execut.Id == executor.Id
                      select execut).Any())
                {
                    db.Executors.Add(executor);
                    await db.SaveChangesAsync();
                }
            }
        }
        async public void Delete(Taska taska)
        {
            using (var db = new AppDbContextSQLite())
            {
                if ((from task in db.Tasks
                     where task.Id == taska.Id
                     select task).Any())
                {
                    db.Tasks.Remove(taska);
                    await db.SaveChangesAsync();
                }
            }
        }
        async public void Delete(Executor executor)
        {
            using (var db = new AppDbContextSQLite())
            {
                if ((from execut in db.Executors
                     where execut.Id == executor.Id
                     select execut).Any())
                {
                    db.Executors.Remove(executor);
                    await db.SaveChangesAsync();
                }
            }
        }
        public DbSet<Taska> GetTasks()
        {
            return new AppDbContextSQLite().Tasks;
        }
        public DbSet<Executor> GetExecutors()
        {
            return new AppDbContextSQLite().Executors;
        }
    }
}
