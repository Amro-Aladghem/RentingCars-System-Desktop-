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
    public partial class AddVehcilePrice : Form
    {
        public AddVehcilePrice()
        {
            InitializeComponent();
        }

        int VehicleID;



        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!='.')
            {
                e.Handled = true;
            }
        }

        private void ctrSearchVehicleInfo1_OnSearchClick(object sender, Vehciles.ctrSearchVehicleInfo.GetObjectOfVehcil e)
        {
            VehicleID = e.Vehicle.VehicleID;
            txtPrice.Enabled = true;
            btnSave.Enabled=true; 
        }

        private void AddVehcilePrice_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPrice.Text=="")
            {
                MessageBox.Show("You must Fill Price Text Box!");
                return;
            }

            if(MessageBox.Show("Are You sure to Add this Price to this Vehicle!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }

            if(!clsSystemRules.AddPriceToVehicle(VehicleID,Convert.ToDecimal(txtPrice.Text)))
            {
                MessageBox.Show("The Process Cancled, Somthing Error Please Try again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Proces has done Successfully,You can Cloes this window!");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ctrSearchVehicleInfo1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
