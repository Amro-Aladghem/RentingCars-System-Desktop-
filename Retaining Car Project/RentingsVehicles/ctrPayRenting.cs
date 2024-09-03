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

        bool flagFinishCalculate = false;

        public event EventHandler OnFinishClick;



        

        private void ctrPayRenting_Load(object sender, EventArgs e)
        {
            rdRentID.Checked = true;
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

        private void _CheckIFCustomerHasLateFeesAndPerform()
        {
            clsScheduling scheduling = clsScheduling.FindSchedulingByID(Renting.SechduleID);
            decimal LateFeesAmount;

            int DifferenceDay = Convert.ToInt32((dateReturnDate.Value -scheduling.EndAt).Days);
            lbLateFees.Text = "You must Add Late Fees for " + DifferenceDay.ToString() + " Days!";
            lbLateFees.Visible = true;
        }



        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            clsRenting renting = clsRenting.FindRentingByCustomerName(txtFirstName.Text, txtLastName.Text);
            if(renting==null)
            {
                MessageBox.Show("No Active Renting with this Customer Name,Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Renting = renting;
            ctrRentingInfo1.GetObjcetAndCreatClass(Renting);

            rdRentID.Enabled = false;
            btnSearchCustomer.Enabled = false;
            txtInitialMil.Text = Renting.InitialMileage.ToString();
            CalculateTotalPriceAndReturnMoney();
            gbReturnInfo.Enabled = true;
            btnWithoutPay.Enabled = true;


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
                MessageBox.Show("No Active Renting with this Renting ID,Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Renting = renting;
            ctrRentingInfo1.GetObjcetAndCreatClass(Renting);

            rdCustomer.Enabled = false;
            btnSeacthRent.Enabled = false;
            txtInitialMil.Text = Renting.InitialMileage.ToString();
            CalculateTotalPriceAndReturnMoney();
            gbReturnInfo.Enabled = true;
            btnWithoutPay.Enabled = true;

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

            TotalPrice = Renting.TotalPrice - Renting.TotalPaidPrice;
            AdditionalFees = 0;

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
            else
            {
                lbTotalPrice.Text = TotalPrice.ToString();
                lbReturnMoney.Text = TotalReturnMoney.ToString();
            }

            flagFinishCalculate = true;
            _CheckIFCustomerHasLateFeesAndPerform();

        }

        private void txtFinalMileage_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFinalMileage.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFinalMileage, "You must Fill it!");
            }
            else
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
            if (flagFinishCalculate == false)
            {
                MessageBox.Show("You must calculate before Payment!");
                return;
            }


            if (Renting.IsPaid)
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

            TotalPrice -= Renting.TotalPrice;
            lbTotalPrice.Text = TotalPrice.ToString();
            btnFinish.Enabled = false;

        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            if(flagFinishCalculate==false)
            {
                MessageBox.Show("You must calculate before Payment!");
                return;
            }


            if(TotalPrice==0)
            {
                MessageBox.Show("This Person already paid everything , you can use Finish button");
                btnFinish.Enabled = true;
                return;
            }


            if (!UpdateRenting())
            {
                MessageBox.Show("Please Try Again !");
                return;
            }



            FastPayment frm = new FastPayment(TotalPrice,Renting);
            frm.ShowDialog();

            btnFinish.Enabled = true;
            btnPayNow.Enabled = false;
            btnRentPay.Enabled = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (flagFinishCalculate == false)
            {
                MessageBox.Show("You must calculate before Payment!");
                return;
            }


            if (MessageBox.Show("Are You Sure to Finish?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                return;
            }

            if(Renting.IsActive==false && Renting.IsPaid)
            {
                MessageBox.Show("This Renting already Finished , You Can close this windows!");
                return;
            }

            if (!UpdateRenting())
            {
                MessageBox.Show("Please Try Again !");
                return;
            }
            OnFinishClick?.Invoke(null, null);
        }

        private void btnWithoutPay_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to continue without Paying \n the AdditionalFees!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }

            if (!UpdateRenting())
            {
                MessageBox.Show("Please Try Again !");
                return;
            }

            if (!clsRenting.MakeIsPaidFalse(Renting.RentID))
            {
                MessageBox.Show("Somting Error,The Procees Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been Done Successfully,You can close this Window!");

        }

        private void txtAdditionalFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!='.')
            {
                e.Handled = true;
            }
        }
    }
}
