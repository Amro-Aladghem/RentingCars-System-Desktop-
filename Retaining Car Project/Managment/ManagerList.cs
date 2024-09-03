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

namespace Retaining_Car_Project.Managment
{
    public partial class ManagerList : Form
    {
        public ManagerList()
        {
            InitializeComponent();
        }

        public DataTable _LoadDataTodataGrid()
        {
            DataTable dt =new DataTable();
            dt = clsManager.GetAllManagerInSys();

            return dt;
        }

        public void _Reffresh()
        {
            dataGridView1.DataSource=clsManager.GetAllManagerInSys();
            lbRecords.Text=dataGridView1.RowCount.ToString();
        }



        private void updatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSection frm = new UpdateSection((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.Show();
            _Reffresh();
        }

        private void ManagerList_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                // Simulate loading small data
                var data = _LoadDataTodataGrid();

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }));
            });
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.FindUserByID((int)dataGridView1.CurrentRow.Cells[3].Value);
            UserInfo frm = new UserInfo(User);
        }

        private void deleteManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Manager from system!", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            if(!clsManager.DeleteMangerFromSys((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("The Processe Cancled , Somthing Error!");
                return;
            }

            _Reffresh();
        }
    }
}
