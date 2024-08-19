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
    public partial class ctrUpdateUser : UserControl
    {
        public ctrUpdateUser()
        {
            InitializeComponent();
        }


        bool flag = false;

        clsUsers User;
        public void GetObjectAndCreatClass(clsUsers User)
        {
            this.User = User;
            _LoadData();
        }


        private int GetTotalNumberofPermisions()
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

        private void CheckedThePermisionList()
        {
            int Counter = 1;

            for(int i=0;i<=10;i++)
            {
                if((Counter &User.NumberOfPermisions)==Counter)
                {
                    cbxPermisions.SetItemChecked(i, true);
                }

                Counter *= 2;
            }
        }


        private void _LoadData()
        {
            if(User!=null)
            {
                lbUser.Text = User.UserID.ToString();
                txtUserName.Text = User.UserName;
                txtPassword.Text = "*******";
                cbxIsActive.Checked = User.isActive;
                lbEmployeeId.Text = User.EmployeeID.ToString();
                CheckedThePermisionList();
            }
        }



        private void ctrUpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("You must Fill UserName Text Box");
                return;
            }

            if(MessageBox.Show("Are you sure to Update this Employee","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }


            User.UserName= txtUserName.Text;
            User.isActive= cbxIsActive.Checked;
            if(flag)
            {
                User.NumberOfPermisions = GetTotalNumberofPermisions();
            }

            if(!User.Save())
            {
                MessageBox.Show("The Process Cancled Somting Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has Done Succesfully!");
            btnSave.Enabled = false;


        }

        private void cbxPermisions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxPermisions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            flag = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword frm = new ChangePassword(User.UserID);
            frm.ShowDialog();
        }
    }
}
