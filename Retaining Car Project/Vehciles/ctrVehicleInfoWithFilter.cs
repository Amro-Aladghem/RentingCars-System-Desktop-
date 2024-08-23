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
using static Retaining_Car_Project.Vehciles.ctrAdding_UpdatingVehicleDetails;

namespace Retaining_Car_Project.Vehciles
{
    public partial class ctrVehicleInfoWithFilter : UserControl
    {
        public ctrVehicleInfoWithFilter()
        {
            InitializeComponent();
        }

        public class GetVehicleObject :EventArgs
        {
            public clsVehicles Vehicle { get; set; }

            public GetVehicleObject(clsVehicles vehicle)
            {
                this.Vehicle=vehicle;
            }

        }

        public event EventHandler<GetVehicleObject> OnSearchClick;


        public event EventHandler OnFailSearchClick;

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

     
        private void ctrVehicleInfoWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsVehicles vehicle = clsVehicles.FindVehicleByCarTypeAndModelName(cbxType.Text, cbxModel.Text);

            if (vehicle == null)
            {
                MessageBox.Show("This Car dose not have details yet, you can add Details after that \n you can Search it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnFailSearchClick?.Invoke(null, null);
                return;
            }
            
            cbxType.Enabled = false;
            cbxType.Enabled = false;
            btnSearch.Enabled = false;

            ctrVehicleInfo1.GetObjectAndCreatClass(vehicle);
            OnSearchClick?.Invoke(sender, new GetVehicleObject(vehicle));

        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadDataToModelCbx(cbxType.Text);
        }

        private void ctrVehicleInfoWithFilter_Load_1(object sender, EventArgs e)
        {

        }
    }
}
