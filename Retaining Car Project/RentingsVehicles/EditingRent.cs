using clsBuesnesLayer;
using Retaining_Car_Project.Drivers;
using Retaining_Car_Project.Vehciles;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.RentingsVehicles
{
    public partial class EditingRent : UserControl
    {
        public EditingRent()
        {
            InitializeComponent();
        }

        public event EventHandler OnFinishClick;


        decimal TotalPrice = 0;

        clsRenting Renting;
        decimal TotalReturnMoney = 0;
        clsVehicles Vehicle;
        clsScheduling Scheduling;
        decimal PricePerDay = 0;

        private void _LoadData()
        {

            
            Scheduling = clsScheduling.FindSchedulingByID(Renting.SechduleID);

            dateTimeStart.Value = Scheduling.StartFrom;
            numaricDayNum.Value = Scheduling.NumberOfDays;
            cbwithdriver.Checked = Scheduling.DriverID == null ? false : true;

            btnCalculate.Enabled = true;

            PricePerDay = clsVehicles.GetPriceForRentingVehciel(Scheduling.VehicleID);
        }


        bool flageDriverChang = false;
        bool flageVehicleChang = false;
        bool flageNumberOfDay = false;
        bool flageStartfrom = false;


       

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
              cbxTypes.Items.Add(row["CarName"]);
            }


            cbxTypes.SelectedIndex = 0;

        }

        private void _PerFormCarModelsBox(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                cbxModels.Items.Add(row["ModelName"]);
            }

            cbxModels.SelectedIndex = 0;
        }

        private void _PerFormDriverBox(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
               cbxDriver.Items.Add(row["DriverName"]);
            }

            if (cbxDriver.Items.Count != 0)
            {
                cbxDriver.SelectedIndex = 0;
            }
        }


        private void LoadNewDataToSchecduleObject()
        {
            if(flageVehicleChang)
            {
                Scheduling.VehicleID = Vehicle.VehicleID;
            }

            if(flageStartfrom)
            {
                Scheduling.StartFrom = dateTimeStart.Value;
            }

            if(flageNumberOfDay)
            {
                Scheduling.NumberOfDays = Convert.ToInt32(numaricDayNum.Value);
            }

            if (flageDriverChang)
            {
                if (cbwithdriver.Checked == false)
                {
                    Scheduling.DriverID = null;
                }
                else
                {
                    
                    string[] Parts = cbxDriver.Text.Split(' ');

                    int DriverID = clsDrivers.GetDriverIDByFullName(Parts[0], Parts[1]);

                    Scheduling.DriverID = DriverID;

                }
            }

        }



        private void rdRentID_CheckedChanged(object sender, EventArgs e)
        {
            gbCustomer.Visible=false;
            gbRentID.Visible = true;
        }

        private void rdCustomer_CheckedChanged(object sender, EventArgs e)
        {
            gbRentID.Visible = false;
            gbCustomer.Visible = true;
        }

        private void EditingRent_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                // Simulate loading small data
                var dataType = _LoadDataToTypeBox();
                var dataDriver = _LoadDataToDriverBox();

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    _PerFormCarTypeBox(dataType);
                    _PerFormDriverBox(dataDriver);
                   
                }));
            });
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            clsRenting renting = clsRenting.FindRentingByCustomerName(txtFirstName.Text, txtLastName.Text);
            if (renting == null)
            {
                MessageBox.Show("No Renting with this Customer Name,Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Renting = renting;
            ctrRentingInfo1.GetObjcetAndCreatClass(Renting);

            rdRentID.Enabled = false;
            btnSearchCustomer.Enabled = false;

            _LoadData();
            TotalPrice = Math.Abs(Renting.TotalPaidPrice - Renting.TotalPrice);
            lbTotalPrice.Text = TotalPrice.ToString() + "jd";
            
        }

        private void txtRentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled= true;
            }
        }

        private void btnSeacthRent_Click(object sender, EventArgs e)
        {
            clsRenting renting = clsRenting.FindRentingByID(Convert.ToInt32(txtRentID.Text));
            if (renting == null)
            {
                MessageBox.Show("No Renting with this Renting ID,Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Renting = renting;
            ctrRentingInfo1.GetObjcetAndCreatClass(Renting);

            rdCustomer.Enabled = false;
            btnSeacthRent.Enabled = false;
            _LoadData();
            TotalPrice = Math.Abs(Renting.TotalPaidPrice - Renting.TotalPrice);
            lbTotalPrice.Text = TotalPrice.ToString() + "jd";
        }
        

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DateTime? ReturnDateForTheCar = null;


            if (!clsVehicles.IsVehicleAvialableForRenting(cbxTypes.Text, cbxModels.Text, ref ReturnDateForTheCar))
            {
                lbHeader.Visible = true;
                lbCarInfo.Visible = false;
                MessageBox.Show("It will be available in " + ReturnDateForTheCar.ToString());
                return;
            }
            else
            {
                lbHeader.Visible = false;
                Vehicle = clsVehicles.FindVehicleByCarTypeAndModelName(cbxTypes.Text, cbxModels.Text);
                lbCarInfo.Visible = true;
            }

            PricePerDay = clsVehicles.GetPriceForRentingVehciel(Vehicle.VehicleID);
            flageVehicleChang = true;
        }

        public void CalculateReturnMoneyAfterChanging(decimal TotalPrice)
        {

        }

        private void numaricDayNum_ValueChanged(object sender, EventArgs e)
        {
            flageNumberOfDay = true;
        }

        

        private void CalculatingTotalPrice()
        {

            TotalPrice = Math.Abs(Renting.TotalPaidPrice - Renting.TotalPrice);
            TotalReturnMoney = 0;

                   
                 decimal NewTotalPrice = PricePerDay * numaricDayNum.Value;
                 NewTotalPrice += Scheduling.DriverID != null ? 50 : 0;

                decimal Difference = NewTotalPrice - Renting.TotalPrice;

                if (Difference == 0)
                {
                    return;
                }


                if (Difference > 0)
                {
                    TotalPrice += Difference;
                }
                else
                {
                    if (TotalPrice == 0)
                    {
                        TotalReturnMoney = Math.Abs(Difference);
                    }
                    else
                    {
                        TotalPrice += Difference;
                    }
                }
        }

        private void CalculateingWithDriverFees()
        {
            if (TotalPrice != 0)
            {
                TotalPrice += 50;
            }
            else
            {
                decimal Difference = 50 - TotalReturnMoney;

                if (Difference < 0)
                {
                    TotalReturnMoney = Math.Abs(Difference);
                }
                else
                {
                    TotalPrice += Difference;
                    TotalReturnMoney = 0;
                }
            }

        }

        private void CalculateingWithoutDriverFees()
        {
            if (TotalPrice != 0)
            {
                decimal Difference = TotalPrice - 50;
                if (Difference > 0)
                {
                    TotalPrice -= 50;
                }
                else
                {
                    TotalPrice = 0;
                    TotalReturnMoney += Math.Abs(Difference);
                }
            }
            else
            {
                TotalReturnMoney += 50;
            }

        }

        private void CalculatingDriverPrice()
        {
            bool withDriver = (Scheduling.DriverID != null);

            if(!(withDriver ^ cbwithdriver.Checked))
            {
                return;
            }


            if (cbwithdriver.Checked)
            {
                CalculateingWithDriverFees();
            }
            else
            {
                CalculateingWithoutDriverFees();
            }

        }

       

        private void btnCalculate_Click(object sender, EventArgs e)
        {


            if (flageVehicleChang || flageNumberOfDay)
            {
                CalculatingTotalPrice();
            }


            if(flageDriverChang)
            {
                CalculatingDriverPrice();
            }


            lbTotalPrice.Text = TotalPrice.ToString() + "jd";
            lbReturnMoney.Text = TotalReturnMoney.ToString() + "jd";

        }

        private void cbxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadDataToModelBox(cbxTypes.Text);
        }

        private void cbxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void cbwithdriver_CheckedChanged(object sender, EventArgs e)
        {
            flageDriverChang = true;
            if(cbwithdriver.Checked)
            {
                cbxDriver.Enabled = true;
            }
            else
            {
                cbxDriver.Enabled = false;
            }
        }

        private void dateTimeStart_ValueChanged(object sender, EventArgs e)
        {
            flageStartfrom = true;
        }

        private void lbCarInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            VehicleInfo frm = new VehicleInfo(Vehicle);
            frm.ShowDialog();
        }


        private bool UpdateTotalPriceForRentingByRentingPay()
        {
            decimal NewTotalPrice=0;

            if (Renting.IsPaid)
            {
                NewTotalPrice =Renting.TotalPrice+ TotalPrice;
            }
            else
            {
                NewTotalPrice = TotalPrice;
            }

            if(!clsRenting.UpdateTotalPriceAndPaidAmount(Renting.SechduleID,NewTotalPrice,Renting.TotalPaidPrice +TotalReturnMoney))
            {
                MessageBox.Show("There is Somting Error , The Process Canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool UpdateTotalPriceForRentingByPayingNow()
        {
            decimal NewTotalPrice = 0;

            if (Renting.IsPaid)
            {
                NewTotalPrice = Renting.TotalPrice + TotalPrice;
            }
            else
            {
                NewTotalPrice = TotalPrice;
            }

            if (!clsRenting.UpdateTotalPriceAndPaidAmount(Renting.SechduleID, NewTotalPrice, NewTotalPrice))
            {
                MessageBox.Show("There is Somting Error , The Process Canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }



        private void btnReturnPay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to continue without Pay!", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            LoadNewDataToSchecduleObject();

            if(!Scheduling.Save())
            {
                MessageBox.Show("There is Somting Error , The Process Canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!UpdateTotalPriceForRentingByRentingPay())
            {
                MessageBox.Show("There is Somting Error , The Process Canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Changing And Editing has been Successfully Added!");
            OnFinishClick?.Invoke(null, null);

        }

        private void btnPayNow_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Are You sure to continue ", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            LoadNewDataToSchecduleObject();

            if (!Scheduling.Save())
            {
                MessageBox.Show("There is Somting Error , The Process Canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!UpdateTotalPriceForRentingByPayingNow())
            {
                MessageBox.Show("There is Somting Error , The Process Canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





            FastPayment frm = new FastPayment(TotalPrice, Renting);
            frm.ShowDialog();
            OnFinishClick?.Invoke(null, null);

            

        }
    }
}
