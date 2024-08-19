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
    public partial class EnterUserID : Form
    {
        public EnterUserID()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                MessageBox.Show("You must Fill the Text Box!");
                return;
            }

            clsUsers user = clsUsers.FindUserByID(Convert.ToInt32(txtSearch.Text));

            if(user==null)
            {
                MessageBox.Show("This User Not Found , Try again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            UpdateUser frm=new UpdateUser(user); frm.ShowDialog();
            this.Close();
        }

        private void EnterUserID_Load(object sender, EventArgs e)
        {

        }
    }
}
