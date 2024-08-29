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
    public partial class PaymentInfo : Form
    {
        public PaymentInfo(clsPayment payment)
        {
            InitializeComponent();
            ctrPaymentInfo1.GetObjectAndCreateClass(payment);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaymentInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
