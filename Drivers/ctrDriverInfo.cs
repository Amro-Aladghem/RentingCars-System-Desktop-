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

namespace RetainCarsProject.Drivers
{
    public partial class ctrDriverInfo : UserControl
    {
        public ctrDriverInfo()
        {
            InitializeComponent();
        }

        clsDrivers Drivers;
        public void GetIDAndCreatClass(clsDrivers drivers)
        {
            Drivers= drivers;
            _LoadData();
        }

        private void _LoadData()
        {
            if(Drivers !=null)
            {
                txtFirstName.Text= Drivers.FirstName;
                txtLastName.Text= Drivers.LastName;
                txtNationality.Text=Drivers.Nationality;
                txtPhone.Text = Drivers.PhoneNumber;
                txtSalary.Text = Drivers.Salary.ToString();
                lbDriverID.Text = Drivers.DriverID.ToString();
                txtDateOfSet.Text = Drivers.DateOfSet.ToShortDateString();
                
            }
        }

        public void ResetData()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtNationality.Text = "";
            txtSalary.Text = "";
            lbDriverID.Text = "";
            txtDateOfSet.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ctrDriverInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
