﻿using System.ComponentModel.DataAnnotations;
using DataAccessLib.classes;
using DataAccessLib.DataBase;
using Microsoft.Extensions.DependencyInjection;

namespace TaskTracker
{
    public partial class InfoTaskForm : Form
    {
        private Taska? _taska;
        private readonly MainForm _mainform;
        private readonly IDataBase _dataBase;
        public InfoTaskForm(Taska task, MainForm mainForm, IDataBase dataBase)
        {
            InitializeComponent();
            this._taska = task;
            this._mainform = mainForm;
            this._dataBase = dataBase;
            foreach (var executor in _dataBase.GetExecutors())
            {
                this.comboBoxExecutor.Items.Add(executor.Name);
            }
        }
        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            if (!(_taska is null))
            {
                this.Name = "Редактирование";
                this.buttonSave.Text = "Сохранить";
                this.textBoxName.Text = _taska.Title;
                this.textBoxDescription.Text = _taska.Description;
                this.comboBoxExecutor.Text = _dataBase.GetExecutors()
                    .First(executor => executor.Id == _taska.ExecutorId).Name;
                this.dateTimePicker.Value = _taska.DeadLine;
                this.comboBoxPriority.Text = _taska.Priority;
                this.checkBoxStatus.Checked = _taska.Status;
            }
            else
            {
                this.Name = "Добавление";
                this.buttonSave.Text = "Добавить задачу";
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_taska is null)
            {
                _taska = new Taska();
            }
            _taska.Title = this.textBoxName.Text;
            _taska.Description = this.textBoxDescription.Text;
            _taska.Executor = _dataBase.GetExecutors()
                .First(executor => executor.Name == this.comboBoxExecutor.Text);
            _taska.DeadLine = this.dateTimePicker.Value;
            _taska.Priority = this.comboBoxPriority.Text;
            _taska.Status = this.checkBoxStatus.Checked;


            if (TryValidate(_taska))
            {
                var services = new ServiceCollection().AddTransient<IDataBase, DatabaseModel>();

                var serviceProvider = services.BuildServiceProvider();
                IDataBase? database = serviceProvider.GetService<IDataBase>();
                database.Add(_taska);

                MessageBox.Show("Сохранено");
                _mainform.LoadDgv();
                this.Close();
            }
        }

        private bool TryValidate(Taska taska)
        {
            var context = new ValidationContext(taska);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(taska, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                    return false;
                }
            }
            return true;
        }
    }
}
