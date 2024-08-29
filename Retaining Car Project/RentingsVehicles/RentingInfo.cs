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

namespace Retaining_Car_Project.RentingsVehicles
{
    public partial class RentingInfo : Form
    {
        public RentingInfo(clsRenting Renting)
        {
            InitializeComponent();
            ctrRentingInfo1.GetObjcetAndCreatClass(Renting);
        }

    

        private void RentingInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
