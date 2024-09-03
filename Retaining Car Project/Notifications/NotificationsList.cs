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

namespace Retaining_Car_Project.Notifications
{
    public partial class NotificationsList : Form
    {
        public NotificationsList()
        {
            InitializeComponent();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();

            dt = clsRenting.GetAllRentingThatMustbeEndToday();
            return dt;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExsit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotificationsList_Load(object sender, EventArgs e)
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
    }
}
