using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsBuesnesLayer;

namespace Retaining_Car_Project.Vehciles
{
    public partial class ListOfVehciles : Form
    {
        public ListOfVehciles()
        {
            InitializeComponent();
        }

        private void _LoadTypesOfVehiclesToCbx()
        {
            DataTable dataTable = new DataTable();

            dataTable = clsVehicles.GetAllCarTypesInTheSystem();

            foreach(DataRow row in dataTable.Rows)
            {
                cbxTypes.Items.Add(row["CarName"]);
            }

            cbxTypes.SelectedIndex = 0;
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

        private void ReffreshData()
        {
            dataGridView1.DataSource = clsVehicles.GetAllVehiclesInTheSystem();
            lbRecords.Text=dataGridView1.RowCount.ToString();   
        }

        private DataTable _LoadDataToGridView()
        {
            return clsVehicles.GetAllVehiclesInTheSystem();
        }


        private ComboBox _LoadTypesOfModelToModelCbx(string CarTypeName)
        {

            ComboBox cbx = new ComboBox();

            DataTable dt = clsVehicles.GetAllModelsForTheVehicl(CarTypeName);

            foreach (DataRow row in dt.Rows)
            {
                cbx.Items.Add(row["ModelName"]);
            }

            return cbx;
           
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListOfVehciles_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                var data = _LoadDataToTypeCbx();
                var dataGridView = _LoadDataToGridView();

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = dataGridView;
                    lbRecords.Text = dataGridView1.RowCount.ToString();

                    foreach (var item in data.Items)
                    {
                        cbxTypes.Items.Add(item);
                    }

                    cbxTypes.SelectedIndex = 0;

                }));
            });
        }

        private void _PerformModelCbx()
        {

         var data = _LoadTypesOfModelToModelCbx(cbxTypes.Text);
        
            cbxModels.Items.Clear();
            cbxModels.Items.Add("All");
         
            foreach (var item in data.Items)
            {
                cbxModels.Items.Add(item);
            }
        
            cbxModels.SelectedIndex = 0;
        
        }


        private  void cbxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxTypes.SelectedIndex == 0)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                lbRecords.Text = dataGridView1.RowCount.ToString();
                cbxModels.Visible = false;
                lbModel.Visible = false;
                return;
            }

            _PerformModelCbx();


             (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "CarName", cbxTypes.Text);
            lbRecords.Text = dataGridView1.RowCount.ToString();

            cbxModels.Visible = true;
            lbModel.Visible = true;
        }

        private void cbxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dataGridView1==null)
            {
                return;
            }

            if(cbxModels.SelectedIndex== 0)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "CarName", cbxTypes.Text);
                lbRecords.Text = dataGridView1.RowCount.ToString();
                return;
            }


            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' And [{2}] LiKe '{3}%'", "CarName", cbxTypes.Text,"ModelName",cbxModels.Text);
            lbRecords.Text = dataGridView1.RowCount.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateDetailsForVehicle frm = new AddUpdateDetailsForVehicle();
            frm.ShowDialog();
            ReffreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must select 1 One Vehicle!");
                return;
            }

            AddUpdateDetailsForVehicle frm = new AddUpdateDetailsForVehicle((string)dataGridView1.CurrentRow.Cells[1].Value, (string)dataGridView1.CurrentRow.Cells[2].Value);
            frm.ShowDialog();
            ReffreshData();
        }

        private void vehicleInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVehicles vehicle = clsVehicles.FindVehicleByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            VehicleInfo frm = new VehicleInfo(vehicle);
            frm.ShowDialog();
        }

        private void updateVehicleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateDetailsForVehicle frm = new AddUpdateDetailsForVehicle((string)dataGridView1.CurrentRow.Cells[1].Value, (string)dataGridView1.CurrentRow.Cells[2].Value);
            frm.ShowDialog();
            ReffreshData();
        }

        private void deleteVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVehicles vehicle = clsVehicles.FindVehicleByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Are you sure to delete this vehicle \n infromation:this operation will not delete car from system only details", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                MessageBox.Show("The Process Cancled!");
                return;
            }


            if (!vehicle.DeleteVehicle())
            {
                MessageBox.Show("The Process Cancled ,Somthing Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReffreshData();
        }

        private void isAvaliableForRentingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVehicles vehicle = clsVehicles.FindVehicleByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            if(vehicle.RentStatusID==1)
            {
                MessageBox.Show("Yes this Vehicle is Available For Renting Now!");
            }
            else
            {
                MessageBox.Show("No this vehicle Not Availabe For Renting Now!");
            }

        }
    }
}
