﻿using clsBuesnesLayer;
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
    public partial class ctrAdding_UpdatingVehicleDetails : UserControl
    {
      public  enum eMode { AddNew=1,Update=2 }
        eMode Mode;

        clsVehicles Vehicles = new clsVehicles();

        bool FIsUdpdateMode = false;

        public class GetTypeOfMood:EventArgs
        {
            public eMode mode { get; set; }

            public GetTypeOfMood(eMode mode)
            {
                this.mode = mode;
            }

        }

        public event EventHandler<GetTypeOfMood> OnSearchClick;

        public ctrAdding_UpdatingVehicleDetails()
        {
            InitializeComponent();
        }


        public  void ActivateSearchClick(string CarTypeName,string ModelName)
        {
           cbxType.Text = CarTypeName; 
           cbxModel.Text=ModelName;
           btnSearch_Click(null,null);
            FIsUdpdateMode = true;
        }




        private ComboBox _LoadDataToTypeCbx()
        {
            ComboBox cbx = new ComboBox();
            DataTable dt = new DataTable();

            dt = clsVehicles.GetAllCarTypesInTheSystem();

            foreach (DataRow row in dt.Rows)
            {
                cbx.Items.Add(row["CarName"]);
            }
            cbx.SelectedIndex = 0;

            return cbx;
        }

       

        private void _LoadDataToModelCbx(string CarTypeName)
        {
            cbxModel.Items.Clear();

            DataTable dt = new DataTable();

            dt = clsVehicles.GetAllModelsForTheVehicl(CarTypeName);
            foreach (DataRow row in dt.Rows)
            {
                cbxModel.Items.Add(row["ModelName"]);
            }

            cbxModel.SelectedIndex = 0;
            btnSearch.Enabled = true;
        }

        private ComboBox _LoadDataToColorCbx()
        {
            ComboBox cbx = new ComboBox();
            DataTable dt = new DataTable();

            dt = clsVehicles.GetAllColorOptionsInTheSystem();

            foreach (DataRow row in dt.Rows)
            {
                cbx.Items.Add(row["ColorName"]);
            }
            cbx.SelectedIndex = 0;

            return cbx;

        }

        private void _TheProcessInAddNewMode()
        {
            groupBox1.Enabled = true;
            txtCarTypeID.Text = clsVehicles.GetCarTypeIDByName(cbxType.Text).ToString();
            txtModelID.Text = clsVehicles.GetCarModelIDByName(cbxModel.Text).ToString();

            txtCarTypeID.ReadOnly = true;
            txtModelID.ReadOnly = true;
            lbFirstTime.Visible = true;

        }

        private void _LoadDataToControl()
        {
            if(Vehicles!=null)
            {
                txtVehiclID.Text = Vehicles.VehicleID.ToString();
                txtCarTypeID.Text = Vehicles.CarTypeID.ToString();
                txtModelID.Text = Vehicles.CarModelID.ToString();
                cbxColor.Text = clsVehicles.GetColorNameByID(Vehicles.ColorID);
                cbxRentStatus.SelectedIndex = Vehicles.RentStatusID - 1;
                txtProducedYear.Text = Vehicles.ProducedYear;
                txtmillageCounter.Text=Vehicles.CurrentMillageCounter.ToString();
                txtCarNumber.Text = Vehicles.CarNumber;
                txtIssue.Text = Vehicles.IsHasDamaged;

                txtVehiclID.ReadOnly = true;
                txtModelID.ReadOnly = true;
                txtCarTypeID.ReadOnly = true;
                cbxColor.Enabled = false;
                txtProducedYear.ReadOnly = true;
                txtCarTypeID.ReadOnly = true;
                txtCarNumber.ReadOnly = true;
                
            }
        }

        private void _DisableControl()
        {
            txtVehiclID.ReadOnly = true;
            txtModelID.ReadOnly = true;
            txtCarTypeID.ReadOnly = true;
            cbxColor.Enabled = false;
            txtProducedYear.ReadOnly = true;
            txtCarTypeID.ReadOnly = true;
            txtCarNumber.ReadOnly = true;
        }

        private void _TheProcessInUpdateMode()
        {
            groupBox1.Enabled = true;
            _LoadDataToControl();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsVehicles vehicle = clsVehicles.FindVehicleByCarTypeAndModelName(cbxType.Text, cbxModel.Text);

            if(vehicle==null)
            {
                Mode = eMode.AddNew;
                _TheProcessInAddNewMode();
                OnSearchClick?.Invoke(sender, new GetTypeOfMood(Mode));
            }
            else
            { 
                 Mode = eMode.Update;
                 Vehicles = vehicle;
                _TheProcessInUpdateMode();
                OnSearchClick?.Invoke(sender, new GetTypeOfMood(Mode));
            }

            btnConfirm.Enabled = true;
            cbxType.Enabled = false;
            cbxModel.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _PerformTypeCbx(ComboBox cbx)
        {
            foreach(var Item in cbx.Items)
            {
                cbxType.Items.Add(Item);
            }

            cbxType.SelectedIndex = 0;
        }

        private void _PerformColorCbx(ComboBox cbx)
        {
            foreach(var Item in cbx.Items)
            {
                cbxColor.Items.Add(Item);
            }

            cbxColor.SelectedIndex = 0;
        }

        private void ctrAdding_UpdatingVehicleDetails_Load(object sender, EventArgs e)
        {
            cbxRentStatus.SelectedIndex = 1;

            if(FIsUdpdateMode)
            {
                return;
            }


            Task.Run(() =>
            {

                // Simulate loading small data
                var data = _LoadDataToTypeCbx();
                var dataColor = _LoadDataToColorCbx();

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    _PerformTypeCbx(data);
                    _PerformColorCbx(dataColor);
                }));
            });


        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadDataToModelCbx(cbxType.Text);
        }

        private void txtProducedYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProducedYear_Validating(object sender, CancelEventArgs e)
        {
            if(txtProducedYear.Text=="____")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtProducedYear,"You must Fill it!");
            }
            else if(txtProducedYear.Text.Length!=4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtProducedYear, "The Fromat of The year not correct!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtProducedYear, "");
            }

        }

        private void txtmillageCounter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!='.')
            {
                e.Handled = true;
            }
        }

        private void txtmillageCounter_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtmillageCounter.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtmillageCounter, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtmillageCounter, "");
            }
        }

        private void txtCarNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCarNumber_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtCarNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCarNumber, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCarNumber, "");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            if(MessageBox.Show("Are you sure to Add/Update this Vehicle!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.Cancel) 
            {
                MessageBox.Show("The Process has been Canceled!");
                return;
            }

            if(Mode==eMode.AddNew)
            {
                Vehicles.CarTypeID = Convert.ToInt32(txtCarTypeID.Text);
                Vehicles.CarModelID = Convert.ToInt32(txtModelID.Text);
                Vehicles.ColorID = clsVehicles.GetColorIDByHisName(cbxColor.Text);
                Vehicles.CarNumber = txtCarNumber.Text;
            }

            Vehicles.RentStatusID = cbxRentStatus.SelectedIndex + 1;
            Vehicles.ProducedYear = txtProducedYear.Text;
            Vehicles.CurrentMillageCounter = Convert.ToDecimal(txtmillageCounter.Text);
            Vehicles.IsHasDamaged = txtIssue.Text;

            if (!Vehicles.Save())
            {
                MessageBox.Show("There is Somting Error , The Process Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            MessageBox.Show("The Process has been done Successfully!");
            lbFirstTime.Visible = false;
            _DisableControl();
            Mode = eMode.Update;
            OnSearchClick?.Invoke(sender, new GetTypeOfMood(eMode.Update));

        }

        private void txtCarTypeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
