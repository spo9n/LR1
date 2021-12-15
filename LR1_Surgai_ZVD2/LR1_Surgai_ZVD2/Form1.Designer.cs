
namespace LR1_Surgai_ZVD2
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
            this.allWorkersDataGridView = new System.Windows.Forms.DataGridView();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.flatLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.flatTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.neededWorkersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allWorkersLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allWorkersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neededWorkersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // allWorkersDataGridView
            // 
            this.allWorkersDataGridView.AllowUserToAddRows = false;
            this.allWorkersDataGridView.AllowUserToDeleteRows = false;
            this.allWorkersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allWorkersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn,
            this.nameColumn,
            this.patronymicColumn,
            this.streetColumn,
            this.buildingColumn,
            this.flatColumn});
            this.allWorkersDataGridView.Location = new System.Drawing.Point(263, 48);
            this.allWorkersDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.allWorkersDataGridView.Name = "allWorkersDataGridView";
            this.allWorkersDataGridView.ReadOnly = true;
            this.allWorkersDataGridView.Size = new System.Drawing.Size(649, 168);
            this.allWorkersDataGridView.TabIndex = 0;
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
            // patronymicColumn
            // 
            this.patronymicColumn.HeaderText = "По-батькові";
            this.patronymicColumn.Name = "patronymicColumn";
            this.patronymicColumn.ReadOnly = true;
            // 
            // streetColumn
            // 
            this.streetColumn.HeaderText = "Вулиця";
            this.streetColumn.Name = "streetColumn";
            this.streetColumn.ReadOnly = true;
            // 
            // buildingColumn
            // 
            this.buildingColumn.HeaderText = "Будинок";
            this.buildingColumn.Name = "buildingColumn";
            this.buildingColumn.ReadOnly = true;
            // 
            // flatColumn
            // 
            this.flatColumn.HeaderText = "Квартира";
            this.flatColumn.Name = "flatColumn";
            this.flatColumn.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(69, 322);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(131, 43);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Створити запис";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(26, 29);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(73, 16);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Прізвище:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(66, 68);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 16);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Ім\'я:";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(10, 107);
            this.patronymicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(89, 16);
            this.patronymicLabel.TabIndex = 4;
            this.patronymicLabel.Text = "По-батькові:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(40, 197);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(59, 16);
            this.streetLabel.TabIndex = 5;
            this.streetLabel.Text = "Вулиця:";
            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.Location = new System.Drawing.Point(32, 237);
            this.buildingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(67, 16);
            this.buildingLabel.TabIndex = 6;
            this.buildingLabel.Text = "Будинок:";
            // 
            // flatLabel
            // 
            this.flatLabel.AutoSize = true;
            this.flatLabel.Location = new System.Drawing.Point(25, 276);
            this.flatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flatLabel.Name = "flatLabel";
            this.flatLabel.Size = new System.Drawing.Size(74, 16);
            this.flatLabel.TabIndex = 7;
            this.flatLabel.Text = "Квартира:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(107, 26);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(132, 22);
            this.surnameTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(107, 65);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(132, 22);
            this.nameTextBox.TabIndex = 9;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(107, 104);
            this.patronymicTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(132, 22);
            this.patronymicTextBox.TabIndex = 10;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(107, 194);
            this.streetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(132, 22);
            this.streetTextBox.TabIndex = 11;
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Location = new System.Drawing.Point(107, 234);
            this.buildingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(132, 22);
            this.buildingTextBox.TabIndex = 12;
            // 
            // flatTextBox
            // 
            this.flatTextBox.Location = new System.Drawing.Point(107, 273);
            this.flatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.flatTextBox.Name = "flatTextBox";
            this.flatTextBox.Size = new System.Drawing.Size(132, 22);
            this.flatTextBox.TabIndex = 13;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(770, 224);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(142, 28);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Обрати записи";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // neededWorkersDataGridView
            // 
            this.neededWorkersDataGridView.AllowUserToAddRows = false;
            this.neededWorkersDataGridView.AllowUserToDeleteRows = false;
            this.neededWorkersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.neededWorkersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.neededWorkersDataGridView.Location = new System.Drawing.Point(265, 264);
            this.neededWorkersDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.neededWorkersDataGridView.Name = "neededWorkersDataGridView";
            this.neededWorkersDataGridView.ReadOnly = true;
            this.neededWorkersDataGridView.Size = new System.Drawing.Size(649, 171);
            this.neededWorkersDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Прізвище";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ім\'я";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "По-батькові";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Вулиця";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Будинок";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Квартира";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // allWorkersLabel
            // 
            this.allWorkersLabel.AutoSize = true;
            this.allWorkersLabel.Location = new System.Drawing.Point(303, 15);
            this.allWorkersLabel.Name = "allWorkersLabel";
            this.allWorkersLabel.Size = new System.Drawing.Size(107, 16);
            this.allWorkersLabel.TabIndex = 16;
            this.allWorkersLabel.Text = "Усі працівники:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Працівники, що живуть на вул. Червоної:\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allWorkersLabel);
            this.Controls.Add(this.neededWorkersDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.flatTextBox);
            this.Controls.Add(this.buildingTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.flatLabel);
            this.Controls.Add(this.buildingLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.allWorkersDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сургай П-81";
            ((System.ComponentModel.ISupportInitialize)(this.allWorkersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neededWorkersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allWorkersDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.Label flatLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox flatTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatColumn;
        private System.Windows.Forms.DataGridView neededWorkersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label allWorkersLabel;
        private System.Windows.Forms.Label label1;
    }
}

