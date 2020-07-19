using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeAcc
{
    public partial class AddNewEmployeeForm : Form
    {
        public EmployeeItem ReturnEmployee { get; set; }
        public AddNewEmployeeForm()
        {
            InitializeComponent();
            DateReceiptTimePicker.Value = DateTime.Now;
            SaveButton.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FioTextBox.Text) || string.IsNullOrEmpty(PositionTextBox.Text))
            {
                MessageBox.Show("Одно или несколько полей были оставлены пустыми.");
            }
            ReturnEmployee = new EmployeeItem(FioTextBox.Text, PositionTextBox.Text, (double)SalaryNumericUpDown.Value, DateReceiptTimePicker.Value);
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FioTextBox.Text) || string.IsNullOrEmpty(PositionTextBox.Text))
                SaveButton.Enabled = false;
            else SaveButton.Enabled = true;
        }
    }
}
