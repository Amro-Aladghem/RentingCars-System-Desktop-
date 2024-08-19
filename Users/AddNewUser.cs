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

namespace RetainCarsProject.SystemUser
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }


        int EmployeeID;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to Cancel this Process!", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void btnExtis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages[1].Enabled = false;
        }

        private void ctrEmployeInfoByFilter1_OnSearchClick(object sender, Employees.ctrEmployeInfoByFilter.GetEmployeeID e)
        {
            if(clsUsers.IsEmployeeAlreadyUser(e.EmployeeID))
            {
                MessageBox.Show("This Employee already is a user!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
            }


            tabControl1.TabPages[1].Enabled = true;
            btnNext.Enabled = true;
            ctrAddNewUser1.SetEmployeeID(e.EmployeeID);
            ctrEmployeInfoByFilter1.DeActivateSearchTextBox();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void ctrAddNewUser1_OnSaveClick(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
        }
    }
}
