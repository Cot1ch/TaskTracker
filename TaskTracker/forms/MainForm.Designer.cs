namespace TaskTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvTasks = new DataGridView();
            btnAddTask = new Button();
            btnDeleteTask = new Button();
            lblTasks = new Label();
            btnExecutorsList = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.AllowUserToDeleteRows = false;
            dgvTasks.AllowUserToResizeColumns = false;
            dgvTasks.AllowUserToResizeRows = false;
            dgvTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(12, 68);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.Size = new Size(597, 373);
            dgvTasks.TabIndex = 0;
            dgvTasks.DoubleClick += dgvTasks_DoubleClick;
            // 
            // btnAddTask
            // 
            btnAddTask.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddTask.Location = new Point(620, 12);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(150, 50);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Добавить задачу";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteTask.Location = new Point(620, 68);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(150, 50);
            btnDeleteTask.TabIndex = 2;
            btnDeleteTask.Text = "Удалить задачу";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // lblTasks
            // 
            lblTasks.AutoSize = true;
            lblTasks.Location = new Point(12, 27);
            lblTasks.Name = "lblTasks";
            lblTasks.Size = new Size(92, 20);
            lblTasks.TabIndex = 3;
            lblTasks.Text = "Мои задачи";
            // 
            // btnExecotorsList
            // 
            btnExecutorsList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExecutorsList.Location = new Point(620, 124);
            btnExecutorsList.Name = "btnExecotorsList";
            btnExecutorsList.Size = new Size(150, 50);
            btnExecutorsList.TabIndex = 4;
            btnExecutorsList.Text = "Исполнители";
            btnExecutorsList.UseVisualStyleBackColor = true;
            btnExecutorsList.Click += this.btnExecutorsList_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(btnExecutorsList);
            Controls.Add(lblTasks);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnAddTask);
            Controls.Add(dgvTasks);
            MinimumSize = new Size(800, 500);
            Name = "MainForm";
            Text = "Мои задачи";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTasks;
        private Button btnAddTask;
        private Button btnDeleteTask;
        private Label lblTasks;
        private Button btnExecutorsList;
    }
}
