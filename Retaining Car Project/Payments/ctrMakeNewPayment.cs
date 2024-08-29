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
    public partial class ctrMakeNewPayment : UserControl
    {
        public ctrMakeNewPayment()
        {
            InitializeComponent();
        }

        clsRenting Renting;
        clsPayment NewPayment = new clsPayment();
        decimal ReturnAmount = 0;
        decimal TotalPrice = 0;

        
       

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!='.') 
            {
                e.Handled = true;
            }
        }

        private void txtReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void rdRentID_CheckedChanged(object sender, EventArgs e)
        {
            gbRentID.Visible = true;
            gbCustomer.Visible = false;
        }

        private void rdCustomer_CheckedChanged(object sender, EventArgs e)
        {
            gbCustomer.Visible = true;
            gbRentID.Visible = false;
        }

        private void _LoadData()
        {
            decimal Difference = (Renting.TotalPrice + Renting.AddionalFees) - Renting.TotalPaidPrice;
            if(Difference>0)
            {
                TotalPrice=Difference;
                ReturnAmount = 0;
            }
            else
            {
                TotalPrice=0;
                ReturnAmount = Math.Abs(Difference);
            }

            lbPaymentAmount.Text = TotalPrice.ToString() + "jd";
            lbReason.Text = "Additional Fees";
        }


        private void btnSeacthRent_Click(object sender, EventArgs e)
        {
            clsRenting renting = clsRenting.FindRentingByID(Convert.ToInt32(txtRentID.Text));

            if (renting == null)
            {
                MessageBox.Show("No Renting with this Renting ID,Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Renting = renting;

            if (((Renting.TotalPrice + Renting.AddionalFees) - Renting.TotalPaidPrice)==0)
            {
                MessageBox.Show("This Renting is already Paid , You Cant Add New Payment For it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrRentingInfo1.GetObjcetAndCreatClass(Renting);

            _LoadData();

            rdCustomer.Enabled = false;
            btnSeacthRent.Enabled = false;
            gbPaymentInfo.Enabled = true;

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            clsRenting renting = clsRenting.FindRentingByCustomerName(txtFirstName.Text, txtLastName.Text);
            if (renting == null)
            {
                MessageBox.Show("No Renting with this Customer Name,Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Renting = renting;

            if (((Renting.TotalPrice + Renting.AddionalFees) - Renting.TotalPaidPrice) == 0)
            {
                MessageBox.Show("This Renting is already Paid , You Cant Add New Payment For it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrRentingInfo1.GetObjcetAndCreatClass(Renting);

            _LoadData();

            rdRentID.Enabled = false;
            btnSearchCustomer.Enabled = false;
            gbPaymentInfo.Enabled = true;


        }

        private void ctrMakeNewPayment_Load(object sender, EventArgs e)
        {

        }

      

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(ReturnAmount==0)
            {
                if(Convert.ToDecimal(txtPaid.Text)<TotalPrice)
                {
                    MessageBox.Show("The Paid Amount less than Total Price!");
                    return;
                }

                ReturnAmount = Convert.ToDecimal(txtPaid.Text) - TotalPrice;
                txtReturn.Text=ReturnAmount.ToString();
                MessageBox.Show("Evereything is OK ,You can Make Payment!");
                return;
            }
         
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to continue?","Question!",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.Cancel) 
            {
                return;
            }

            NewPayment.RentID = Renting.RentID;
            NewPayment.PaidAmount = Convert.ToDecimal(txtPaid.Text);
            NewPayment.ReturnAmount = ReturnAmount;
            NewPayment.Note=txtNote.Text;

            if(!NewPayment.save())
            {
                MessageBox.Show("Somting Error,The Procees Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been Done Successfully!");
            btnMakePayment.Enabled = false;

        }

        private void btnSeacthRent_Click_1(object sender, EventArgs e)
        {
            clsRenting renting = clsRenting.FindRentingByIDNotActive(Convert.ToInt32(txtRentID.Text));

            if (renting == null)
            {
                MessageBox.Show("No Renting with this Renting ID,Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Renting = renting;

            if (((Renting.TotalPrice + Renting.AddionalFees) - Renting.TotalPaidPrice) == 0)
            {
                MessageBox.Show("This Renting is already Paid , You Cant Add New Payment For it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrRentingInfo1.GetObjcetAndCreatClass(Renting);

            _LoadData();

            rdCustomer.Enabled = false;
            btnSeacthRent.Enabled = false;
            gbPaymentInfo.Enabled = true;
        }

        private void btnSearchCustomer_Click_1(object sender, EventArgs e)
        {
            clsRenting renting = clsRenting.FindRentingByCustomerNameNotActive(txtFirstName.Text, txtLastName.Text);
            if (renting == null)
            {
                MessageBox.Show("No Renting with this Customer Name,Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Renting = renting;

            if (((Renting.TotalPrice + Renting.AddionalFees) - Renting.TotalPaidPrice) == 0)
            {
                MessageBox.Show("This Renting is already Paid , You Cant Add New Payment For it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrRentingInfo1.GetObjcetAndCreatClass(Renting);

            _LoadData();

            rdRentID.Enabled = false;
            btnSearchCustomer.Enabled = false;
            gbPaymentInfo.Enabled = true;
        }


    }
}
