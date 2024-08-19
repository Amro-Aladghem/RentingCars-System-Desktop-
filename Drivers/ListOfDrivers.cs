using clsBuesnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetainCarsProject.Drivers
{
    public partial class ListOfDrivers : Form
    {
        public ListOfDrivers()
        {
            InitializeComponent();
        }

        private DataTable _LoadData()
        {
          return clsDrivers.GetAllDriverRecord();
           
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
                    if (cbxFilter.SelectedIndex == 2 || cbxFilter.SelectedIndex == 3||cbxFilter.SelectedIndex==4)
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
            if(cbxFilter.SelectedIndex==0)
            {
                txtFilter.Visible = false;
                txtFilter.Clear();
            }
            else
            {
                txtFilter.Visible = true;
            }
        }

        private void ListOfDrivers_Load(object sender, EventArgs e)
        {
           
            cbxFilter.SelectedIndex = 0;

            Task.Run(() =>
            {
                var data = _LoadData(); // Assume LoadData returns the data to be displayed

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data; // Update the grid view
                    lbRecords.Text = dataGridView1.RowCount.ToString();

                }));
            });
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
                MessageBox.Show("You must select One Driver at most!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int DriverID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            clsDrivers drivers = clsDrivers.FindDriverByID(DriverID);
            AddUpdateDriver frm =new AddUpdateDriver(drivers);
            frm.ShowDialog();
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateDriverInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDrivers drivers = clsDrivers.FindDriverByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddUpdateDriver frm = new AddUpdateDriver(drivers);
            frm.ShowDialog();
            _LoadData();
        }

        private void deleteDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Driver!", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                return;
            }


            if (clsDrivers.DeleteDriver((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("The Process has Done Successfully!");
                _LoadData();
            }
            else
            {
                MessageBox.Show("The Process Cancled,Somthing Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDrivers drivers = clsDrivers.FindDriverByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            DriverInfo frm = new DriverInfo(drivers);
            frm.ShowDialog();
        }


    }
}
