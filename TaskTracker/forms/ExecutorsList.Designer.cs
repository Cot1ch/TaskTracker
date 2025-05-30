namespace TaskTracker.forms
{
    partial class ExecutorsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            listBoxAllExecutors = new ListBox();
            btnAddExecutor = new Button();
            lblNewName = new Label();
            textBoxNewName = new TextBox();
            lblAllExecutors = new Label();
            btnDeleteExecutor = new Button();
            SuspendLayout();
            // 
            // listBoxAllExecutors
            // 
            listBoxAllExecutors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxAllExecutors.BackColor = Color.FromArgb(154, 188, 224);
            listBoxAllExecutors.BorderStyle = BorderStyle.None;
            listBoxAllExecutors.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBoxAllExecutors.ForeColor = Color.FromArgb(3, 30, 54);
            listBoxAllExecutors.FormattingEnabled = true;
            listBoxAllExecutors.Location = new Point(12, 85);
            listBoxAllExecutors.Name = "listBoxAllExecutors";
            listBoxAllExecutors.Size = new Size(358, 200);
            listBoxAllExecutors.TabIndex = 0;
            // 
            // btnAddExecutor
            // 
            btnAddExecutor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddExecutor.BackColor = Color.FromArgb(154, 188, 224);
            btnAddExecutor.FlatStyle = FlatStyle.Flat;
            btnAddExecutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddExecutor.ForeColor = Color.FromArgb(3, 30, 54);
            btnAddExecutor.Location = new Point(220, 9);
            btnAddExecutor.Name = "btnAddExecutor";
            btnAddExecutor.Size = new Size(150, 50);
            btnAddExecutor.TabIndex = 1;
            btnAddExecutor.Text = "Добавить";
            btnAddExecutor.UseVisualStyleBackColor = false;
            btnAddExecutor.Click += btnAddExecutor_Click;
            // 
            // lblNewName
            // 
            lblNewName.AutoSize = true;
            lblNewName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblNewName.ForeColor = Color.FromArgb(154, 188, 224);
            lblNewName.Location = new Point(12, 9);
            lblNewName.Name = "lblNewName";
            lblNewName.Size = new Size(177, 20);
            lblNewName.TabIndex = 2;
            lblNewName.Text = "Добавьте исполнителя";
            // 
            // textBoxNewName
            // 
            textBoxNewName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNewName.BackColor = Color.FromArgb(154, 188, 224);
            textBoxNewName.BorderStyle = BorderStyle.None;
            textBoxNewName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxNewName.ForeColor = Color.FromArgb(3, 30, 54);
            textBoxNewName.Location = new Point(12, 39);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new Size(202, 20);
            textBoxNewName.TabIndex = 3;
            // 
            // lblAllExecutors
            // 
            lblAllExecutors.AutoSize = true;
            lblAllExecutors.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblAllExecutors.ForeColor = Color.FromArgb(154, 188, 224);
            lblAllExecutors.Location = new Point(12, 62);
            lblAllExecutors.Name = "lblAllExecutors";
            lblAllExecutors.Size = new Size(106, 20);
            lblAllExecutors.TabIndex = 4;
            lblAllExecutors.Text = "Исполнители";
            // 
            // btnDeleteExecutor
            // 
            btnDeleteExecutor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteExecutor.BackColor = Color.FromArgb(154, 188, 224);
            btnDeleteExecutor.FlatStyle = FlatStyle.Flat;
            btnDeleteExecutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDeleteExecutor.ForeColor = Color.FromArgb(3, 30, 54);
            btnDeleteExecutor.Location = new Point(220, 291);
            btnDeleteExecutor.Name = "btnDeleteExecutor";
            btnDeleteExecutor.Size = new Size(150, 50);
            btnDeleteExecutor.TabIndex = 5;
            btnDeleteExecutor.Text = "Удалить";
            btnDeleteExecutor.UseVisualStyleBackColor = false;
            btnDeleteExecutor.Click += btnDeleteExecutor_Click;
            // 
            // ExecutorsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 30, 54);
            ClientSize = new Size(382, 353);
            Controls.Add(btnDeleteExecutor);
            Controls.Add(lblAllExecutors);
            Controls.Add(textBoxNewName);
            Controls.Add(lblNewName);
            Controls.Add(btnAddExecutor);
            Controls.Add(listBoxAllExecutors);
            MinimumSize = new Size(400, 400);
            Name = "ExecutorsList";
            Text = "Исполнители";
            Load += ExecutorsList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAllExecutors;
        private Button btnAddExecutor;
        private Label lblNewName;
        private TextBox textBoxNewName;
        private Label lblAllExecutors;
        private Button btnDeleteExecutor;
    }
}