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
    public partial class CustomerInfo : Form
    {
        public CustomerInfo(clsCustomers Customer)
        {
            InitializeComponent();
            ctrCustomerInfo1.GetObjectAndCreatClass(Customer);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
