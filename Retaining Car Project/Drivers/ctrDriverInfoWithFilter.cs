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

namespace Retaining_Car_Project.Drivers
{
    public partial class ctrDriverInfoWithFilter : UserControl
    {
        public ctrDriverInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctrDriverInfoWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                MessageBox.Show("You must Fill the text Box");
                return;
            }

            clsDrivers Driver=clsDrivers.FindDriverByID(Convert.ToInt32(txtSearch.Text));

            if(Driver==null)
            {
                MessageBox.Show("This Driver Not Found!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
            }

            ctrDriverInfo1.GetObjectAndCreatClass(Driver);


        }
    }
}
