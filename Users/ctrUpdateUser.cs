using clsBuesnesLayer;
using RetainCarsProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetainCarsProject.SystemUser
{
    public partial class ctrUpdateUser : UserControl
    {
        public ctrUpdateUser()
        {
            InitializeComponent();
            this.User = User;
        }

        clsUsers User;

        public void GetObjectAndCreatClass(clsUsers User)
        {
            this.User = User;
            _LoadData();
        }
        private int GetTotalNumberOfPermision()
        {
            int Total = 0;
            int Counter = 1;
            for (int i = 0; i <= 10; i++)
            {
                if (cbxPermisions.GetItemChecked(i))
                {
                    Total += Counter;
                }

                Counter *= 2;

            }

            return Total;
        }

        private void CheckedTheCheckedBox()
        {
            int Counter = 1;
            for(int i=0; i<=10;i++ )
            {
                if((Counter & User.NumberOfPermisions)==Counter)
                {
                    cbxPermisions.SetItemChecked(i, true);
                }


                Counter *= 2;
            }

          
        }

        private void _LoadData()
        {
            if (User != null)
            {
                txtUserName.Text = User.UserName;
                txtPassword.Text = "*******";
                cbxActive.Checked = User.isActive;
                CheckedTheCheckedBox();
                lbUserID.Text = User.UserID.ToString();
            }
        }

        private void ctrUpdateUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("You must Fill all Controls");
                return;
            }

            if (MessageBox.Show("Are you sure to add this User!", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                MessageBox.Show("The Process has been caneled!");
                return;
            }

            User.UserName = txtUserName.Text;
            User.Password = txtPassword.Text;
            User.isActive = cbxActive.Checked;
            User.NumberOfPermisions = GetTotalNumberOfPermision();

            if (User.Save())
            {
                MessageBox.Show("The Process has been Done Successfully!");
                lbUserID.Text = User.UserID.ToString();
                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("The Process Canceled,Something Error", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

        }

        private void PictureShowOrNot_Click(object sender, EventArgs e)
        {
            if (PictureShowOrNot.Image == Resources.view)
            {
                txtPassword.PasswordChar = '\0';
                PictureShowOrNot.Image = Resources.invisible;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                PictureShowOrNot.Image = Resources.view;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword frm = new ChangePassword();
            frm.ShowDialog();
        }
    }
}
