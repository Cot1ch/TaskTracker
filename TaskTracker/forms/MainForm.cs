using DataAccessLib.classes;
using DataAccessLib.DataBase;
using Microsoft.Extensions.DependencyInjection;
using TaskTracker.forms;

namespace TaskTracker
{
    public partial class MainForm : Form
    {
        private IDataBase? _database;
        public MainForm()
        {
            InitializeComponent();
        }
        public void LoadDgv()
        {
            var services = new ServiceCollection().AddSingleton<IDataBase, DatabaseModel>();

            var serviceProvider = services.BuildServiceProvider();
            _database = serviceProvider.GetService<IDataBase>();
            var tasks = (
                from task in _database.GetTasks()
                select new
                {
                    task.Id,
                    Статус = task.Status ? "Выполнена" : "В работе",
                    Название = task.Title,
                    Исполнитель = task.Executor.Name,
                    Приоритет = task.Priority
                }).ToList();


            this.dgvTasks.DataSource = tasks;
            this.dgvTasks.Columns[0].Visible = false;
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            new InfoTaskForm(null, this, _database).Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.Rows.Count == 0)
            {
                MessageBox.Show("Сначала добавьте задачу");
                return;
            }

            var deletedTask = _database.GetTasks()
                .First(task => task.Id == (Guid)dgvTasks.CurrentRow.Cells[0].Value);

            _database.Delete(deletedTask);
            MessageBox.Show("Удалено");
            LoadDgv();
        }

        private void dgvTasks_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTasks.Rows.Count == 0)
            {
                MessageBox.Show("Сначала добавьте задачу");
                return;
            }
            Taska updateTask = _database.GetTasks()
                .First(task => task.Id == (Guid)dgvTasks.CurrentRow.Cells[0].Value);

            new InfoTaskForm(updateTask, this, _database).Show();
        }
        private void btnExecutorsList_Click(object sender, EventArgs e)
        {
            new ExecutorsList().Show();
        }
    }
}
