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
    public partial class VehicleInfo : Form
    {
        public VehicleInfo(clsVehicles vehicle)
        {
            InitializeComponent();
            ctrVehicleInfo1.GetObjectAndCreatClass(vehicle);
        }
      

        private void VehicleInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExists_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
