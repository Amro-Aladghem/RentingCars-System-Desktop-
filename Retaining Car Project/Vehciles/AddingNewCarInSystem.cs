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
    public partial class AddingNewCarInSystem : Form
    {
        enum eCarType { Old=1,New=2}
        eCarType CarType;

        public AddingNewCarInSystem()
        {
            InitializeComponent();
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
        

        private void _PerformTypeCbx(ComboBox cbx)
        {
            foreach (var Item in cbx.Items)
            {
                cbxTypes.Items.Add(Item);
            }

            cbxTypes.SelectedIndex = 0;
        }

        private void rdNewType_CheckedChanged(object sender, EventArgs e)
        {
            gbNewType.Enabled = true;
            gbSystemType.Enabled = false;
            CarType = eCarType.New;
        }

        private void rdOldType_CheckedChanged(object sender, EventArgs e)
        {
            gbSystemType.Enabled = true;
            gbNewType.Enabled = false;
            CarType = eCarType.Old;
        }

        private void AddingNewCarInSystem_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                // Simulate loading small data
                var Cbx = _LoadDataToTypeCbx();

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    _PerformTypeCbx(Cbx);
                    cbxTypes.SelectedIndex = 0;
                }));
            });

           
        }

        private void AddNewModel()
        {
            if(clsVehicles.AddNewCarModel(txtModelName_Old.Text,cbxTypes.Text))
            {
                MessageBox.Show("The New Model has been Added Successfully","Infromation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Somthing Error, The Process Cancled,\n Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewCar()
        {


            if(clsVehicles.AddingNewCarWithModel(txtModelName_New.Text,txtTypeName.Text))
            {
                MessageBox.Show("The New Car with new Model has been added successfully!", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Somthing Error, The Process Cancled,\n Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if(MessageBox.Show("Are You sure to add this Car!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                MessageBox.Show("The Process Cancled!");
                return;
            }

            switch (CarType)
            {

                case eCarType.New:
                    {
                        AddNewCar();
                        break;
                    }
                case eCarType.Old:
                    {
                        AddNewModel(); break;
                    }
            }

        }
    }
}
