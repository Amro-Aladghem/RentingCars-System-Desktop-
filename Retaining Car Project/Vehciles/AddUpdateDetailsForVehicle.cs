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
    public partial class AddUpdateDetailsForVehicle : Form
    {
        public AddUpdateDetailsForVehicle()
        {
            InitializeComponent();
        }

        public AddUpdateDetailsForVehicle(string CarTypeName,string ModelName)
        {
            InitializeComponent();
            ctrAdding_UpdatingVehicleDetails1.ActivateSearchClick(CarTypeName,ModelName);
            lbHead.Text = "Update Details :";
        }

        private void AddUpdateDetailsForVehicle_Load(object sender, EventArgs e)
        {

        }

        private void ctrAdding_UpdatingVehicleDetails1_OnSearchClick(object sender, ctrAdding_UpdatingVehicleDetails.GetTypeOfMood e)
        {
            if(e.mode==ctrAdding_UpdatingVehicleDetails.eMode.AddNew)
            {
                lbHead.Text = "Adding Details :";
            }
            else
            {
                lbHead.Text = "Updating Details :";
            }
        }

        private void btnExsits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
