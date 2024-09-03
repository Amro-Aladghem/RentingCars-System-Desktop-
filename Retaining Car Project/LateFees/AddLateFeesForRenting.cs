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

namespace Retaining_Car_Project.LateFees
{
    public partial class AddLateFeesForRenting : Form
    {
        public AddLateFeesForRenting()
        {
            InitializeComponent();
        }

        clsLateFees NewLateFees = new clsLateFees();
        int RentingID;





        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                MessageBox.Show("You Must Fill Text Box!");
                return;
            }

            clsRenting renting =clsRenting.FindRentingByID(Convert.ToInt32(txtSearch.Text));
            if (renting == null)
            {
                MessageBox.Show("No Renting with this ID,Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RentingID = renting.RentID;
            ctrRentingInfo1.GetObjcetAndCreatClass(renting);
            lbDays.Visible = true;
            txtDays.Visible = true;
            btnSave.Visible = true;
            btnSearch.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtDays.Text=="")
            {
                MessageBox.Show("You must Enter number in Days Text Box!");
                return;
            }

            if(MessageBox.Show("Are You Sure to Add this LateFees","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                return;
            }

            NewLateFees.RentID = RentingID;
            NewLateFees.DaysOfDelay= Convert.ToInt32(txtDays.Text);
            NewLateFees.FeesAmount = Convert.ToInt32(txtDays.Text) * 7;

            if(!NewLateFees.Save())
            {
                MessageBox.Show("The Process has been Cancled , Please Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done Successfully!");
            this.Close();

        }
    }
}
