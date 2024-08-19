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
    public partial class AddUpdateEmployee : Form
    {
        enum eMode { AddNew=1,Udpate=2}
        eMode Mode;

        public AddUpdateEmployee()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
            lbHead.Text = "Add Employee:";
        }

        public AddUpdateEmployee(clsEmployee employee)
        {
            InitializeComponent();
            Mode = eMode.Udpate;
            ctrAddUpdateEmployee1.GetObjectAndCreatClass(employee);
            lbHead.Text = "Update Employee:";
        }














        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUpdateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void ctrAddUpdateEmployee1_OnSaveClick(object sender, EventArgs e)
        {
            if(Mode==eMode.AddNew)
            {
                Mode = eMode.Udpate;
                lbHead.Text = "Update Employee:";
            }
        }
    }
}
