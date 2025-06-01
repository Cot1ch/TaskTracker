namespace TaskTracker
{
    partial class InfoTaskForm
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
            labelName = new Label();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            lblDescription = new Label();
            lblExecutor = new Label();
            comboBoxExecutor = new ComboBox();
            comboBoxPriority = new ComboBox();
            lblPriority = new Label();
            buttonSave = new Button();
            checkBoxStatus = new CheckBox();
            lblDeadline = new Label();
            dateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName.ForeColor = Color.FromArgb(154, 188, 224);
            labelName.Location = new Point(12, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(78, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Название";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.BackColor = Color.FromArgb(154, 188, 224);
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxName.ForeColor = Color.FromArgb(3, 30, 54);
            textBoxName.Location = new Point(119, 15);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(351, 20);
            textBoxName.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescription.BackColor = Color.FromArgb(154, 188, 224);
            textBoxDescription.BorderStyle = BorderStyle.None;
            textBoxDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxDescription.ForeColor = Color.FromArgb(3, 30, 54);
            textBoxDescription.Location = new Point(119, 48);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(351, 131);
            textBoxDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblDescription.ForeColor = Color.FromArgb(154, 188, 224);
            lblDescription.Location = new Point(12, 48);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(79, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Описание";
            // 
            // lblExecutor
            // 
            lblExecutor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblExecutor.AutoSize = true;
            lblExecutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblExecutor.ForeColor = Color.FromArgb(154, 188, 224);
            lblExecutor.Location = new Point(12, 188);
            lblExecutor.Name = "lblExecutor";
            lblExecutor.Size = new Size(105, 20);
            lblExecutor.TabIndex = 4;
            lblExecutor.Text = "Исполнитель";
            // 
            // comboBoxExecutor
            // 
            comboBoxExecutor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxExecutor.BackColor = Color.FromArgb(154, 188, 224);
            comboBoxExecutor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExecutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBoxExecutor.ForeColor = Color.FromArgb(3, 30, 54);
            comboBoxExecutor.FormattingEnabled = true;
            comboBoxExecutor.Location = new Point(119, 185);
            comboBoxExecutor.Name = "comboBoxExecutor";
            comboBoxExecutor.Size = new Size(351, 28);
            comboBoxExecutor.TabIndex = 5;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxPriority.BackColor = Color.FromArgb(154, 188, 224);
            comboBoxPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBoxPriority.ForeColor = Color.FromArgb(3, 30, 54);
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Items.AddRange(new object[] { "Высокий", "Средний", "Низкий" });
            comboBoxPriority.Location = new Point(119, 219);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(351, 28);
            comboBoxPriority.TabIndex = 7;
            // 
            // lblPriority
            // 
            lblPriority.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPriority.ForeColor = Color.FromArgb(154, 188, 224);
            lblPriority.Location = new Point(12, 222);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(87, 20);
            lblPriority.TabIndex = 6;
            lblPriority.Text = "Приоритет";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(154, 188, 224);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = Color.FromArgb(3, 30, 54);
            buttonSave.Location = new Point(320, 291);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 50);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Добавить задачу";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // checkBoxStatus
            // 
            checkBoxStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxStatus.AutoSize = true;
            checkBoxStatus.BackColor = Color.FromArgb(3, 30, 54);
            checkBoxStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBoxStatus.ForeColor = Color.FromArgb(154, 188, 224);
            checkBoxStatus.Location = new Point(12, 305);
            checkBoxStatus.Name = "checkBoxStatus";
            checkBoxStatus.Size = new Size(114, 24);
            checkBoxStatus.TabIndex = 8;
            checkBoxStatus.Text = "Выполнена";
            checkBoxStatus.UseVisualStyleBackColor = false;
            // 
            // lblDeadline
            // 
            lblDeadline.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDeadline.AutoSize = true;
            lblDeadline.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblDeadline.ForeColor = Color.FromArgb(154, 188, 224);
            lblDeadline.Location = new Point(12, 258);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(73, 20);
            lblDeadline.TabIndex = 10;
            lblDeadline.Text = "Дедлайн";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateTimePicker.CalendarForeColor = Color.FromArgb(3, 30, 54);
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(154, 188, 224);
            dateTimePicker.CalendarTitleBackColor = Color.FromArgb(154, 188, 224);
            dateTimePicker.CalendarTitleForeColor = Color.FromArgb(3, 30, 54);
            dateTimePicker.CalendarTrailingForeColor = Color.FromArgb(3, 30, 54);
            dateTimePicker.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateTimePicker.ImeMode = ImeMode.Off;
            dateTimePicker.Location = new Point(119, 253);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(351, 27);
            dateTimePicker.TabIndex = 11;
            // 
            // InfoTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 30, 54);
            ClientSize = new Size(482, 353);
            Controls.Add(dateTimePicker);
            Controls.Add(lblDeadline);
            Controls.Add(checkBoxStatus);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxPriority);
            Controls.Add(lblPriority);
            Controls.Add(comboBoxExecutor);
            Controls.Add(lblExecutor);
            Controls.Add(textBoxDescription);
            Controls.Add(lblDescription);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            MinimumSize = new Size(500, 400);
            Name = "InfoTaskForm";
            Text = "Задача";
            Load += AddTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblDeadline;

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private Label lblDescription;
        private System.Windows.Forms.Label lblExecutor;
        private System.Windows.Forms.ComboBox comboBoxExecutor;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label lblPriority;
        private Button buttonSave;
        private CheckBox checkBoxStatus;
        private DateTimePicker dateTimePicker;
    }
}