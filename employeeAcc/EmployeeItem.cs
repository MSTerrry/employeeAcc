using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeAcc
{
    public class EmployeeItem
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public DateTime ReceptionDate { get; set; }
        public DateTime DismissalDate { get; set; }

        public EmployeeItem() { }
        public EmployeeItem(string fio, string position, double salary, DateTime receptionDate)
        {
            Fio = fio;
            Position = position;
            Salary = salary;
            ReceptionDate = receptionDate;
        }
        public EmployeeItem(EmployeeDBDataSet.EmployeeRow e)
        {
            Id = e.Id;
            Fio = e.Fio;
            Position = e.Position;
            Salary = e.Salary;
            ReceptionDate = e.ReceptionDate;
            DismissalDate = e.DismissalDate;
        }
    }
}
