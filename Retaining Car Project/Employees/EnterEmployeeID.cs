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

namespace Retaining_Car_Project.Employees
{
    public partial class EnterEmployeeID : Form
    {
        public EnterEmployeeID()
        {
            InitializeComponent();
        }

        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtEmployeeID.Text=="")
            {
                MessageBox.Show("You must fill the text box!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            clsEmployee employee = clsEmployee.FindEmployee(Convert.ToInt32(txtEmployeeID.Text));

            if(employee == null ) 
            {
                MessageBox.Show("This Employee Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddUpdateEmployee frm = new AddUpdateEmployee(employee);
            frm.ShowDialog();
            this.Close();

        }
    }
}
