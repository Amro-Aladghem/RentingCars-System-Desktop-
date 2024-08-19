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
    public partial class ctrUserInfo : UserControl
    {
        public ctrUserInfo()
        {
            InitializeComponent();
        }

        clsUsers User;


        public void GetObjectAndCreatClass(clsUsers User)
        {
            this.User = User;
            _LoadData();
        }

        private void _LoadData()
        {
            if(User!=null)
            {
                lbUserID.Text = User.UserID.ToString();
                lbUserName.Text= User.UserName.ToString();
                lbEmployeeID.Text= User.EmployeeID.ToString();
                lbPermision.Text = User.NumberOfPermisions.ToString();

                if(User.isActive)
                {
                    lbisActive.Text = "Yes";
                }
                else
                {
                    lbisActive.Text = "No";
                }
            }
        }

        public void ResetData()
        {
            lbUserID.Text = "N/A";
            lbUserName.Text = "[???]";
            lbEmployeeID.Text = "[???]";
            lbisActive.Text = "[???]";
            lbPermision.Text = "[???]";

            User = null;
        }
       


        private void ctrUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
