namespace employeeAcc
{
    partial class AddNewEmployeeForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FioTextBox = new System.Windows.Forms.TextBox();
            this.FioLabel = new System.Windows.Forms.Label();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.ReceiptDateLabel = new System.Windows.Forms.Label();
            this.DateReceiptTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SalaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(12, 194);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(80, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(115, 194);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(80, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FioTextBox
            // 
            this.FioTextBox.Location = new System.Drawing.Point(12, 35);
            this.FioTextBox.Name = "FioTextBox";
            this.FioTextBox.Size = new System.Drawing.Size(183, 20);
            this.FioTextBox.TabIndex = 2;
            this.FioTextBox.TextChanged += new System.EventHandler(this.FioTextBox_TextChanged);
            // 
            // FioLabel
            // 
            this.FioLabel.AutoSize = true;
            this.FioLabel.Location = new System.Drawing.Point(12, 19);
            this.FioLabel.Name = "FioLabel";
            this.FioLabel.Size = new System.Drawing.Size(34, 13);
            this.FioLabel.TabIndex = 3;
            this.FioLabel.Text = "ФИО";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(12, 74);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(183, 20);
            this.PositionTextBox.TabIndex = 4;
            this.PositionTextBox.TextChanged += new System.EventHandler(this.FioTextBox_TextChanged);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(13, 58);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(65, 13);
            this.PositionLabel.TabIndex = 5;
            this.PositionLabel.Text = "Должность";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(12, 97);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(39, 13);
            this.SalaryLabel.TabIndex = 7;
            this.SalaryLabel.Text = "Оклад";
            // 
            // ReceiptDateLabel
            // 
            this.ReceiptDateLabel.AutoSize = true;
            this.ReceiptDateLabel.Location = new System.Drawing.Point(13, 136);
            this.ReceiptDateLabel.Name = "ReceiptDateLabel";
            this.ReceiptDateLabel.Size = new System.Drawing.Size(126, 13);
            this.ReceiptDateLabel.TabIndex = 8;
            this.ReceiptDateLabel.Text = "Дата приема на работу";
            // 
            // DateReceiptTimePicker
            // 
            this.DateReceiptTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateReceiptTimePicker.Location = new System.Drawing.Point(12, 152);
            this.DateReceiptTimePicker.Name = "DateReceiptTimePicker";
            this.DateReceiptTimePicker.Size = new System.Drawing.Size(183, 20);
            this.DateReceiptTimePicker.TabIndex = 9;
            // 
            // SalaryNumericUpDown
            // 
            this.SalaryNumericUpDown.DecimalPlaces = 2;
            this.SalaryNumericUpDown.Location = new System.Drawing.Point(12, 113);
            this.SalaryNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.SalaryNumericUpDown.Name = "SalaryNumericUpDown";
            this.SalaryNumericUpDown.Size = new System.Drawing.Size(183, 20);
            this.SalaryNumericUpDown.TabIndex = 10;
            this.SalaryNumericUpDown.ThousandsSeparator = true;
            // 
            // AddNewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 225);
            this.Controls.Add(this.SalaryNumericUpDown);
            this.Controls.Add(this.DateReceiptTimePicker);
            this.Controls.Add(this.ReceiptDateLabel);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.FioLabel);
            this.Controls.Add(this.FioTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Name = "AddNewEmployeeForm";
            this.Text = "AddNewEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox FioTextBox;
        private System.Windows.Forms.Label FioLabel;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label ReceiptDateLabel;
        private System.Windows.Forms.DateTimePicker DateReceiptTimePicker;
        private System.Windows.Forms.NumericUpDown SalaryNumericUpDown;
    }
}