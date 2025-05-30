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
            label2 = new Label();
            label3 = new Label();
            comboBoxExecutor = new ComboBox();
            comboBoxPriority = new ComboBox();
            label4 = new Label();
            buttonSave = new Button();
            checkBoxStatus = new CheckBox();
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
            textBoxDescription.Size = new Size(351, 135);
            textBoxDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(154, 188, 224);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(154, 188, 224);
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 4;
            label3.Text = "Исполнитель";
            // 
            // comboBoxExecutor
            // 
            comboBoxExecutor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxExecutor.BackColor = Color.FromArgb(154, 188, 224);
            comboBoxExecutor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExecutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBoxExecutor.ForeColor = Color.FromArgb(3, 30, 54);
            comboBoxExecutor.FormattingEnabled = true;
            comboBoxExecutor.Location = new Point(119, 189);
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
            comboBoxPriority.Location = new Point(119, 223);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(351, 28);
            comboBoxPriority.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(154, 188, 224);
            label4.Location = new Point(12, 226);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Приоритет";
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
            // InfoTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 30, 54);
            ClientSize = new Size(482, 353);
            Controls.Add(checkBoxStatus);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxPriority);
            Controls.Add(label4);
            Controls.Add(comboBoxExecutor);
            Controls.Add(label3);
            Controls.Add(textBoxDescription);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "InfoTaskForm";
            Text = "Задача";
            Load += AddTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxExecutor;
        private ComboBox comboBoxPriority;
        private Label label4;
        private Button buttonSave;
        private CheckBox checkBoxStatus;
    }
}