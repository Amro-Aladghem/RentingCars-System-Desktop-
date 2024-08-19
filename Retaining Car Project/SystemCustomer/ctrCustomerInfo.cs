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
    public partial class ctrCustomerInfo : UserControl
    {
        public ctrCustomerInfo()
        {
            InitializeComponent();
        }

        clsCustomers Customer;

        public void ResetData()
        {
            lbCustomerID.Text = "N/A";
            txtFirstName.Text = "";
            txtSecondName.Text= "";
            txtLastName.Text=   "";
            txtPhone.Text=      "";
            txtEmail.Text=      "";
            cbxNationality.Text="";
            txtNationNum.Text=  "";
            rdMale.Checked = true;
            Customer = null; 

        }


        public void GetObjectAndCreatClass(clsCustomers Customer)
        {
            this.Customer = Customer;

            _LoadData();
        }
        private void _LoadData()
        {
            if(Customer!=null)
            {
                lbCustomerID.Text = Customer.CustomerID.ToString();
                txtFirstName.Text=Customer.FirstName;
                txtSecondName.Text=Customer.SecondName;
                txtLastName.Text  =Customer.LastName;
                txtPhone.Text      = Customer.PhoneNumber;
                txtEmail.Text       =Customer.Email;
                cbxNationality.Text = Customer.Nationality;
                txtNationNum.Text    = Customer.NationalNum;
                if (Customer.Gendor)
                {
                    rdFemale.Checked = true;
                }
                else
                {
                    rdMale.Checked = true;
                }

            }





        }
        private void ctrCustomerInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
