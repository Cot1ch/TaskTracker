using DataAccessLib.classes;
using DataAccessLib.DataBase;
using Microsoft.Extensions.DependencyInjection;

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
            var services = new ServiceCollection().AddTransient<IDataBase, DatabaseModel>();

            var serviceProvider = services.BuildServiceProvider();
            _database = serviceProvider.GetService<IDataBase>();
            var tasks = (
                from task in _database.GetTasks()
                select new
                {
                    task.Id,
                    task.Title,
                    task.Executor.Name,
                    task.Priority
                }).ToList();


            this.dgvTasks.DataSource = tasks;
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            new InfoTaskForm(null, this).Show();
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

            new InfoTaskForm(updateTask, this).Show();
        }
    }
}
