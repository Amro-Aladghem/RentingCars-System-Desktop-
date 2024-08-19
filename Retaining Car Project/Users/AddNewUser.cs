using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.Users
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        int EmployeeID;

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            ctrAddNewUser1.Enabled = false;
        }

        private void ctrEmployeeInfoWithFilter1_OnSearchClick(object sender, Employees.ctrEmployeeInfoWithFilter.GetEmployeeObject e)
        {
            EmployeeID = e.Employee.EmployeeID;
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to continue ?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel) 
            {
                return;
            }

            ctrAddNewUser1.SetEmployeeID(EmployeeID);
            tabControl1.SelectedIndex = 1;
            btnCancel.Enabled = true;
            ctrAddNewUser1.Enabled = true;
            ctrEmployeeInfoWithFilter1.DeactivatetextSearch();

        }

        private void ctrAddNewUser1_OnSaveClick(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            this.Close();
        }
    }
}
