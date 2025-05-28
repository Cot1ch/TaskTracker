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
            dgvTasks = new System.Windows.Forms.DataGridView();
            btnAddTask = new System.Windows.Forms.Button();
            btnDeleteTask = new System.Windows.Forms.Button();
            lblTasks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.AllowUserToDeleteRows = false;
            dgvTasks.AllowUserToResizeColumns = false;
            dgvTasks.AllowUserToResizeRows = false;
            dgvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new System.Drawing.Point(12, 68);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.Size = new System.Drawing.Size(597, 373);
            dgvTasks.TabIndex = 0;
            dgvTasks.DoubleClick += dgvTasks_DoubleClick;
            // 
            // btnAddTask
            // 
            btnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnAddTask.Location = new System.Drawing.Point(620, 12);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new System.Drawing.Size(150, 50);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Добавить задачу";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnDeleteTask.Location = new System.Drawing.Point(620, 68);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new System.Drawing.Size(150, 50);
            btnDeleteTask.TabIndex = 2;
            btnDeleteTask.Text = "Удалить задачу";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // lblTasks
            // 
            lblTasks.AutoSize = true;
            lblTasks.Location = new System.Drawing.Point(12, 27);
            lblTasks.Name = "lblTasks";
            lblTasks.Size = new System.Drawing.Size(92, 20);
            lblTasks.TabIndex = 3;
            lblTasks.Text = "Мои задачи";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(782, 453);
            Controls.Add(lblTasks);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnAddTask);
            Controls.Add(dgvTasks);
            MinimumSize = new System.Drawing.Size(800, 500);
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
    }
}
