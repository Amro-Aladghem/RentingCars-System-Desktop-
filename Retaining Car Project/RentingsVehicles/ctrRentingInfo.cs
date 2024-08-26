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
    public partial class ctrRentingInfo : UserControl
    {
        public ctrRentingInfo()
        {
            InitializeComponent();

        }

        clsRenting Renting;
        clsScheduling Scheduling;

        public void GetObjcetAndCreatClass(clsRenting Renting)
        {
            this.Renting=Renting;
            Scheduling = clsScheduling.FindSchedulingByID(Renting.SechduleID);
           _LoadData();
        }


        private void _LoadData()
        {
            if(Renting !=null)
            {
                lbScheduleID.Text = Renting.SechduleID.ToString();
                lbVehicleID.Text = Scheduling.VehicleID.ToString();
                lbCustomerID.Text = Scheduling.CustomerID.ToString();
                lbDateSchedule.Text = Scheduling.DateOfSechedule.ToShortDateString();
                lbDayNum.Text = Scheduling.NumberOfDays.ToString();
                lbDriverID.Text = Scheduling.DriverID != null ? "Yes" : "NO";
                lbisPaid.Text = Renting.IsPaid ? "Yes" : "No";
                lbTotalPrice.Text = Renting.TotalPrice.ToString() + "jd";
                lbPaidAmount.Text = Renting.TotalPaidPrice.ToString() + "jd";
                lbStartDate.Text = Scheduling.StartFrom.ToShortDateString();
            }

        }

        private void ctrRentingInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
