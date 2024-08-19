using clsBuesnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.Users
{
    public partial class ctrUserInfoWithFilter : UserControl
    {
        public ctrUserInfoWithFilter()
        {
            InitializeComponent();
        }

        public class GetUserObject:EventArgs
        {
            public clsUsers User;

            public GetUserObject(clsUsers User)
            {
                this.User= User;
            }

        }

        public event EventHandler<GetUserObject> OnSearchClick;
        public event EventHandler OnFailSearchClick;

        public void ResetData()
        {
            txtUserID.Clear();
            ctrUserInfo1.ResetData();
        }


        private void ctrUserInfoWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }


        public void ActivebtnSearch_Click(int UserID)
        {
            txtUserID.Text=UserID.ToString();
            btnSearch_Click(this, EventArgs.Empty);
            btnSearch.Enabled = false;
            txtUserID.Enabled = false;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtUserID.Text=="")
            {
                MessageBox.Show("you must fill text Box!");
                return;
            }

            clsUsers User=clsUsers.FindUserByID(Convert.ToInt32(txtUserID.Text));
            if(User==null)
            {
                MessageBox.Show("This User Not Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                OnFailSearchClick?.Invoke(null, null);
                return;
            }

            ctrUserInfo1.GetObjectAndCreatClass(User);  
            OnSearchClick?.Invoke(sender,new GetUserObject(User));



        }

        public void DeActivateButtonSearch()
        {
            btnSearch.Enabled = false;
        }
    }
}
