using clsBuesnesLayer;
using RetainCarsProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetainCarsProject.Employees
{
    public partial class ctrEmployeeInfo : UserControl
    {
        public ctrEmployeeInfo()
        {
            InitializeComponent();
        }

        public void GetIDAndCreatClass(int EmployeeID)
        {
            Employee = clsEmployee.FindEmployee(EmployeeID);
            _LoadData();
        }

        clsEmployee Employee;

        public int ReturnEmployeeID()
        {
            return Employee.EmployeeID;
        }
        private void _LoadData()
        {
            if (Employee != null)
            {
                txtFirstName.Text=Employee.FirstName;
                txtSecondName.Text = Employee.SecondName;
                txtLastName.Text = Employee.LastName;
                txtDepartment.Text=clsEmployee.GetDepartmentName(Employee.DepartmentID);
                txtSalary.Text = Employee.Salary.ToString();
                txtDateOfBirth.Text = Employee.DateOfBirth.ToShortDateString();
                if(Employee.Gendor==false)
                {
                    pictureBox1.Image = Resources.boy;
                }
                else
                {
                    pictureBox1.Image = Resources.student;
                }

                txtIsActive.Text = Employee.isActive == true ? "Yes" : "No";


            }
        }

       public void ResetData()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSecondName.Text = "";
            txtDepartment.Text = "";
            txtSalary.Text = "";
            txtDateOfBirth.Text = "";
            txtIsActive.Text = "";
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
