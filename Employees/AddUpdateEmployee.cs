using RetainCarsProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetainCarsProject.Employees
{
    public partial class AddUpdateEmployee : Form
    {
        enum eMode { AddNew=1,Update=2}
        eMode Mode;
        public AddUpdateEmployee()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
            lbUpdate_Add.Text = "Add Employee";
        }

        public AddUpdateEmployee(int EmployeeID)
        {
            InitializeComponent();
            ctrAddUpdateEmployee1.GetIDAndCreatClass(EmployeeID);
            Mode = eMode.Update;
            lbUpdate_Add.Text = "Update Employee";
            this.EmployeeID=EmployeeID;
        }

        int EmployeeID;


        private void AddUpdateEmployee_Load(object sender, EventArgs e)
        {
            if (Mode == eMode.AddNew)
            {
                pictureBox1.Image = Resources.add__1_;
            }else
            {
                pictureBox1.Image = Resources.business;
                lbEmployeeID.Text = EmployeeID.ToString();
            }
        }



        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrAddUpdateEmployee1_OnSaveClick(object sender, ctrAddUpdateEmployee.GetNewEmployeeID e)
        {
            if(Mode==eMode.AddNew)
            {
                pictureBox1.Image = Resources.business;
                lbUpdate_Add.Text = "Update Employee";
                lbEmployeeID.Text=e.EmployeeID.ToString();
                Mode = eMode.Update;
            }
        }

        private void ctrAddUpdateEmployee1_Load(object sender, EventArgs e)
        {

        }
    }
}
