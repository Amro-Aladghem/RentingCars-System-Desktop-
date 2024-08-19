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

        private void ReffreshData()
        {
            dataGridView1.DataSource = clsVehicles.GetAllVehiclesInTheSystem();
            lbRecords.Text=dataGridView1.RowCount.ToString();   
        }

        private DataTable _LoadDataToGridView()
        {
            return clsVehicles.GetAllVehiclesInTheSystem();
        }


        private void _LoadTypesOfModelToModelCbx(string CarTypeName)
        {

            cbxModels.Items.Clear();
            cbxModels.Items.Add("All");

            DataTable dt = clsVehicles.GetAllModelsForTheVehicl(CarTypeName);

            foreach (DataRow row in dt.Rows)
            {
                cbxModels.Items.Add(row["ModelName"]);
            }

            cbxModels.SelectedIndex = 0;
           
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListOfVehciles_Load(object sender, EventArgs e)
        {

        }

        private  void cbxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxTypes.SelectedIndex == 0)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                lbRecords.Text = dataGridView1.RowCount.ToString();
                cbxModels.Visible = false;
                return;
            }

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "CarType", cbxTypes.Text);
            lbRecords.Text = dataGridView1.RowCount.ToString();

            
            _LoadTypesOfModelToModelCbx(cbxTypes.Text);
            

            cbxModels.Visible = true;

        }

        private void cbxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxModels.SelectedIndex== 0)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "CarType", cbxTypes.Text);
                lbRecords.Text = dataGridView1.RowCount.ToString();
                return;
            }



            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' And [{2}] LiKe '{3}%'", "CarType", cbxTypes.Text,"ModelName",cbxModels.Text);
            lbRecords.Text = dataGridView1.RowCount.ToString();



        }
    }
}
