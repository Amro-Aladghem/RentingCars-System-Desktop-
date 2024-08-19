using clsBuesnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RetainCarsProject.Drivers
{
    public partial class ctrAddUpdateDriver : UserControl
    {
        enum eMode { AddNew = 1, Update = 2 };
        eMode Mode;

        public class GetDriverObject : EventArgs
        {
            clsDrivers Drivers;

            public GetDriverObject(clsDrivers Driver)
            {
                this.Drivers = Driver;
            }
        }

        public event EventHandler<GetDriverObject> OnSaveClick;

        public ctrAddUpdateDriver()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
            Driver = new clsDrivers();
        }

        clsDrivers Driver;

        public void GetAndCreatClass(clsDrivers Driver)
        {
            this.Driver = Driver;
            Mode = eMode.Update;
        }


        private void _RestartData()
        {
            lbDriverID.Text = "N/A";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            cbxNationality.SelectedIndex = 0;
            numericSalary.Value= 0;

            if (Mode == eMode.Update)
            {
                _LoadData();
            }
        }

        private void _LoadData()
        {
            if(Driver!=null)
            {
                lbDriverID.Text = Driver.DriverID.ToString();
                txtFirstName.Text=Driver.FirstName; 
                txtLastName.Text=Driver.LastName;
                txtPhone.Text = Driver.PhoneNumber;
                cbxNationality.Text = Driver.Nationality;
                numericSalary.Value=Driver.Salary;
            }
        }







        private void ctrAddUpdateDriver_Load(object sender, EventArgs e)
        {
            _RestartData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            if (MessageBox.Show("Are You Sure to Add/Update this Driver!", "Warnnging", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                MessageBox.Show("The Process Cancled!");
                return;
            }

            Driver.FirstName = txtFirstName.Text;
            Driver.LastName = txtLastName.Text;
            Driver.Nationality = cbxNationality.Text;
            Driver.PhoneNumber = txtPhone.Text;
            Driver.Salary = numericSalary.Value;
            if(Mode==eMode.AddNew)
            {
                Driver.DateOfSet = DateTime.Now;
            }

            if (!Driver.Save())
            {
                MessageBox.Show("The Process Cancled,Somthing Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has done Successfully");
            if(Mode==eMode.AddNew)
            {
                lbDriverID.Text = Driver.DriverID.ToString();
                Mode = eMode.Update;
                OnSaveClick?.Invoke(sender, new GetDriverObject(Driver));
            }




        }



        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFirstName.Text))
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

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "You must fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void numericSalary_Validating(object sender, CancelEventArgs e)
        {
            if(numericSalary.Value==0)
            {
                e.Cancel = true;
                errorProvider1.SetError(numericSalary, "You must choose salary above 0");
            }
           else
            {
                e.Cancel = false;
                errorProvider1.SetError(numericSalary, "");
            }
        }
    }
}
