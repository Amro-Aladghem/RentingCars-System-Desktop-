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

namespace Retaining_Car_Project.SystemRules
{
    public partial class VehiclesRentPricesList : Form
    {
        public VehiclesRentPricesList()
        {
            InitializeComponent();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsSystemRules.GetAllVehiclePriceRecords();
            return dt;
        }

        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsSystemRules.GetAllVehiclePriceRecords();
            lbRecords.Text = dataGridView1.RowCount.ToString();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VehiclesRentPricesList_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                // Simulate loading small data
                var data = _LoadData();

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }));
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddVehcilePrice frm = new AddVehcilePrice();
            frm.Show();
            _ReffreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateVehiclePrice frm = new UpdateVehiclePrice();
            frm.Show();
            _ReffreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this Record,This will impact on Renting Process","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }

            if(!clsSystemRules.DeleteVehiclePriceRecord((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("The Process has been Cancled !");
                return;
            }

            _ReffreshData();
        }
    }
}
