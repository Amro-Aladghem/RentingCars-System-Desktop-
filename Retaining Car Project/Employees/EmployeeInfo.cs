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

namespace Retaining_Car_Project
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo(clsEmployee employee)
        {
            InitializeComponent();
            ctrEmployeeInfo1.GetObjectAndCreatClass(employee);
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
