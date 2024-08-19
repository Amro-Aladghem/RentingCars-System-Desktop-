using LoginSystem;
using Retaining_Car_Project.Drivers;
using Retaining_Car_Project.Employees;
using Retaining_Car_Project.SystemCustomer;
using Retaining_Car_Project.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class Form1 : Form
    {
        public Form1(Form logForm)
        {
            InitializeComponent();
            LogForm = logForm;
        }


        Form LogForm;
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripButton1.Text = clsLogedInUser.LoggedUser.UserName;

            Task.Run(() =>
            {
                this.Invoke((Action)(() =>
                {
                    CheckThePermisionOfTheLoggedUser();

                }));
            });
        }


        private void CheckThePermisionOfTheLoggedUser()
        {
            int Counter = 1;
            int UserPermision = clsLogedInUser.LoggedUser.NumberOfPermisions;
            foreach (ToolStripMenuItem Item in menuStrip1.Items)
            {
                if ((Counter & UserPermision) == Counter)
                {
                    Item.Enabled = true;
                }
                else
                {
                    Item.Enabled = false;
                }

                Counter *= 2;
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_3(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        //    private void driversListToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        ListOfDrivers frm = new ListOfDrivers();
        //        frm.ShowDialog();
        //    }

        //    private void addNewDriverToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        AddUpdateDriver frm = new AddUpdateDriver();
        //        frm.ShowDialog();
        //    }

        //    private void updateDriverToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        EnterDriverID frm = new EnterDriverID();
        //        frm.ShowDialog();
        //    }

        //    private void deleteDriverToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        DeleteDriver frm = new DeleteDriver();
        //        frm.ShowDialog();
        //    }

        //    private void findDriverToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        FindDriver frm = new FindDriver();
        //        frm.ShowDialog();
        //    }

        //    private void employeesListToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        EmployeesList frm = new EmployeesList();
        //        frm.ShowDialog();
        //    }

        //    private void FindToolStrip_Click(object sender, EventArgs e)
        //    {
        //        FindEmployee frm = new FindEmployee();
        //        frm.ShowDialog();
        //    }

        //    private void AddEmployeeToolStrip_Click(object sender, EventArgs e)
        //    {
        //        AddUpdateEmployee frm = new AddUpdateEmployee();
        //        frm.ShowDialog();
        //    }

        //    private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        DeleteEmployee frm = new DeleteEmployee();
        //        frm.ShowDialog();
        //    }

        //    private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        EnterEmployeeID frm = new EnterEmployeeID();
        //        frm.ShowDialog();
        //    }

        //    private void usersListToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        UsersList frm = new UsersList();
        //        frm.ShowDialog();
        //    }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void employeesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeList frm=new EmployeeList();
            frm.ShowDialog();
        }

        private void FindEmployeeToolStrip_Click(object sender, EventArgs e)
        {
            FindEmployee frm = new FindEmployee();
            frm.ShowDialog();
        }

        private void AddEmployeeToolStrip_Click(object sender, EventArgs e)
        {
            AddUpdateEmployee frm = new AddUpdateEmployee();
            frm.ShowDialog();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEmployee frm = new DeleteEmployee();
            frm.ShowDialog();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterEmployeeID frm = new EnterEmployeeID();
            frm.ShowDialog();
        }

        private void usersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersList frm = new UsersList();
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword();
            frm.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateEmployee frm = new AddUpdateEmployee();
            frm.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser frm = new DeleteUser();
            frm.ShowDialog();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterUserID frm = new EnterUserID();
            frm.ShowDialog();
        }

        private void findUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindUser frm = new FindUser();
            frm.ShowDialog();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo frm = new UserInfo(clsLogedInUser.LoggedUser);
            frm.ShowDialog();
        }

        private void driversListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriversList frm = new DriversList();
            frm.ShowDialog();
        }

        private void findDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindDriver frm = new FindDriver();
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           LogForm.Show();
           clsLogedInUser.LoggedUser = null;
           this.Close();
           
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfCustomers frm = new ListOfCustomers();
            frm.ShowDialog();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAddCustomers frm = new UpdateAddCustomers();
            frm.ShowDialog();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomer frm = new DeleteCustomer();
            frm.ShowDialog();
        }

        private void udpateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterCustomerID frm = new EnterCustomerID();
            frm.ShowDialog();
        }

        private void findCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindCustomer frm = new FindCustomer();
            frm.ShowDialog();
        }

        //    private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        AddNewUser frm=new AddNewUser();
        //        frm.ShowDialog();
        //    }

        //    private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        DeleteUser frm = new DeleteUser();
        //        frm.ShowDialog();
        //    }

        //    private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        EnterUserID frm = new EnterUserID();
        //        frm.ShowDialog();
        //    }

        //    private void findUserToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        FindUser frm = new FindUser();
        //        frm.ShowDialog();
        //    }

        //    private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        ChangePassword frm = new ChangePassword();
        //        frm.ShowDialog();
        //    }

        //    private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        UserInfo frm = new UserInfo(clsLogedInUser.LoggedUser);
        //        frm.ShowDialog();
        //    }

        //    private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        if(MessageBox.Show("Are you sure to sign out!","Warnning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
        //        {
        //            clsLogedInUser.LoggedUser = null;
        //            LogForm.Show();
        //            this.Close();
        //        }
        //    }

        //    private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        CustomerList frm = new CustomerList();
        //        frm.ShowDialog();
        //    }

        //    private void customerReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        TestForm frm = new TestForm();
        //        frm.ShowDialog();
        //    }
        //}
    }
}
