using clsBuesnesLayer;
using Retaining_Car_Project.SystemCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.RentingsVehicles
{
    public partial class ctrPayRenting : UserControl
    {
        public ctrPayRenting()
        {
            InitializeComponent();
        }

        clsRenting Renting;
        static decimal TotalPrice = 0;
        static decimal TotalReturnMoney = 0;
        decimal DistanceCovered;
        decimal AdditionalFees = 0;

        public event EventHandler OnFinishClick;



        

        private void ctrPayRenting_Load(object sender, EventArgs e)
        {

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

        private void CalculateTotalPriceAndReturnMoney()
        {
            decimal Different = Renting.TotalPrice - Renting.TotalPaidPrice;
            if(Different <0)
            {
                TotalPrice = 0;
                lbTotalPrice.Text = TotalPrice.ToString() + "jd";
                TotalReturnMoney = Math.Abs(Different);
                lbReturnMoney.Text = TotalReturnMoney.ToString() + "jd";
                return;
            }

            TotalPrice = Different;
            lbTotalPrice.Text = TotalPrice.ToString() + "jd";
            TotalReturnMoney = 0;
            lbReturnMoney.Text = TotalReturnMoney.ToString() + "jd";
        }


        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            clsRenting renting = clsRenting.FindRentingByCustomerName(txtFirstName.Text, txtLastName.Text);
            if(renting==null)
            {
                MessageBox.Show("No Renting with this Customer Name,Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Renting = renting;
            ctrRentingInfo1.GetObjcetAndCreatClass(Renting);
            gbRentInfo.Enabled = true;
            rdRentID.Enabled = false;
            btnSearchCustomer.Enabled = false;
            txtInitialMil.Text = Renting.InitialMileage.ToString();
            CalculateTotalPriceAndReturnMoney();


        }

        private void txtRentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSeacthRent_Click(object sender, EventArgs e)
        {
            clsRenting renting=clsRenting.FindRentingByID(Convert.ToInt32(txtRentID.Text));
            if (renting == null)
            {
                MessageBox.Show("No Renting with this Renting ID,Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Renting = renting;
            ctrRentingInfo1.GetObjcetAndCreatClass(Renting);
            gbRentInfo.Enabled = true;
            rdCustomer.Enabled = false;
            btnSeacthRent.Enabled = false;
            txtInitialMil.Text = Renting.InitialMileage.ToString();
            CalculateTotalPriceAndReturnMoney();

        }

        private void rdRentID_CheckedChanged(object sender, EventArgs e)
        {
            gbCustomer.Visible = false;
            gbRentID.Visible = true;
        }

        private void rdCustomer_CheckedChanged(object sender, EventArgs e)
        {
            gbRentID.Visible = false;
            gbCustomer.Visible = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFinalMileage.Text))
            {
                MessageBox.Show("You must Fill The FinalMileage IN text Box!");
                return;
            }


            DistanceCovered = Convert.ToDecimal(txtFinalMileage.Text) - Renting.InitialMileage;
            lbDistanseCoverd.Text = DistanceCovered.ToString();

            clsScheduling scheduling = clsScheduling.FindSchedulingByID(Renting.SechduleID);

            decimal TheAllowAmountOfDrvingInKm = 40 * scheduling.NumberOfDays;
           

            if(decimal.TryParse(txtAdditionalFees.Text,out decimal value))
            {
                AdditionalFees = value;
            }


            if(DistanceCovered>TheAllowAmountOfDrvingInKm)
            {
                decimal AmountOfExceeds = DistanceCovered - TheAllowAmountOfDrvingInKm;
                decimal FeesOfExceeds = AmountOfExceeds * 2;
                lbexceedKmFees.Text = FeesOfExceeds.ToString();

                TotalPrice += FeesOfExceeds+ AdditionalFees - TotalReturnMoney;
                lbTotalPrice.Text = TotalPrice.ToString();
                TotalReturnMoney = 0;
                lbReturnMoney.Text = TotalReturnMoney.ToString();
                AdditionalFees += FeesOfExceeds;
            }

        }

        private void txtFinalMileage_Validating(object sender, CancelEventArgs e)
        {
            if(Convert.ToDecimal(txtFinalMileage.Text) <=Renting.InitialMileage)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFinalMileage, "The Amount must be above initialMileage!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFinalMileage, "");
            }
        }


        private void _LoadDataToRenting()
        {
            Renting.DistanceCovered = DistanceCovered;
            Renting.FinalMileage = Convert.ToDecimal(txtFinalMileage.Text);
            Renting.ReturnDate = dateReturnDate.Value;
            Renting.IsActive = false;
            Renting.AddionalFees = AdditionalFees;
            Renting.Note = txtNot.Text;
        }

        private bool UpdateRenting()
        {
            _LoadDataToRenting();
            if(!Renting.Save())
            {
                MessageBox.Show("The Process has been Canceled,SomthingError!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnReturnPay_Click(object sender, EventArgs e)
        {
            if(Renting.IsPaid)
            {
                MessageBox.Show("This Person already Paid the renting fees!");
                return;
            }



            if(! UpdateRenting())
            {
                MessageBox.Show("Please Try Again !");
                return;
            }

            FastPayment frm = new FastPayment(Renting);
            frm.ShowDialog();

            btnPayNow.Enabled = false;
            btnRentPay.Enabled = false;

        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            if(TotalPrice==0)
            {
                MessageBox.Show("This Person already paid everything , you can use Finish button");
            }

            if (!UpdateRenting())
            {
                MessageBox.Show("Please Try Again !");
                return;
            }

            FastPayment frm = new FastPayment(TotalPrice);
            frm.ShowDialog();

            btnFinish.Enabled = true;
            btnPayNow.Enabled = false;
            btnRentPay.Enabled = false;
            


        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            OnFinishClick(null, null);
        }
    }
}
