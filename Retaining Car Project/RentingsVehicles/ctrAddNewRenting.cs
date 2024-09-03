using clsBuesnesLayer;
using Retaining_Car_Project.Drivers;
using Retaining_Car_Project.SystemCustomer;
using Retaining_Car_Project.Vehciles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.RentingsVehicles
{
    public partial class ctrAddNewRenting : UserControl
    {
        public ctrAddNewRenting()
        {
            InitializeComponent();
        }

        clsCustomers Customer;
        clsVehicles Vehicle;
        int? DriverID;

        static decimal TotalPrice;
        static decimal TotalPaidAmount;
        static decimal PricePerDay;
        clsScheduling NewSchedule = new clsScheduling();
        clsRenting NewRenting = new clsRenting();

        bool flagReturnPayDone = false;

        public event EventHandler OnEndOfRenting;

        private DataTable _LoadDataToTypeBox()
        {
            DataTable dt = new DataTable();

            dt = clsVehicles.GetAllCarTypesInTheSystem();

            return dt;
        }

        private void _LoadDataToModelBox(string CarName)
        {
            DataTable dt = new DataTable();
            dt = clsVehicles.GetAllModelsForTheVehicl(CarName);

            _PerFormCarModelsBox(dt);

        }

        private DataTable _LoadDataToDriverBox()
        {
            DataTable dt = new DataTable();

            dt = clsDrivers.GetAllAvaialableDrivers();
            return dt;
        }

        private void _PerFormCarTypeBox(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                cbxCarType.Items.Add(row["CarName"]);
            }


            cbxCarType.SelectedIndex = 0;

        }

        private void _PerFormCarModelsBox(DataTable dt)
        {
            cbxCarModel.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                cbxCarModel.Items.Add(row["ModelName"]);
            }

            cbxCarModel.SelectedIndex = 0;
        }

        private void _PerFormDriverBox(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                cbxAvaDriver.Items.Add(row["DriverName"]);
            }

            if (cbxAvaDriver.Items.Count != 0)
            {
                cbxAvaDriver.SelectedIndex = 0;
            }
        }



        private void ctrAddNewRenting_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                var data = _LoadDataToTypeBox();

                this.Invoke((Action)(() =>
                {
                    _PerFormCarTypeBox(data);

                }));
            });
        }



        private void SetCustomerID(int CustomerID)
        {
            txtCustomerID.Text = CustomerID.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateAddCustomers frm = new UpdateAddCustomers();
            frm.OnAddNew += SetCustomerID;
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Customer = clsCustomers.FindCustomerByID(Convert.ToInt32(txtCustomerID.Text));
            if (Customer == null)
            {
                MessageBox.Show("There is somthing Error with connection Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            gbNewRent.Enabled = true;
            btnSearch.Enabled = false;

        }

        private void cbxCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadDataToModelBox(cbxCarType.Text);

        }

        private void btnCheckCar_Click(object sender, EventArgs e)
        {
            DateTime? ReturnDateForTheCar = null;


            if (!clsVehicles.IsVehicleAvialableForRenting(cbxCarType.Text, cbxCarModel.Text, ref ReturnDateForTheCar))
            {
                lbHeadOfCar.Visible = true;
                lbCarInfo.Visible = false;
                MessageBox.Show("It will be available in " + ReturnDateForTheCar.ToString());
                return;
            }
      
            Vehicle = clsVehicles.FindVehicleByCarTypeAndModelName(cbxCarType.Text, cbxCarModel.Text);
           

            if(Vehicle==null)
            {
                MessageBox.Show("This Car does not belong to any vehicle , You must Add this Car to Vehicle!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbHeadOfCar.Visible = false;
            lbCarInfo.Visible = true;
            PricePerDay = clsVehicles.GetPriceForRentingVehciel(Vehicle.VehicleID);
            numaricNumberOfDays_ValueChanged(null, null);

        }

        private void lbCarInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VehicleInfo frm = new VehicleInfo(Vehicle);
            frm.ShowDialog();
        }

        private void numaricNumberOfDays_Validating(object sender, CancelEventArgs e)
        {
            if (numaricNumberOfDays.Value == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(numaricNumberOfDays, "The Number is must be over 0 days");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(numaricNumberOfDays, "");
            }
        }

        private void cbDriver_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDriver.Checked == false)
            {
                gbDriver.Enabled = false;
                lbDriverInfo.Visible = false;
                DriverID = null;
                TotalPrice -= 50;
                lbTotalPrice.Text = TotalPrice.ToString() + "jd";

                return;
            }

            if (cbxAvaDriver.Items.Count == 0)
            {
                _PerFormDriverBox(_LoadDataToDriverBox());
            }

            gbDriver.Enabled = true;
            TotalPrice += 50;
            lbTotalPrice.Text = TotalPrice.ToString() + "jd";


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string[] Parts = cbxAvaDriver.Text.Split(' ');

            DriverID = clsDrivers.GetDriverIDByFullName(Parts[0], Parts[1]);
            lbDriverInfo.Visible = true;

        }

        private void lbDriverInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsDrivers drivers = clsDrivers.FindDriverByID((int)DriverID);
            DriverInfo frm = new DriverInfo(drivers);
            frm.ShowDialog();
        }

        private void numaricNumberOfDays_ValueChanged(object sender, EventArgs e)
        {
            TotalPrice = PricePerDay * numaricNumberOfDays.Value;
            lbTotalPrice.Text = TotalPrice.ToString() + "jd";
        }


        private void LoadDataToScheduleObject()
        {
            NewSchedule.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            NewSchedule.VehicleID = Vehicle.VehicleID;
            NewSchedule.DateOfSechedule = DateTime.Now;
            NewSchedule.NumberOfDays = Convert.ToInt32(numaricNumberOfDays.Value);
            NewSchedule.StartFrom = dateTimeStart.Value;
            NewSchedule.Status = 1;
            NewSchedule.DriverID = DriverID;
            NewSchedule.EndAt = dateTimeStart.Value.AddDays((int)numaricNumberOfDays.Value - 1);
        }

        private void LoadDataToRentingObject()
        {
            NewRenting.SechduleID = NewSchedule.ScheduleID;
            NewRenting.InitialMileage = Vehicle.CurrentMillageCounter;
            NewRenting.IsActive = true;
            NewRenting.TotalPrice = TotalPrice;
            NewRenting.IsPaid = false;
            NewRenting.TotalPaidPrice = 0;
        }

     

        private bool MakingNewRenting()
        {
            LoadDataToScheduleObject();

            if(!NewSchedule.Save())
            {
                MessageBox.Show("There is Somting Error,The Process Canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            LoadDataToRentingObject();

            if(!NewRenting.Save())
            {
                MessageBox.Show("There is Somting Error,The Process Canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }



        private void btnReturnPay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to Save this Renting Paper \n without Paid Amount!", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                MessageBox.Show("The Process Cancled!");
                return;
            }

            if(!MakingNewRenting())
            {
                MessageBox.Show("Please Try again!");
                return;
            }

            MessageBox.Show("The Renting has been succesfully Saved!");

            flagReturnPayDone = true;


        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {

            if(flagReturnPayDone==false)
            {
                if (!MakingNewRenting())
                {
                    MessageBox.Show("Please Try again!");
                    return;
                }
            }

            FastPayment frm = new FastPayment(NewRenting);
            frm.ShowDialog();
            OnEndOfRenting?.Invoke(null, null);

        }
    }
}
