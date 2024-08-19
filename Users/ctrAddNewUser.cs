using clsBuesnesLayer;
using RetainCarsProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetainCarsProject.SystemUser
{
    public partial class ctrAddNewUser : UserControl
    {
        public ctrAddNewUser()
        {
            InitializeComponent();
        }

        public event EventHandler OnSaveClick;


        private bool AreImagesEqual(Image img1, Image img2)
        {
            if (img1 == null || img2 == null)
            {
                return false;
            }

            // تحويل الصور إلى مصفوفة بايت للمقارنة
            using (MemoryStream ms1 = new MemoryStream())
            using (MemoryStream ms2 = new MemoryStream())
            {
                img1.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                img2.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);

                byte[] img1Bytes = ms1.ToArray();
                byte[] img2Bytes = ms2.ToArray();

                return img1Bytes.SequenceEqual(img2Bytes);
            }
        }

        private int GetTotalNumberOfPermision()
        {
            int Total = 0;
            int Counter = 1;
            for(int i=0;i<=10;i++)
            {
                if(cbxPermisions.GetItemChecked(i))
                {
                    Total += Counter;
                }

                Counter *= 2;

            }

            return Total;
        }

        clsUsers NewUser = new clsUsers();

        private void ctrAddNewUser_Load(object sender, EventArgs e)
        {

        }

        private void PictureShowOrNot_Click(object sender, EventArgs e)
        {
            if (AreImagesEqual(PictureShowOrNot.Image,Resources.view))
            {
                txtPassword.PasswordChar = '*';
                PictureShowOrNot.Image = Resources.invisible;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                PictureShowOrNot.Image = Resources.view;
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "You must Fill it!");
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "You must Fill it!");
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }
       
        public void SetEmployeeID(int EmployeeID)
        {
            NewUser.EmployeeID = EmployeeID;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("You must Fill all Controls");
                return;
            }

            if(MessageBox.Show("Are you sure to add this User!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                MessageBox.Show("The Process has been caneled!");
                return;
            }

            NewUser.UserName=txtUserName.Text;
            NewUser.Password=txtPassword.Text;
            NewUser.isActive = cbxActive.Checked;
            NewUser.NumberOfPermisions = GetTotalNumberOfPermision();

            if(NewUser.Save())
            {
                MessageBox.Show("The Process has been Done Successfully!");
                lbUserID.Text = NewUser.UserID.ToString();
                btnSave.Enabled = false;
                OnSaveClick?.Invoke(null, null);
            }
            else
            {
                MessageBox.Show("The Process Canceled,Something Error","Error",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }



        }




    }
}
