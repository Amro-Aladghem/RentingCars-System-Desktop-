using clsBuesnesLayer;
using Retaining_Car_Project.Employees;
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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        clsCustomers Customer = new clsCustomers();



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrCustomerInfowithFilter1_OnSaveClick(object sender, ctrCustomerInfowithFilter.GetCustomerObject e)
        {
            btnDelete.Visible = true;
            Customer = e.Customer;
        }

        private void ctrCustomerInfowithFilter1_OnFailSaveClick(object sender, EventArgs e)
        {
            ctrCustomerInfowithFilter1.ResetData();
            btnDelete.Visible = false;
            Customer = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to delete this Customer from system", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            if (!Customer.DeleteCustomer())
            {
                MessageBox.Show("Somting Error ,The Process Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrCustomerInfowithFilter1.ResetData();
                btnDelete.Visible = false;
                return;
            }

            ctrCustomerInfowithFilter1.ResetData();
            btnDelete.Visible = false;
            Customer = null;

        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
