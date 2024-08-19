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

namespace Retaining_Car_Project.Users
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        clsUsers User;


        private void ctrUserInfoWithFilter1_OnSearchClick(object sender, ctrUserInfoWithFilter.GetUserObject e)
        {
            btnDelete.Visible = true;
            User = e.User;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(User==null)
            {
                return;
            }

            if(MessageBox.Show("Are You sure to delete this User","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Error)==DialogResult.Cancel)
            {
                return;
            }

            if(!User.Delete())
            {
                MessageBox.Show("Somting Error!,The Process Cancled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrUserInfoWithFilter1.ResetData();
                btnDelete.Visible = false;
                User = null;
                return;
            }

            ctrUserInfoWithFilter1.ResetData();
            btnDelete.Visible = false;
            User = null;

        }

        private void ctrUserInfoWithFilter1_OnFailSearchClick(object sender, EventArgs e)
        {
            ctrUserInfoWithFilter1.ResetData();
            btnDelete.Visible = false;
            User = null;
        }
    }
}
