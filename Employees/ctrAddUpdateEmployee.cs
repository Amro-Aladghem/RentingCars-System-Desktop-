using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsBuesnesLayer;

namespace RetainCarsProject
{
    public partial class ctrAddUpdateEmployee : UserControl
    {
        enum eMode { AddNew=1,Update=2}
        eMode Mode = eMode.AddNew;

        clsEmployee Employee;

        public ctrAddUpdateEmployee()
        {
            InitializeComponent();
            Mode =eMode.AddNew;
            Employee = new clsEmployee();
        }

        public class GetNewEmployeeID:EventArgs
        {
            public int EmployeeID { get; }

            public GetNewEmployeeID(int employeeID)
            {
                EmployeeID = employeeID;
            }
        }

        public event EventHandler<GetNewEmployeeID> OnSaveClick;


        public void GetIDAndCreatClass(int EmployeeID)
        {
            Employee = clsEmployee.FindEmployee(EmployeeID);
            Mode = eMode.Update;
            _LoadData();
        }



        private void _ResetData()
        {
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtLastName.Text = "";
            cbxDepartment.SelectedIndex = 0;
            numaricSalary.Value = 0;
            rdFemale.Checked = true;
            cbIsActive.Checked = true;
            cbIsActive.Enabled = false;

            if(Mode== eMode.Update)
            {
                _LoadData();
            }

        }
        private void _LoadData()
        {
            if (Employee != null)
            {
                txtFirstName.Text = Employee.FirstName;
                txtSecondName.Text = Employee.SecondName;
                txtLastName.Text = Employee.LastName;
                if (Employee.Gendor)
                {
                    rdFemale.Checked = true;
                }
                else
                {
                    rdMale.Checked = true;
                }

                numaricSalary.Value=Employee.Salary;
                cbxDepartment.Text=clsEmployee.GetDepartmentName(Employee.DepartmentID);
                cbIsActive.Enabled = true;
                cbIsActive.Checked = Employee.isActive;
                dateTimeBirth.Value = Employee.DateOfBirth;

                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                dateTimeBirth.Enabled = false;
                rdFemale.Enabled = false;
                rdMale.Enabled = false;


            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
                   
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void dateTimeBirth_Validating(object sender, CancelEventArgs e)
        {
            if((DateTime.Now.Year-dateTimeBirth.Value.Year)<18)
            {
                e.Cancel = true;
                errorProvider1.SetError(dateTimeBirth, "The Age must be above 18,you cant hire him!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dateTimeBirth, "");
            }
        }

        private void numaricSalary_Validating(object sender, CancelEventArgs e)
        {
            if(numaricSalary.Value<0)
            {
                e.Cancel = true;
                errorProvider1.SetError(numaricSalary, "The Salary must above Zero!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numaricSalary, "");
            }
        }

        private void ctrAddUpdateEmployee_Load(object sender, EventArgs e)
        {
            if(Mode==eMode.AddNew)
            {
                cbxDepartment.SelectedIndex = 0;
                rdMale.Checked = true;
            }
  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            if(MessageBox.Show("Are You Sure To Add/Update this Employee!","Warrning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }


            if (Mode == eMode.AddNew)
            {
                Employee.FirstName = txtFirstName.Text;
                Employee.LastName = txtLastName.Text;
                Employee.Gendor = rdFemale.Checked == true ? true : false;
                Employee.DateOfBirth = dateTimeBirth.Value;
                Employee.DateOfSet = DateTime.Now;
            }

            Employee.SecondName=txtSecondName.Text;
            Employee.DepartmentID = cbxDepartment.SelectedIndex+1;
            Employee.Salary = numaricSalary.Value;
            Employee.isActive = cbIsActive.Checked;
           

            if(Employee.Save())
            {
                MessageBox.Show("The Process has Done Successfully!");
                OnSaveClick?.Invoke(sender,new GetNewEmployeeID(Employee.EmployeeID));
                cbIsActive.Enabled = true;
            }
            else
            {
                MessageBox.Show("Something Error, The Process Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
           
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
