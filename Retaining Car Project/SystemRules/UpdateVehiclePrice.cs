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

namespace Retaining_Car_Project.SystemRules
{
    public partial class UpdateVehiclePrice : Form
    {
        public UpdateVehiclePrice()
        {
            InitializeComponent();
        }

        int VehicleID;






        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!='.')
            {
                e.Handled = true;
            }
        }

        private void ctrSearchVehicleInfo1_OnSearchClick(object sender, Vehciles.ctrSearchVehicleInfo.GetObjectOfVehcil e)
        {
            decimal? OldPrice = 0;
            OldPrice = clsVehicles.GetPriceForRentingVehciel(e.Vehicle.VehicleID);
            if(OldPrice==null)
            {
                MessageBox.Show("This Vehicle does not have a Price, You must Add  Price Firstly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VehicleID = e.Vehicle.VehicleID;
            lbOldPrice.Text = OldPrice.ToString() + "jd";
            txtPrice.Enabled = true;
            btnSave.Enabled = true;
        }

        private void UpdateVehiclePrice_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                MessageBox.Show("You must Fill Price Text Box!");
                return;
            }

            if (MessageBox.Show("Are You sure to Add this Price to this Vehicle!", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            if (!clsSystemRules.UpdatePriceForVehicle(VehicleID, Convert.ToDecimal(txtPrice.Text)))
            {
                MessageBox.Show("The Process Cancled, Somthing Error Please Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Proces has done Successfully,You can Cloes this window!");
        }
    }
}
