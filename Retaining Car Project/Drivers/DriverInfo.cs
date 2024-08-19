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
    public partial class DriverInfo : Form
    {
        public DriverInfo(clsDrivers Driver)
        {
            InitializeComponent();
            ctrDriverInfo1.GetObjectAndCreatClass(Driver);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DriverInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
