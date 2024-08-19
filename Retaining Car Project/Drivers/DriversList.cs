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

namespace Retaining_Car_Project.Drivers
{
    public partial class DriversList : Form
    {
        public DriversList()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            dataGridView1.DataSource = clsDrivers.GetAllDriverRecord();
            lbRecords.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadDataToForm()
        {
            return clsDrivers.GetAllDriverRecord();
        }





        private void DriversList_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                // Simulate loading small data
                var data = _LoadDataToForm();

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }));
            });



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
                    if (cbxFilter.SelectedIndex == 2 || cbxFilter.SelectedIndex == 3 || cbxFilter.SelectedIndex==4)
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                        lbRecords.Text = dataGridView1.RowCount.ToString();
                    }
                    else
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format($"{filterColumn}={filterValue}");
                        lbRecords.Text = dataGridView1.RowCount.ToString();
                    }
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }
            }

        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFilter.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                txtFilter.Clear();
                
            }
            else
            {
                txtFilter.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateDriver frm = new AddUpdateDriver();
            frm.ShowDialog();
            _LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must select 1 one Driver!");
                return;
            }

            clsDrivers drivers = clsDrivers.FindDriverByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddUpdateDriver frm = new AddUpdateDriver(drivers);
            frm.ShowDialog();
            _LoadData();
        }

        private void driverInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDrivers drivers = clsDrivers.FindDriverByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            DriverInfo frm = new DriverInfo(drivers);
            frm.ShowDialog();

        }

        private void udpateDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDrivers drivers = clsDrivers.FindDriverByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddUpdateDriver frm = new AddUpdateDriver(drivers);
            frm.ShowDialog();
            _LoadData();
        }

        private void deleteDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this Driver from system!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel) 
            {
                return;
            }


            if(!clsDrivers.DeleteDriver((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("The Processe Cancled , Somthing Error!");
                return;
            }

            _LoadData();
        }
    }
}
