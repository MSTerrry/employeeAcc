using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace employeeAcc
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();  
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDBDataSet.Employee);
            ReCalculateStatistic();            
        }
        private void ReCalculateStatistic()
        {
            var list = employeeDBDataSet.Employee.Where(x =>x != null && x.DismissalDate == default).ToList();
            AverageSalary.Text = "Ср.зарплата:" + (list.Count()>0 ? list.Average(x => x.Salary) : 0);
            EmployeeCount.Text = "Кол-во сотрудников:" + list.Count();
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddNewEmployeeForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var index = employeeDBDataSet.Tables["Employee"].Rows.Count;
                var row = employeeDBDataSet.Employee.NewEmployeeRow();
                row[0] = index++;
                var fields = typeof(EmployeeItem).GetProperties();
                foreach (var field in fields)
                {
                    if (field.Name == "Id")
                        continue;
                    row[field.Name] = field.GetValue(form.ReturnEmployee);
                }
                employeeDBDataSet.Employee.AddEmployeeRow(row);
                ContextSave_Click(null, null);
            }            
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(List<EmployeeItem>));
            var sfd = new SaveFileDialog();            
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                using (var filestream = File.Create(sfd.FileName))
                {
                    List<EmployeeItem> list = new List<EmployeeItem>();
                    employeeDBDataSet.Employee.ToList().ForEach(x=>list.Add(new EmployeeItem(x)));
                    serializer.Serialize(filestream, list);
                    filestream.Close();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ContextSave_Click(object sender, EventArgs e)
        {           
            employeeTableAdapter.Adapter.Update(employeeDBDataSet.Employee);
            employeeDBDataSet.Employee.AcceptChanges();
            ReCalculateStatistic();
        }

        private void ContextDismiss_Click(object sender, EventArgs e)
        {
            var cellCount = EmployeeDataGridVIew.Columns.Count;
            foreach (var empl in EmployeeDataGridVIew.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index))
            {
                employeeDBDataSet.Employee.First(x => x.Id == empl).DismissalDate = DateTime.Now.Date;
            }
            ContextSave_Click(null, null);
        }

        private void EmployeeDataGridVIew_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                EmployeeDataGridVIew.Rows[e.RowIndex].Selected = true;
                ContextMenu.Show(EmployeeDataGridVIew, EmployeeDataGridVIew.PointToClient(Cursor.Position));                
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(SearchTextBox.Text)) return;
            var index = employeeDBDataSet.Employee.ToList().FindIndex(x => x.Fio.ToLower().Contains(SearchTextBox.Text));//по аналогии можно сделать через sql запрос с LIKE
            if (index == -1) return;
            EmployeeDataGridVIew.ClearSelection();
            EmployeeDataGridVIew.Rows[index].Selected = true;
            EmployeeDataGridVIew.CurrentCell = EmployeeDataGridVIew[0, index];
        }

        private void EmployeeDataGridVIew_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            MessageBox.Show("В строке " + e.RowIndex + " колонке " + e.ColumnIndex + " было введено неверное значение.");
        }

        private void EmployeeDataGridVIew_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if(e.ColumnIndex == 3 && e.FormattedValue.ToString().Contains("-"))
            {
                MessageBox.Show("Оклад не может быть отрицательным.");
                e.Cancel = true;
            }
        }

        private void EmployeeDataGridVIew_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
                return;
        }
    }
}
