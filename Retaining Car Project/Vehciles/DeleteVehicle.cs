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

namespace Retaining_Car_Project.Vehciles
{
    public partial class DeleteVehicle : Form
    {
        public DeleteVehicle()
        {
            InitializeComponent();
        }

        clsVehicles vehicle;

        private void btnExsits_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this vehicle \n infromation:this operation will not delete car from system only details","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                MessageBox.Show("The Process Cancled!");
                return;
            }    


            if(!vehicle.DeleteVehicle())
            {
                MessageBox.Show("The Process Cancled ,Somthing Error!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            MessageBox.Show("The Process has Done Succesfully!");
            this.Close();


        }

        private void DeleteVehicle_Load(object sender, EventArgs e)
        {

        }

        private void ctrSearchVehicleInfo1_OnSearchClick(object sender, ctrSearchVehicleInfo.GetObjectOfVehcil e)
        {
            btnDelete.Visible = true;
            vehicle = e.Vehicle;
        }
    }
}
