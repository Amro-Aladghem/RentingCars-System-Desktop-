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
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }


        clsEmployee Employee;










        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrEmployeeInfoWithFilter1_OnSearchClick(object sender, ctrEmployeeInfoWithFilter.GetEmployeeObject e)
        {
            btnDelete.Visible = true;
            Employee = e.Employee;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You sure to delete this Employee from system","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel) 
            {
                return;
            }

            if(!clsEmployee.DeleteEmployee(Employee.EmployeeID,Employee.PersonID))
            {
                MessageBox.Show("Somting Error ,The Process Cancled!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                ctrEmployeeInfoWithFilter1.ResetData();
                btnDelete.Visible = false;
                return;
            }

            ctrEmployeeInfoWithFilter1.ResetData();
            btnDelete.Visible = false;
            Employee = null;

        }

        private void ctrEmployeeInfoWithFilter1_OnFailSearchClick(object sender, EventArgs e)
        {
            ctrEmployeeInfoWithFilter1.ResetData();
            btnDelete.Visible = false;
            Employee = null;
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
