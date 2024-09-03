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

namespace Retaining_Car_Project.SystemRules
{
    public partial class ChangeDriverFees : Form
    {
        public ChangeDriverFees()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!='.')
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You must Fill Text Box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!clsDrivers.UpdateDriverFees(Convert.ToDecimal(textBox1.Text)))
            {
                MessageBox.Show("The Process Cancled Somting Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has been done successfully!");
            this.Close();
              
        }
    }
}
