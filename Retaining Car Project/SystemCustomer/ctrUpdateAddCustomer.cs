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

namespace Retaining_Car_Project.SystemCustomer
{
    public partial class ctrUpdateAddCustomer : UserControl
    {
        enum eMode { AddNew=1,Update=2}
        eMode Mode;

        clsCustomers Customer;
        public ctrUpdateAddCustomer()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
            Customer = new clsCustomers();
        }

        private void _LoadData()
        {
            if(Customer!=null)
            {
                lbCustomerID.Text = Customer.CustomerID.ToString();
                txtFirstName.Text = Customer.FirstName;
                txtSecondName.Text = Customer.SecondName;
                txtLastName.Text = Customer.LastName;
                txtPhone.Text = Customer.PhoneNumber;
                txtEmail.Text = Customer.Email;
                cbxNationality.Text = Customer.Nationality;
                txtNationNum.Text = Customer.NationalNum.ToString();
                if(Customer.Gendor)
                {
                    rdFemale.Checked = true;
                }
                else
                {
                    rdMale.Checked = true;
                }

                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                rdFemale.Enabled = false;
                rdMale.Enabled = false;
                txtNationNum.Enabled = false;
                cbxNationality.Enabled = false;


            }
        }

        public void GetObjectAndCreatClass(clsCustomers Customer)
        {
            this.Customer = Customer;
            Mode = eMode.Update;
            _LoadData();
        }
        public event EventHandler OnSaveClick;



        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void txtNationNum_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNationNum_Validating(object sender, CancelEventArgs e)
        {
            if(txtNationNum.Text=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationNum, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationNum, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(txtEmail.Text.Contains("@gmail.com")&& txtEmail.Text!="")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail,"The Email Not Valied");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void ctrUpdateAddCustomer_Load(object sender, EventArgs e)
        {
            cbxNationality.SelectedIndex = 0;
            rdMale.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            if(MessageBox.Show("Are you sure to Add/Update this Driver!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel) 
            {
                return;
            }

            if(Mode==eMode.AddNew)
            {
                Customer.FirstName = txtFirstName.Text;
                Customer.LastName = txtLastName.Text;
                Customer.Nationality = cbxNationality.Text;
                Customer.NationalNum = txtNationNum.Text;
                Customer.Gendor = rdMale.Checked ? false : true;
            }

            Customer.PhoneNumber = txtPhone.Text;
            Customer.Email = txtEmail.Text;
            Customer.SecondName = txtSecondName.Text;

            if (!Customer.Save())
            {
                MessageBox.Show("The Proces Cancled Somting Erorr", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbCustomerID.Text = Customer.CustomerID.ToString();
            Mode = eMode.Update;
            OnSaveClick?.Invoke(null, null);

            MessageBox.Show("The Process has Done Succesfully!");

            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            rdFemale.Enabled = false;
            rdMale.Enabled = false;
            txtNationNum.Enabled = false;
            cbxNationality.Enabled = false;

        }
    }
}
