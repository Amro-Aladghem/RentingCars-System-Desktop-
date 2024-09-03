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

namespace Retaining_Car_Project.LateFees
{
    public partial class LateFeesList : Form
    {
        public LateFeesList()
        {
            InitializeComponent();
        }


        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsLateFees.GetAllLateFeesRecord();
            lbRecords.Text=dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsLateFees.GetAllLateFeesRecord();
            return dt;
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
                txtFilter.Visible=true;
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
                   
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format($"{filterColumn}={filterValue}");
                        lbRecords.Text = dataGridView1.RowCount.ToString();
                    
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LateFeesList_Load(object sender, EventArgs e)
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
            AddLateFeesForRenting frm = new AddLateFeesForRenting();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void updateDaysOfDelayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLateFees LateFees = clsLateFees.FindLateFeesRecord((int)dataGridView1.CurrentRow.Cells[1].Value);
            UpdateDaysofdelay frm = new UpdateDaysofdelay(LateFees);
            frm.Show();
            _ReffreshData();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLateFees LateFees = clsLateFees.FindLateFeesRecord((int)dataGridView1.CurrentRow.Cells[1].Value);

            if (MessageBox.Show("Are You sure to delete ", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            if(!clsLateFees.DeleteLateRentingFeesRecord((int)dataGridView1.CurrentRow.Cells[1].Value))
            {
                MessageBox.Show("The Process has been Cancled , Please Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReffreshData();


        }

        private void add1DayOfDelayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to Update Number Of Days", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            clsLateFees LateFees = clsLateFees.FindLateFeesRecord((int)dataGridView1.CurrentRow.Cells[1].Value);

            LateFees.DaysOfDelay++;

            if (!LateFees.Save())
            {
                MessageBox.Show("The Process has been Cancled , Please Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done Successfully!");
            this.Close();


        }
    }
}
