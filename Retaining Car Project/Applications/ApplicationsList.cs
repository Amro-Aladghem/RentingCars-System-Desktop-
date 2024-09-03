using clsBuesnesLayer;
using Retaining_Car_Project.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.Applications
{
    public partial class ApplicationsList : Form
    {
        public ApplicationsList()
        {
            InitializeComponent();
        }


        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsApplications.GetAllApplicationList();
            return dt;
        }






        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExists_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplicationsList_Load(object sender, EventArgs e)
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

        private void useToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.FindUserByID((int)dataGridView1.CurrentRow.Cells[3].Value);
            UserInfo frm = new UserInfo(User);
        }
    }
}
