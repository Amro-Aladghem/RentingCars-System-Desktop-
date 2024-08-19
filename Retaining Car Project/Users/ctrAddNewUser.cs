using clsBuesnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.Users
{
    public partial class ctrAddNewUser : UserControl
    {
        public ctrAddNewUser()
        {
            InitializeComponent();
        }

        clsUsers NewUser=new clsUsers();
        int EmployeeID;

        public event EventHandler OnSaveClick;
        private int GetTotalNumberofPermisions()
        {
            int Total = 0;
            int Counter = 1;

            for(int i=0; i<10; i++)
            {
                if(cbxPermisions.GetItemChecked(i))
                {
                    Total += Counter;
                }

                Counter *= 2;
            }

            return Total;
        }

        public void SetEmployeeID(int EmployeeID)
        {
            this.EmployeeID = EmployeeID;
        }


        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "You must fill it!");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "You must Fill it");
            }
        }

        private void ctrAddNewUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text==""  || txtUserName.Text=="")
            {
                MessageBox.Show("You must fill all Text Box");
                return;
            }

            if(MessageBox.Show("Are you srue to add this User to the System!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel) 
            {
                return;
            }

            NewUser.UserName = txtUserName.Text;
            NewUser.Password = txtPassword.Text;
            NewUser.EmployeeID = EmployeeID;
            NewUser.isActive = cbxIsActive.Checked;
            NewUser.NumberOfPermisions = GetTotalNumberofPermisions();

            if(!NewUser.Save())
            {
                MessageBox.Show("The Process Cancled!, Somting Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            lbEmployeeId.Text = NewUser.UserID.ToString();
            btnSave.Enabled = false;
            OnSaveClick?.Invoke(null, null);

        }
    }
}
