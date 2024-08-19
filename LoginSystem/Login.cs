using clsBuesnesLayer;
using RetainCarsProject.Properties;
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

namespace RetainCarsProject.LoginSystem
{
    public partial class Login : Form
    {

        enum eShowPassword { Show=1,NotShow=2};
        eShowPassword eShow;
        public Login()
        {
            InitializeComponent();
            eShow = eShowPassword.NotShow;
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text=="" || txtUserName.Text=="")
            {
                MessageBox.Show("You must Fill all Brakcets!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information); return;
            }

            clsUsers User =clsUsers.FindUserByName(txtUserName.Text);

            if(User== null)
            {
                MessageBox.Show("Incorrect UserName Or Password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
            }

            if( SecurityClass.Decrypt(User.Password)!=txtPassword.Text)
            {
                MessageBox.Show("Incorrect UserName Or Password!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
            }

            if(User.isActive == false)
            {
                MessageBox.Show("You are not Active Now, Please Call Admin to activate you!");
            }

            clsLogedInUser.SetValueToUser(User);

            Form1 frm = new Form1(this);
            this.Hide();
            frm.ShowDialog();

            if(cbxRememberme.Checked)
            {
                LoginRegistry.DeleteDataFromRegsetry();
                LoginRegistry.SetDataToRegsetry(txtUserName.Text, txtPassword.Text);
            }
            else
            {
                LoginRegistry.DeleteDataFromRegsetry();
            }

            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string value1 = "", value2 = "";
            LoginRegistry.GetDataFromRegsetry(ref value1, ref value2);
            if(value1!=""&&value2!="")
            {
                txtPassword.Text = value2;
                txtUserName.Text = value1;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(eShow==eShowPassword.NotShow)
            {
                pictureBox4.Image = Resources.view;
                eShow = eShowPassword.Show;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                pictureBox4.Image = Resources.invisible;
                eShow = eShowPassword.NotShow;
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
