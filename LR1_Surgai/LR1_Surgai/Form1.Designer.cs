
namespace LR1_Surgai
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.zodiacSignTextBox = new System.Windows.Forms.TextBox();
            this.zodiacSignLabel = new System.Windows.Forms.Label();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zodiacSignColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchSignTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchSignLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(81, 37);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(73, 16);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "Прізвище:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(168, 34);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(204, 22);
            this.surnameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(168, 79);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(204, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(121, 83);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Ім\'я:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(28, 169);
            this.dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(126, 16);
            this.dateOfBirthLabel.TabIndex = 4;
            this.dateOfBirthLabel.Text = "Дата народження:";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(168, 169);
            this.dateOfBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(204, 22);
            this.dateOfBirthDateTimePicker.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(152, 217);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 41);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Створити";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn,
            this.nameColumn,
            this.zodiacSignColumn,
            this.dateOfBirthColumn});
            this.dataGridView.Location = new System.Drawing.Point(401, 79);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(448, 223);
            this.dataGridView.TabIndex = 7;
            // 
            // zodiacSignTextBox
            // 
            this.zodiacSignTextBox.Location = new System.Drawing.Point(168, 126);
            this.zodiacSignTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zodiacSignTextBox.Name = "zodiacSignTextBox";
            this.zodiacSignTextBox.Size = new System.Drawing.Size(204, 22);
            this.zodiacSignTextBox.TabIndex = 9;
            // 
            // zodiacSignLabel
            // 
            this.zodiacSignLabel.AutoSize = true;
            this.zodiacSignLabel.Location = new System.Drawing.Point(57, 129);
            this.zodiacSignLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zodiacSignLabel.Name = "zodiacSignLabel";
            this.zodiacSignLabel.Size = new System.Drawing.Size(97, 16);
            this.zodiacSignLabel.TabIndex = 8;
            this.zodiacSignLabel.Text = "Знак Зодіаку:";
            // 
            // surnameColumn
            // 
            this.surnameColumn.HeaderText = "Прізвище";
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Ім\'я";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // zodiacSignColumn
            // 
            this.zodiacSignColumn.HeaderText = "Знак Зодіаку";
            this.zodiacSignColumn.Name = "zodiacSignColumn";
            this.zodiacSignColumn.ReadOnly = true;
            // 
            // dateOfBirthColumn
            // 
            this.dateOfBirthColumn.HeaderText = "Дата народження";
            this.dateOfBirthColumn.Name = "dateOfBirthColumn";
            this.dateOfBirthColumn.ReadOnly = true;
            // 
            // searchSignTextBox
            // 
            this.searchSignTextBox.Location = new System.Drawing.Point(574, 31);
            this.searchSignTextBox.Name = "searchSignTextBox";
            this.searchSignTextBox.Size = new System.Drawing.Size(139, 22);
            this.searchSignTextBox.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(732, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(119, 40);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchSignLabel
            // 
            this.searchSignLabel.AutoSize = true;
            this.searchSignLabel.Location = new System.Drawing.Point(419, 34);
            this.searchSignLabel.Name = "searchSignLabel";
            this.searchSignLabel.Size = new System.Drawing.Size(149, 16);
            this.searchSignLabel.TabIndex = 12;
            this.searchSignLabel.Text = "Введіть знак Зодіаку:";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(742, 313);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(107, 41);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Скинути";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 366);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchSignLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchSignTextBox);
            this.Controls.Add(this.zodiacSignTextBox);
            this.Controls.Add(this.zodiacSignLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сургай П-81";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox zodiacSignTextBox;
        private System.Windows.Forms.Label zodiacSignLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zodiacSignColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthColumn;
        private System.Windows.Forms.TextBox searchSignTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchSignLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

