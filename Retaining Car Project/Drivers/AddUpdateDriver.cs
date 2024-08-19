using clsBuesnesLayer;
using Retaining_Car_Project.Properties;
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
    public partial class AddUpdateDriver : Form
    {
        enum eMode { AddNew=1,Update=2 }
        eMode Mode;
        public AddUpdateDriver()
        {
            InitializeComponent();
            Mode=eMode.AddNew;
            lbHead.Text = "Add Driver:";
            pictureBox1.Image = Resources.add__1_;
        }
        public AddUpdateDriver(clsDrivers Driver)
        {
            InitializeComponent();
            ctrAddUpdateCustomer1.GetObjectAndCreatClass(Driver);
            Mode = eMode.Update;
            lbHead.Text = "Update Driver:";
            pictureBox1.Image = Resources.business;
        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrAddUpdateCustomer1_OnSaveClik(object sender, EventArgs e)
        {
            if(Mode==eMode.AddNew)
            {
                lbHead.Text = "Update Driver:";
                pictureBox1.Image= Resources.business;
                Mode=eMode.Update;
            }
        }

        private void AddUpdateDriver_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
