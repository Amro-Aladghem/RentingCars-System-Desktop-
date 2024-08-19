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

namespace Retaining_Car_Project.Employees
{
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            dataGridView1.DataSource = clsEmployee.GetAllEmployeeRecord();
            lbRecords.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadDataToForm()
        {
            return clsEmployee.GetAllEmployeeRecord();
        }


        private void EmployeeList_Load(object sender, EventArgs e)
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

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFilter.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                txtFilter.Clear();
                cbxActive.SelectedIndex = 0;
                cbxActive.Visible = false;
            }
            else if (cbxFilter.SelectedIndex != 6)
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
                    if (cbxFilter.SelectedIndex == 2 || cbxFilter.SelectedIndex==3)
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

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(cbxFilter.SelectedIndex!=2 ^ cbxFilter.SelectedIndex!=3))
            {
                if(!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if(char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cbxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxActive.SelectedIndex==1)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("isActive =true");
                lbRecords.Text = dataGridView1.RowCount.ToString();
            }
            else if(cbxActive.SelectedIndex==2)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("isActive =false");
                lbRecords.Text = dataGridView1.RowCount.ToString();
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                lbRecords.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsEmployee Employee=clsEmployee.FindEmployee((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddUpdateEmployee frm = new AddUpdateEmployee(Employee);
            frm.ShowDialog();
            _LoadData();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to delete this Employee from system", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            clsEmployee Employee = clsEmployee.FindEmployee((int)dataGridView1.CurrentRow.Cells[0].Value);

            if (!clsEmployee.DeleteEmployee(Employee.EmployeeID, Employee.PersonID))
            {
                MessageBox.Show("Somting Error ,The Process Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _LoadData();

        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsEmployee Employee = clsEmployee.FindEmployee((int)dataGridView1.CurrentRow.Cells[0].Value);
            EmployeeInfo frm = new EmployeeInfo(Employee);
            frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateEmployee frm = new AddUpdateEmployee();
            frm.ShowDialog();
             _LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must select 1 Employee!");
                return;
            }

            clsEmployee Employee = clsEmployee.FindEmployee((int)dataGridView1.CurrentRow.Cells[0].Value);
            AddUpdateEmployee frm = new AddUpdateEmployee(Employee);
            frm.ShowDialog();
            _LoadData();
        }
    }
}
