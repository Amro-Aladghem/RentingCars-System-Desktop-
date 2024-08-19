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
    public partial class ctrEmployeeInfoWithFilter : UserControl
    {
        public ctrEmployeeInfoWithFilter()
        {
            InitializeComponent();
        }

        public class GetEmployeeObject : EventArgs
        {
            public clsEmployee Employee;

            public GetEmployeeObject(clsEmployee employee)
            {
                this.Employee=employee;
            }

        }

        public event EventHandler<GetEmployeeObject> OnSearchClick;

        public event EventHandler OnFailSearchClick;

        public void ResetData()
        {
            ctrEmployeeInfo1.RestetData();
            txtSearch.Clear();
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
                errorProvider1.SetError(btnSearch, "You must Fill it");
                return;
            }

            clsEmployee employee=clsEmployee.FindEmployee(Convert.ToInt32(txtSearch.Text));
            if(employee==null)
            {
                MessageBox.Show("This Employee Not Found, Try again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                OnFailSearchClick?.Invoke(null, null);
                return;
            }

            ctrEmployeeInfo1.GetObjectAndCreatClass(employee);
            OnSearchClick?.Invoke(sender,new GetEmployeeObject(employee));
        }


        public void DeactivatetextSearch()
        {
            txtSearch.Enabled = false;
        }


        private void ctrEmployeeInfoWithFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
