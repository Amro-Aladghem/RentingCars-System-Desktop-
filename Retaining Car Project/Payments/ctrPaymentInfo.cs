using clsBuesnesLayer;
using Retaining_Car_Project.RentingsVehicles;
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
    public partial class ctrPaymentInfo : UserControl
    {
        public ctrPaymentInfo()
        {
            InitializeComponent();
        }

        clsPayment Payment;

        public void GetObjectAndCreateClass(clsPayment payment)
        {
            Payment = payment;
            _LoadData();
            lbMoreInfoRent.Visible = true;
        }

        private void _LoadData()
        {
            if(Payment!=null)
            {
                lbPayID.Text = Payment.PaymentID.ToString();
                lbRentID.Text = Payment.RentID.ToString();
                lbPaidAmount.Text = Payment.PaidAmount.ToString();
                lbReturnAmount.Text = Payment.ReturnAmount.ToString();
                txtNote.Text= Payment.Note.ToString();
                lbDate.Text = Payment.DateOfPaid.ToShortDateString();
            }
        }



        private void ctrPaymentInfo_Load(object sender, EventArgs e)
        {

        }

        private void lbMoreInfoRent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsRenting Renting = clsRenting.FindRentingByID(Payment.RentID);
            RentingInfo frm = new RentingInfo(Renting);
            frm.ShowDialog();
        }
    }
}
