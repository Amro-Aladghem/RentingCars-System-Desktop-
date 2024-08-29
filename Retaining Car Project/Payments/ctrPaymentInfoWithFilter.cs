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

namespace Retaining_Car_Project.Payments
{
    public partial class ctrPaymentInfoWithFilter : UserControl
    {
        public ctrPaymentInfoWithFilter()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                MessageBox.Show("You must input somthing First!","Error",MessageBoxButtons.OK);
                return;
            }


            clsPayment payment = clsPayment.FindPaymentByRentID(Convert.ToInt32(txtSearch.Text));
            
            if(payment==null)
            {
                MessageBox.Show("No Payment with this Rent ID, Try anOther one!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ctrPaymentInfo1.GetObjectAndCreateClass(payment);

        }
    }
}
