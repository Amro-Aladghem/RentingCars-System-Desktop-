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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RetainCarsProject.Employees
{
    public partial class EmployeesList : Form
    {
        public EmployeesList()
        {
            InitializeComponent();
        }

        private DataTable _LoadData()
        {
          return clsEmployee.GetAllEmployeeRecord();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxFilter.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                txtFilter.Clear();
                cbxActive.Visible = false;
                cbxActive.SelectedIndex = 0;
            }
            else if(cbxFilter.SelectedIndex!=6)
            {
                txtFilter.Visible = true;
                cbxActive.Visible = false;
                cbxActive.SelectedIndex = 0;
            }
            else
            {
                txtFilter.Visible=false;
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
                    if (cbxFilter.SelectedIndex == 2 || cbxFilter.SelectedIndex == 3)
                    {
                        (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                        lbRecord.Text = dataGridView2.RowCount.ToString();
                    }
                    else
                    {
                        (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format($"{filterColumn}={filterValue}");
                        lbRecord.Text = dataGridView2.RowCount.ToString();
                    }
                }
                else
                {
                    (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                    lbRecord.Text = dataGridView2.RowCount.ToString();
                }
            }
    }

        private void cbxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxFilter.SelectedIndex!=-1)
            {
                if(cbxActive.SelectedIndex==1)
                {
                    (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("isActive=true");
                    lbRecord.Text = dataGridView2.RowCount.ToString();
                }
                else if(cbxActive.SelectedIndex==2)
                {
                    (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("isActive=false");
                    lbRecord.Text = dataGridView2.RowCount.ToString();
                }
                else
                {
                    (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                    lbRecord.Text = dataGridView2.RowCount.ToString();
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must Choose at most 1 Employee!","information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AddUpdateEmployee frm = new AddUpdateEmployee((int)dataGridView2.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateEmployee frm = new AddUpdateEmployee();
            frm.ShowDialog();
            _LoadData();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateEmployee frm = new AddUpdateEmployee((int)dataGridView2.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadData();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Employee!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            clsEmployee employee = clsEmployee.FindEmployee((int)dataGridView2.CurrentRow.Cells[0].Value);
            if (clsEmployee.DeleteEmployee((int)dataGridView2.CurrentRow.Cells[0].Value,employee.PersonID))
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
            EmployeeInfo frm = new EmployeeInfo((int)dataGridView2.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void isActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsEmployee employee = clsEmployee.FindEmployee((int)dataGridView2.CurrentRow.Cells[0].Value);
            if(employee.isActive)
            {
                MessageBox.Show("This Employee is Active!");
            }
            else
            {
                MessageBox.Show("This Employee isnot Active :-(!");
            }


        }



        private void EmployeesList_Load(object sender, EventArgs e)
        {
       

            Task.Run(() =>
            {
                var data = _LoadData(); // Assume LoadData returns the data to be displayed

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    dataGridView2.DataSource = data; // Update the grid view
                    cbxFilter.SelectedIndex = 0;
                    lbRecord.Text = dataGridView2.RowCount.ToString();

                }));
            });

            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}
