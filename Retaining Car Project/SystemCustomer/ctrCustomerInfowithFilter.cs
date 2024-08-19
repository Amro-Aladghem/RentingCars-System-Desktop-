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
    public partial class ctrCustomerInfowithFilter : UserControl
    {
        public ctrCustomerInfowithFilter()
        {
            InitializeComponent();
        }

        public class GetCustomerObject:EventArgs
        {
            public clsCustomers Customer { get; set; }

            public GetCustomerObject(clsCustomers customer)            {
                Customer = customer;
            }

        }

        public event EventHandler<GetCustomerObject> OnSaveClick;
        public event EventHandler OnFailSaveClick;

        public void ResetData()
        {
            txtSearch.Text = "";
            ctrCustomerInfo1.ResetData();
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
            if (txtSearch.Text == "")
            {
                MessageBox.Show("You must fill the ID Text Box!");
                return;
            }

            clsCustomers Customer = clsCustomers.FindCustomerByID(Convert.ToInt32(txtSearch.Text));
            if(Customer == null)
            {
                MessageBox.Show("The Customer Not Found , Try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                OnFailSaveClick?.Invoke(null, null);
                return;
            }

            ctrCustomerInfo1.GetObjectAndCreatClass(Customer);
            OnSaveClick?.Invoke(sender, new GetCustomerObject(Customer));


        }

        private void ctrCustomerInfowithFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
