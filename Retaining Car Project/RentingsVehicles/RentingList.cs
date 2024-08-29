using clsBuesnesLayer;
using Retaining_Car_Project.SystemCustomer;
using Retaining_Car_Project.Vehciles;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.RentingsVehicles
{
    public partial class RentingList : Form
    {
        public RentingList()
        {
            InitializeComponent();
        }


        private DataTable _LoadDataToGrid()
        {
            DataTable dt = new DataTable();
            dt=clsRenting.GetAllRentingRecordInTheSys();
            return dt;

        }

        private void ReffreshData()
        {
            dataGridView1.DataSource = clsRenting.GetAllRentingRecordInTheSys();
            lbRecord.Text = dataGridView1.RowCount.ToString();
        }

        private void RentingList_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                // Simulate loading small data
                var data = _LoadDataToGrid();

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                    cbxFilter.SelectedIndex = 0;

                }));
            });
        }









        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFilter.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                txtFilter.Clear();
                cbxActive.SelectedIndex = 0;
                cbxActive.Visible = false;
            }
            else if (cbxFilter.SelectedIndex != 5 || cbxFilter.SelectedIndex != 4)
            {
                txtFilter.Visible = true;
                cbxActive.Visible = false;
                cbxActive.SelectedIndex = 0;
            }
            else
            {
                txtFilter.Visible = false;
                txtFilter.Clear();
                cbxActive.Visible = true;
                cbxActive.SelectedIndex = 0;

            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbxFilter.SelectedIndex != -1)
            {
                string filterColumn = cbxFilter.SelectedItem.ToString();
                string filterValue = txtFilter.Text;

                // تطبيق الفلترة على DataTable
                if (!string.IsNullOrEmpty(filterValue))
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0}={1}", filterColumn, filterValue);
                    lbRecord.Text = dataGridView1.RowCount.ToString();

                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                }
            }
        }

        private void cbxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterColumn= cbxFilter.SelectedItem.ToString();
            string filterValue;

            if (cbxActive.SelectedIndex == 1)
            {
                filterValue = "1";
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }
            else if(cbxActive.SelectedIndex==2)
            {
                filterValue = "0";
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecord.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewRenting_Click(object sender, EventArgs e)
        {
            AddNewRenting frm = new AddNewRenting();
            frm.ShowDialog();
            ReffreshData();
        }

        private void btnPayRenting_Click(object sender, EventArgs e)
        {
            PayRenting frm = new PayRenting();
            frm.ShowDialog();
            ReffreshData();
        }

        private void payRentingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayRenting frm = new PayRenting();
            frm.ShowDialog();
        }

        private void showRentingInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsRenting Renting = clsRenting.FindRentingByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            RentingInfo frm = new RentingInfo(Renting);
            frm.ShowDialog();

        }

        private void showInScheduleTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchedulesList frm = new SchedulesList((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void cancelRentingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to Cancel this Renting!", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            if((bool)dataGridView1.CurrentRow.Cells[11].Value==false)
            {
                MessageBox.Show("This Renting is already not Active !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
            }

            if (!clsScheduling.ChangTheStatusOfScheduling((int)dataGridView1.CurrentRow.Cells[1].Value, 2))//2==Cancled
            {
                MessageBox.Show("The Process Has been Cancled , Somthing Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReffreshData();

        }

        private void changeTheCarAndDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditingOnRenting frm = new EditingOnRenting();
            frm.ShowDialog();
            ReffreshData();
        }

        private void changeActiveStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsCustomers Customers=clsCustomers.FindCustomerByID((int)dataGridView1.CurrentRow.Cells[3].Value);
            CustomerInfo frm = new CustomerInfo(Customers);
            frm.ShowDialog();
        }

        private void vehicleInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsVehicles Vehicle = clsVehicles.FindVehicleByID((int)dataGridView1.CurrentRow.Cells[2].Value);
            VehicleInfo frm = new VehicleInfo(Vehicle);
            frm.ShowDialog();
        }
    }
}
