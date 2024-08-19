using clsBuesnesLayer;
using SecurityLayer;
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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        clsUsers User;

        public ChangePassword(int UserID)
        {
            InitializeComponent();
            ctrUserInfoWithFilter1.ActivebtnSearch_Click(UserID);

        }


        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void ctrUserInfoWithFilter1_OnSearchClick(object sender, ctrUserInfoWithFilter.GetUserObject e)
        {
            User = e.User;
            txtCurrent.Enabled = true;
        }

        private void txtCurrent_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtCurrent.Text))
            {
                e.Cancel=true;
                errorProvider1.SetError(txtCurrent, "You must Fill it!");
            }
            else if(txtCurrent.Text !=SecurityClass.Decrypt(User.Password))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrent, "The Password Not Correct");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrent, "");
                txtCurrent.Enabled = false;
                txtConfirm.Enabled = true;
                txtNew.Enabled = true;
            }
        }

        private void txtNew_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNew.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNew, "You must Fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNew, "");
            }
        }

        private void txtNew_TextChanged(object sender, EventArgs e)
        {
            txtConfirm.Clear();
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtConfirm.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirm, "You must fill it!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirm, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to add this Change","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                MessageBox.Show("The Process Canceled :- (");
                return;
            }

            if(!User.UdpatePassword(txtNew.Text))
            {
                MessageBox.Show("Somting Error, The Process Canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            MessageBox.Show("The Process has Done Successfully");
            this.Close();
        }
    }
}
