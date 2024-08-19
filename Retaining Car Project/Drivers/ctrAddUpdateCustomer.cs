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

namespace Retaining_Car_Project.Drivers
{
    public partial class ctrAddUpdateCustomer : UserControl
    {
        enum eMode { AddNew=1,Update=2}
        eMode Mode;

        public ctrAddUpdateCustomer()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
        }

        clsDrivers Driver = new clsDrivers();

        public event EventHandler OnSaveClik;
        public void GetObjectAndCreatClass(clsDrivers Dirver)
        {
            this.Driver = Dirver;
            Mode = eMode.Update;
            _LoadData();
        }


        private void _LoadData()
        {
            if(Driver!=null)
            {
                lbDriverID.Text = Driver.DriverID.ToString();
                txtFirstName.Text = Driver.FirstName;
                txtLastName.Text = Driver.LastName;
                txtPhone.Text = Driver.PhoneNumber;
                cbxNationality.Text = Driver.Nationality;
                numericUpDown1.Value = Driver.Salary ;

                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;

            }
        }

        private void ResetData()
        {
            if(Mode==eMode.Update)
            {
                _LoadData();
            }
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
                errorProvider1.SetError(txtFirstName, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "You msut Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {
            if(numericUpDown1.Value<=0)
            {
                e.Cancel = true;
                errorProvider1.SetError(numericUpDown1, "The Salary must above 0");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numericUpDown1, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            if(MessageBox.Show("Are You sure to Add/Updat this Driver!","Warnning",MessageBoxButtons.OK,MessageBoxIcon.Warning) == DialogResult.Cancel) 
            {
                return;
            }


            if(Mode==eMode.AddNew)
            {
                Driver.FirstName = txtFirstName.Text;
                Driver.LastName = txtLastName.Text;
                Driver.DateOfSet = DateTime.Now;
            }

            Driver.PhoneNumber = txtPhone.Text;
            Driver.Salary = numericUpDown1.Value;
            Driver.Nationality = cbxNationality.Text;

            if(!Driver.Save())
            {
                MessageBox.Show("Somting Error The Procees Cancled!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
            }

            MessageBox.Show("The Process has done Successfully!");
            lbDriverID.Text = Driver.DriverID.ToString();
            Mode = eMode.Update;
            OnSaveClik?.Invoke(null, null);


        }

        private void ctrAddUpdateCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
