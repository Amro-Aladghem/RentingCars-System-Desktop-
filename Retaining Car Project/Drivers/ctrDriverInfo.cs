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
    public partial class ctrDriverInfo : UserControl
    {
        public ctrDriverInfo()
        {
            InitializeComponent();
        }


        clsDrivers Driver;

        public void GetObjectAndCreatClass(clsDrivers Driver)
        {
            this.Driver= Driver;
            _LoadData();
        }

        private void _LoadData()
        {
            if(Driver!=null)
            {
                txtFirstName.Text=Driver.FirstName;
                lbDriverID.Text = Driver.DriverID.ToString();
                txtLastName.Text=Driver.LastName;
                txtPhone.Text = Driver.PhoneNumber;
                numericUpDown1.Value = Driver.Salary;
                cbxNationality.Text=Driver.Nationality;
            }

        }


        private void ctrDriverInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
