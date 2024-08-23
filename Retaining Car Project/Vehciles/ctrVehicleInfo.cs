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
    public partial class ctrVehicleInfo : UserControl
    {
        public ctrVehicleInfo()
        {
            InitializeComponent();
        }

        clsVehicles Vehicles;


        private void _LoadDataToControl()
        {
            if (Vehicles != null)
            {
                txtVehiclID.Text = Vehicles.VehicleID.ToString();
                txtCarTypeID.Text = Vehicles.CarTypeID.ToString();
                txtModelID.Text = Vehicles.CarModelID.ToString();
                cbxColor.Text = clsVehicles.GetColorNameByID(Vehicles.ColorID);
                cbxRentStatus.SelectedIndex = Vehicles.RentStatusID - 1;
                txtProducedYear.Text = Vehicles.ProducedYear;
                txtmillageCounter.Text = Vehicles.CurrentMillageCounter.ToString();
                txtCarNumber.Text = Vehicles.CarNumber;
                txtIssue.Text = Vehicles.IsHasDamaged;
                lbLastRentingDate.Text = Vehicles.LastDateForRent == null ? "Never Rented" : Convert.ToDateTime(Vehicles.LastDateForRent).ToShortDateString();

            }
        }

        public void GetObjectAndCreatClass(clsVehicles vehicles)
        {
            this.Vehicles = vehicles;
            _LoadDataToControl();   
        }


        private void ctrVehicleInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
