using clsBuesnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.Vehciles
{
    public partial class ctrSearchVehicleInfo : UserControl
    {
        public ctrSearchVehicleInfo()
        {
            InitializeComponent();
        }

        public class GetObjectOfVehcil : EventArgs
        {
            public clsVehicles Vehicle { get; set; }

            public GetObjectOfVehcil(clsVehicles vehicles)
            {
                this.Vehicle=vehicles;
            }
        }


        public event EventHandler OnFailSearchClick;

        public event EventHandler<GetObjectOfVehcil> OnSearchClick;


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

        private void _PerformTypeCbx(ComboBox cbx)
        {
            foreach (var Item in cbx.Items)
            {
                cbxType.Items.Add(Item);
            }

            cbxType.SelectedIndex = 0;
        }

        private void ctrSearchVehicleInfo_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                // Simulate loading small data
                var data = _LoadDataToTypeCbx();
     

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    _PerformTypeCbx(data);

                }));
            });
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

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadDataToModelCbx(cbxType.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsVehicles vehicles = clsVehicles.FindVehicleByCarTypeAndModelName(cbxType.Text,cbxModel.Text);

            if(vehicles==null)
            {
                MessageBox.Show("This Car does not have details for now ,\n you can add Details with Update Infromation Process","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                OnFailSearchClick?.Invoke(null, null);
                return;
            }

            ctrVehicleInfo1.GetObjectAndCreatClass(vehicles);
            btnSearch.Enabled = false;
            cbxModel.Enabled = false;
            cbxType.Enabled = false;
            OnSearchClick?.Invoke(sender, new GetObjectOfVehcil(vehicles));
            
        }
    }
}
