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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            dgvTasks.BackgroundColor = Color.FromArgb(3, 30, 54);
            dgvTasks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(3, 30, 54);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(154, 188, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(154, 188, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(3, 30, 54);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(3, 30, 54);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(154, 188, 224);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(154, 188, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(3, 30, 54);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTasks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTasks.EnableHeadersVisualStyles = false;
            dgvTasks.GridColor = Color.FromArgb(154, 188, 224);
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
            btnAddTask.BackColor = Color.FromArgb(154, 188, 224);
            btnAddTask.FlatAppearance.BorderSize = 0;
            btnAddTask.FlatStyle = FlatStyle.Popup;
            btnAddTask.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddTask.ForeColor = Color.FromArgb(3, 30, 54);
            btnAddTask.Location = new Point(620, 12);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(150, 50);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Добавить задачу";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteTask.BackColor = Color.FromArgb(154, 188, 224);
            btnDeleteTask.FlatStyle = FlatStyle.Popup;
            btnDeleteTask.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDeleteTask.ForeColor = Color.FromArgb(3, 30, 54);
            btnDeleteTask.Location = new Point(620, 68);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(150, 50);
            btnDeleteTask.TabIndex = 2;
            btnDeleteTask.Text = "Удалить задачу";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // lblTasks
            // 
            lblTasks.AutoSize = true;
            lblTasks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTasks.ForeColor = Color.FromArgb(154, 188, 224);
            lblTasks.Location = new Point(12, 27);
            lblTasks.Name = "lblTasks";
            lblTasks.Size = new Size(95, 20);
            lblTasks.TabIndex = 3;
            lblTasks.Text = "Мои задачи";
            // 
            // btnExecutorsList
            // 
            btnExecutorsList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExecutorsList.BackColor = Color.FromArgb(154, 188, 224);
            btnExecutorsList.FlatStyle = FlatStyle.Flat;
            btnExecutorsList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnExecutorsList.ForeColor = Color.FromArgb(3, 30, 54);
            btnExecutorsList.Location = new Point(620, 124);
            btnExecutorsList.Name = "btnExecutorsList";
            btnExecutorsList.Size = new Size(150, 50);
            btnExecutorsList.TabIndex = 4;
            btnExecutorsList.Text = "Исполнители";
            btnExecutorsList.UseVisualStyleBackColor = false;
            btnExecutorsList.Click += btnExecutorsList_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 30, 54);
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
