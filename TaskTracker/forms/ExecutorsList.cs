using DataAccessLib.classes;
using DataAccessLib.DataBase;
using Microsoft.Extensions.DependencyInjection;

namespace TaskTracker.forms
{
    public partial class ExecutorsList : Form
    {
        private IDataBase? _database;
        public ExecutorsList()
        {
            InitializeComponent();
        }
        private void ExecutorsList_Load(object sender, EventArgs e)
        {
            var services = new ServiceCollection().AddTransient<IDataBase, DatabaseModel>();

            var serviceProvider = services.BuildServiceProvider();
            _database = serviceProvider.GetService<IDataBase>();
           
            LoadListBox();
        }

        private void LoadListBox()
        {
            var executors = (
                from executor in _database.GetExecutors()
                select executor.Name
            ).ToList();

            this.listBoxAllExecutors.Items.Clear();
            foreach (var executor in executors)
            {
                this.listBoxAllExecutors.Items.Add(executor);
            }
        }
        private void btnAddExecutor_Click(object sender, EventArgs e)
        {
            if (this.listBoxAllExecutors.Items.Contains(this.textBoxNewName.Text))
            {
                MessageBox.Show("Исполнитель уже добавлен");
                return;
            }
            var executor = new Executor()
            {
                Name = this.textBoxNewName.Text
            };
            _database.Add(executor);
            LoadListBox();
        }

        private void btnDeleteExecutor_Click(object sender, EventArgs e)
        {
            
            var deletedExecutor = _database.GetExecutors()
                .First(executor => executor.Name == 
                this.listBoxAllExecutors.SelectedItem.ToString());

            _database.Delete(deletedExecutor);
            MessageBox.Show("Удалено");
            LoadListBox();
        }
    }
}
