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
    public partial class ListOfCars : Form
    {
        public ListOfCars()
        {
            InitializeComponent();
        }

        private DataTable _LoadDataToGridView()
        {
            return clsVehicles.GetAllCarsInTheSystem();
        }

        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsVehicles.GetAllCarsInTheSystem();
            lbRecords.Text=dataGridView1.RowCount.ToString();
        }




        private void btnExists_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListOfCars_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = _LoadDataToGridView();
             
                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                    lbRecords.Text = dataGridView1.RowCount.ToString();

                }));
            });
        }

        private void deleteCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to delete this car model from system\n this operation will not delete the marka!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }

            if(!clsVehicles.DeleteCarFromSystem((int)dataGridView1.CurrentRow.Cells[0].Value, (int)dataGridView1.CurrentRow.Cells[1].Value))
            {
                MessageBox.Show("The Process has been Canceled,Somthing Error!", "Error", MessageBoxButtons.OK);
                return;
            }

            _ReffreshData();
        }
    }
}
