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

namespace Retaining_Car_Project.RentingsVehicles
{
    public partial class SchedulesList : Form
    {
        public SchedulesList()
        {
            InitializeComponent();
        }

        public SchedulesList(int index)
        {
            InitializeComponent();
            this.index= index;
        }

        int index = 0;

        private void lbRecords_Click(object sender, EventArgs e)
        {

        }


        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsScheduling.GetAllSchedulingInSystem();
            return dt;
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
            else if (cbxFilter.SelectedIndex != 5 ||cbxFilter.SelectedIndex!=6)
            {
                txtFilter.Visible = true;
                cbxActive.Visible = false;
                cbxActive.SelectedIndex = 0;
            }
            else if(cbxFilter.SelectedIndex!=6)
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
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                        lbRecords.Text = dataGridView1.RowCount.ToString();
               
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }
            }
        }

        private void cbxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxActive.SelectedIndex!=0)
            {
                string filterColumn =cbxActive.SelectedItem.ToString();
                string filterValue = cbxActive.Text;

                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                lbRecords.Text = dataGridView1.RowCount.ToString();
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecords.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void SchedulesList_Load(object sender, EventArgs e)
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
                    cbxFilter.SelectedIndex = 0;
                
                }));
            });
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            string filterColumn = "DateOfSchedule";
            string filterValue = dateTimePicker1.Value.Date.ToString();

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
            lbRecords.Text = dataGridView1.RowCount.ToString();
        }
    }
}
