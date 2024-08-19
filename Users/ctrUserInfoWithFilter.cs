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

namespace RetainCarsProject.SystemUser
{
    public partial class ctrUserInfoWithFilter : UserControl
    {
        public ctrUserInfoWithFilter()
        {
            InitializeComponent();
        }

        public class GetUserObject : EventArgs
        {
            public clsUsers User { get; set; }

            public GetUserObject(clsUsers users)
            {
                User = users;
            }
        }

        public event EventHandler<GetUserObject> OnSearchClik;

        public event EventHandler OnFailSearchClik;

        public void ResetData()
        {
            txtUserID.Clear();
            ctrUserInfoUserControl11.ResetData();
        }


        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsUsers User=clsUsers.FindUserByID(Convert.ToInt32(txtUserID.Text));
            if(User==null)
            {
                MessageBox.Show("This User Not Found");
                OnFailSearchClik?.Invoke(null, null);
                return;
            }
            else
            {
                ctrUserInfoUserControl11.GetObjectAndCreatClass(User);
                OnSearchClik?.Invoke(sender,new GetUserObject(User));
            }
        }

        private void ctrUserInfoWithFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
