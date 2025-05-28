using DataAccessLib.classes;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLib.DataBase
{
    public interface IDataBase
    {
        public DbSet<Taska> GetTasks();
        public DbSet<Executor> GetExecutors();
        public void Add(Taska task);
        public void Add(Executor executor);
        public void Delete(Taska task);
        public void Delete(Executor executor);
    }
}
