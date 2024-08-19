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
    public partial class EnterCustomerID : Form
    {
        public EnterCustomerID()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("You must fill the ID Text Box!");
                return;
            }

            clsCustomers Customer = clsCustomers.FindCustomerByID(Convert.ToInt32(textBox1.Text));
            if (Customer == null)
            {
                MessageBox.Show("The Customer Not Found , Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateAddCustomers frm = new UpdateAddCustomers(Customer);
            frm.ShowDialog();
            this.Close();

            
        }
    }
}
