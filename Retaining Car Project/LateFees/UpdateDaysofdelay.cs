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
using System.Xml;

namespace Retaining_Car_Project.LateFees
{
    public partial class UpdateDaysofdelay : Form
    {
        public UpdateDaysofdelay(clsLateFees LateFees)
        {
            InitializeComponent();
            this.LateFees= LateFees;
        }

        clsLateFees LateFees;


        private void txtDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UpdateDaysofdelay_Load(object sender, EventArgs e)
        {
            lbOldDays.Text = LateFees.DaysOfDelay.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtDays.Text=="" ||txtDays.Text=="0")
            {
                MessageBox.Show("You must Fill Text Box And Number Above 0!");
                return;
            }

            if(MessageBox.Show("Are You sure to Update Number Of Days","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel) 
            {
                return;
            }

            LateFees.DaysOfDelay = Convert.ToInt32(txtDays.Text);

            if (!LateFees.Save())
            {
                MessageBox.Show("The Process has been Cancled , Please Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done Successfully!");
            this.Close();

        }
    }
}
