using clsBuesnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetainCarsProject.SystemUser
{
    public partial class UsersList : Form
    {
        public UsersList()
        {
            InitializeComponent();
   
        }

        private DataTable _LoadData()
        {
         return clsUsers.GetAllUsersInTheSystem();
     
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewUser frm = new AddNewUser();
            frm.ShowDialog();
            _LoadData();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("You must select one User at most!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsUsers User = clsUsers.FindUserByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            UpdateUser frm = new UpdateUser(User);
            frm.ShowDialog();
            _LoadData();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.FindUserByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            UpdateUser frm = new UpdateUser(User);
            frm.ShowDialog();
            _LoadData();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to delete this User From system!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel) 
            {
                return;
            }

            if (!clsUsers.DeleteUser((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("There is somthing Error,The Process Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();

        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUsers user=clsUsers.FindUserByID((int)dataGridView1.CurrentRow.Cells[0].Value);
            UserInfo frm = new UserInfo(user);
            frm.ShowDialog();
        }

        private void deActivateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to DeActivate this User From system!", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            if(!clsUsers.DeActivateUser((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("There is somthing Error,The Process Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadData();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxFilter.SelectedIndex==0)
            {
                txtFilter.Visible = false;
                cbxActive.Visible = false;
                cbxActive.SelectedIndex = 0;
                txtFilter.Clear();
            }
            else if(cbxFilter.SelectedIndex!=4)
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

        private void UsersList_Load(object sender, EventArgs e)
        {


            Task.Run(() =>
            {
                var data = _LoadData(); // Assume LoadData returns the data to be displayed

                
                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data; // Update the grid view
                    cbxFilter.SelectedIndex = 0;
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                }));
            });
        }

        private void cbxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxActive.SelectedIndex != -1)
            {
                if (cbxActive.SelectedIndex == 1)
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("isActive=true");
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                }
                else if (cbxActive.SelectedIndex == 2)
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("isActive=false");
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                }
                
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
                    if (cbxFilter.SelectedIndex == 3)
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, filterValue);
                        lbRecord.Text = dataGridView1.RowCount.ToString();
                    }
                    else
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format($"{filterColumn}={filterValue}");
                        lbRecord.Text = dataGridView1.RowCount.ToString();
                    }
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty; // إلغاء الفلتر
                    lbRecord.Text = dataGridView1.RowCount.ToString();
                }
            }
        }
    }
}
