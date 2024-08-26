using clsBuesnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.Employees
{
    public partial class ctrAddUpdateEmployee : UserControl
    {
        enum eMode { AddNew = 1, Update = 2 }
        eMode Mode;


        clsEmployee Employee = new clsEmployee();

        public event EventHandler OnSaveClick;        
        public ctrAddUpdateEmployee()
        {
            InitializeComponent();
            Mode=eMode.AddNew;
        }

        public void GetObjectAndCreatClass(clsEmployee employee)
        {
            this.Employee=employee;
            Mode = eMode.Update;
            _LoadData();
        }


        private void _LoadData()
        {
            if(Employee!=null)
            {
                lbID.Text = Employee.EmployeeID.ToString();
                txtFirstName.Text=Employee.FirstName;
                txtSecondName.Text = Employee.SecondName;
                txtLastName.Text = Employee.LastName;
                dateTimeBirth.Value = Employee.DateOfBirth;
                cbxDepartment.SelectedIndex = Employee.DepartmentID - 1;
                numericSalary.Value=Employee.Salary;
                if(Employee.Gendor)
                {
                    rdFemale.Checked = true;
                }
                else
                {
                    rdMale.Checked = true;
                }

                cbxIsActive.Checked = Employee.isActive;

                txtFirstName.Enabled = false;
                txtLastName.Enabled=false;
                dateTimeBirth.Enabled = false;
                rdMale.Enabled=false;
                rdFemale.Enabled = false;
            }
        }

        private void ResetData()
        {
            cbxDepartment.SelectedIndex = 0;
            cbxIsActive.Checked = true;
            rdMale.Checked = true;


            if(Mode==eMode.Update)
            {
                _LoadData();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName,"You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
                errorProvider1.SetError(dateTimeBirth, "The Emploee Age must above 18!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dateTimeBirth, "");
            }
        }

        private void numericSalary_Validating(object sender, CancelEventArgs e)
        {
            if(numericSalary.Value<=0)
            {
                e.Cancel= true;
                errorProvider1.SetError(numericSalary,"The Salary must above 0 JD");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numericSalary, "");
            }

        }

        private void ctrAddUpdateEmployee_Load(object sender, EventArgs e)
        {
            ResetData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            if(MessageBox.Show("Are you sure to Add/Update this Employee!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel) 
            {
                MessageBox.Show("The Process Cancled!");
                return;
            }

            if(Mode==eMode.AddNew)
            {
                Employee.FirstName = txtFirstName.Text;
                Employee.LastName = txtLastName.Text;
                Employee.DateOfBirth = dateTimeBirth.Value;
                Employee.DateOfSet = DateTime.Now;
                if(rdMale.Checked)
                {
                    Employee.Gendor = false;
                }
                else
                {
                    Employee.Gendor = true;
                }
            }

            Employee.SecondName= txtSecondName.Text;
            Employee.DepartmentID = cbxDepartment.SelectedIndex + 1;
            Employee.Salary = numericSalary.Value;
            Employee.isActive = cbxIsActive.Checked;


            if(!Employee.Save())
            {
                MessageBox.Show("The Process Cancled Somting Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            MessageBox.Show("The Procees has Done Succesfully!");
            Mode = eMode.Update;
            lbID.Text = Employee.EmployeeID.ToString();
            OnSaveClick?.Invoke(null, null);
        }


    }
}
