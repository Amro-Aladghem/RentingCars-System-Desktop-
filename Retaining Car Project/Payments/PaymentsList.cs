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

namespace Retaining_Car_Project.Payments
{
    public partial class PaymentsList : Form
    {
        public PaymentsList()
        {
            InitializeComponent();
        }


        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsPayment.GetAllPaymentsRecords();
            return dt;
        }




        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFilter.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                txtFilter.Clear();
                dateTimeFilter.Visible = false;
                btnFilter.Visible = false;
                
            }
            else if (cbxFilter.SelectedIndex != 5 )
            {
                txtFilter.Visible = true;
                dateTimeFilter.Visible = false;
                btnFilter.Visible = false;
            }
            else
            {
                txtFilter.Visible = false;
                txtFilter.Clear();
                dateTimeFilter.Visible = true;
                btnFilter.Visible = true;
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
                    lbRecords.Text = dataGridView1.RowCount.ToString();

                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filterColumn = "DateOfPaid";
            string filterValue = dateTimeFilter.Value.Date.ToString();

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
            lbRecords.Text = dataGridView1.RowCount.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaymentsList_Load(object sender, EventArgs e)
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

        private void paymentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPayment payment = clsPayment.FindPaymentByRentID((int)dataGridView1.CurrentRow.Cells[1].Value);
            PaymentInfo frm = new PaymentInfo(payment);
            frm.ShowDialog();
        }
    }
}
