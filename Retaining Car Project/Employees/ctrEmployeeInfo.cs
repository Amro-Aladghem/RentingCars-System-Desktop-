using clsBuesnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.Employees
{
    public partial class ctrEmployeeInfo : UserControl
    {
        public ctrEmployeeInfo()
        {
            InitializeComponent();
        }

        clsEmployee Employee;
        public void GetObjectAndCreatClass(clsEmployee employee)
        {
            this.Employee=employee;
            _LoadData();
        }


        private void _LoadData()
        {
            if(Employee!=null)
            {
                lbEmployeeID.Text = Employee.EmployeeID.ToString();
                txtFirstName.Text = Employee.FirstName;
                txtSecond.Text = Employee.SecondName;
                txtLastName.Text=Employee.LastName;
                txtDepartment.Text = clsEmployee.GetDepartmentName(Employee.DepartmentID);
                txtSalary.Text = Employee.Salary.ToString();
                txtDateBirth.Text = Employee.DateOfBirth.ToShortDateString();
                txtIsActive.Text = Employee.isActive ? "yes" : "No";
            }
        }

        public void RestetData()
        {
            txtFirstName.Text = "";
            txtSecond.Text = "";
            txtLastName.Text = "";
            txtDateBirth.Text = "";
            txtSalary.Text = "";
            txtDepartment.Text = "";
            Employee = null;
            txtIsActive.Text = "";
            lbEmployeeID.Text = "N/A";
        }


        private void ctrEmployeeInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
