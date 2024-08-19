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

namespace Retaining_Car_Project.SystemCustomer
{
    public partial class ListOfCustomers : Form
    {
        public ListOfCustomers()
        {
            InitializeComponent();
        }


        private void _LoadData()
        {
            dataGridView1.DataSource = clsCustomers.GetAllCustomerInTheSystem();
            lbRecords.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadDataToForm()
        {
            return clsCustomers.GetAllCustomerInTheSystem();
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbxFilter.SelectedIndex != -1)
            {
                string filterColumn = cbxFilter.SelectedItem.ToString();
                string filterValue = txtFilter.Text;

                // تطبيق الفلترة على DataTable
                if (!string.IsNullOrEmpty(filterValue))
                {
                    if (cbxFilter.SelectedIndex == 2)
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

        private void ListOfCustomers_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                // Simulate loading small data
                var data = _LoadDataToForm();

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                    cbxFilter.SelectedIndex = 0;
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }));
            });


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateAddCustomers frm = new UpdateAddCustomers();
            frm.ShowDialog();
            _LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must select 1 one Customer!");
                return;
            }

            clsCustomers Customer = clsCustomers.FindCustomerByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            UpdateAddCustomers frm = new UpdateAddCustomers(Customer);
            frm.ShowDialog();
            _LoadData();
        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsCustomers Customer = clsCustomers.FindCustomerByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            CustomerInfo frm = new CustomerInfo(Customer);
            frm.ShowDialog();

        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsCustomers Customer = clsCustomers.FindCustomerByID((int)dataGridView1.CurrentRow.Cells[0].Value);

            UpdateAddCustomers frm = new UpdateAddCustomers(Customer);
            frm.ShowDialog();
            _LoadData();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to delete this Customer from system", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            clsCustomers Customer = clsCustomers.FindCustomerByID((int)dataGridView1.CurrentRow.Cells[0].Value);


            if (!Customer.DeleteCustomer())
            {
                MessageBox.Show("Somting Error ,The Process Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
                return;
            }

            _LoadData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
