using clsBuesnesLayer;
using LoginSystem;
using Retaining_Car_Project.Applications;
using Retaining_Car_Project.Drivers;
using Retaining_Car_Project.Employees;
using Retaining_Car_Project.LateFees;
using Retaining_Car_Project.Managment;
using Retaining_Car_Project.Notifications;
using Retaining_Car_Project.Payments;
using Retaining_Car_Project.RentingsVehicles;
using Retaining_Car_Project.SystemCustomer;
using Retaining_Car_Project.SystemRules;
using Retaining_Car_Project.Users;
using Retaining_Car_Project.Vehciles;
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
using static clsBuesnesLayer.clsApplications;

namespace LoginSystem
{
    public partial class MainForm : Form
    {
        public MainForm(Form logForm)
        {
            InitializeComponent();
            LogForm = logForm;
        }


        Form LogForm;
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripButton1.Text = clsGlobal.LoggedUser.UserName;

            Task.Run(() =>
            {
                clsApplications.AddNewApplication(eApplicationType.Login, clsGlobal.LoggedUser.UserID);

                this.Invoke((Action)(() =>
                {
                    CheckThePermisionOfTheLoggedUser();
                    btnNotification.Text=clsGlobal.NumberOfNotificationList.ToString();

                }));
            });
        }


        private void CheckThePermisionOfTheLoggedUser()
        {
            int Counter = 1;
            int UserPermision = clsGlobal.LoggedUser.NumberOfPermisions;
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
            UserInfo frm = new UserInfo(clsGlobal.LoggedUser);
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
           clsGlobal.LoggedUser = null;
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

        private void vehiclesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfVehciles frm = new ListOfVehciles();
            frm.ShowDialog();
        }

        private void addUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateDetailsForVehicle frm = new AddUpdateDetailsForVehicle();
            frm.ShowDialog();
        }

        private void deleteVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteVehicle frm = new DeleteVehicle();
            frm.ShowDialog();
        }

        private void findVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindVehicle frm = new FindVehicle();
            frm.ShowDialog();
        }

        private void carsListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListOfCars frm = new ListOfCars();
            frm.ShowDialog();
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddingNewCarInSystem frm = new AddingNewCarInSystem();
            frm.ShowDialog();
        }

        private void rentingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentingList frm = new RentingList();
            frm.ShowDialog();
        }

        private void makeNewPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeNewPayment frm =new MakeNewPayment();
            frm.ShowDialog();
        }

        private void paymentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentsList frm = new PaymentsList();
            frm.ShowDialog();
        }

        private void findPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindPayment frm = new FindPayment();
            frm.ShowDialog();
        }

        private void payRentingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayRenting frm = new PayRenting();
            frm.ShowDialog();
        }

        private void vehcileRentingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVehiclePrice frm = new UpdateVehiclePrice();
            frm.ShowDialog();
        }

        private void driverRentingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDriverFees frm = new ChangeDriverFees();
            frm.ShowDialog();
        }

        private void addVehicleRentingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehcilePrice frm = new AddVehcilePrice();
            frm.ShowDialog();
        }

        private void vehcilesRentingPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehiclesRentPricesList frm = new VehiclesRentPricesList();
            frm.ShowDialog();
        }

        private void staticRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticReulesList frm = new StaticReulesList();
            frm.ShowDialog(); 
        }

        private void notificationsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotificationsList frm = new NotificationsList();
            frm.Show();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature does not implemented yeat", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sendSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature does not implemented yeat", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lateFeesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LateFeesList frm = new LateFeesList();
            frm.ShowDialog();
        }

        private void addFeesForRentingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLateFeesForRenting frm = new AddLateFeesForRenting();
            frm.ShowDialog();
        }

        private void applicationListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationsList frm = new ApplicationsList();
            frm.ShowDialog();
        }

        private void rentingYearlyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentingYearlyReport frm = new RentingYearlyReport();
            frm.ShowDialog();
        }

        private void rentingMonthlyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentingMonthlyRebort frm = new RentingMonthlyRebort();
            frm.ShowDialog();
        }

        private void managerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerList frm = new ManagerList();
            frm.Show();
        }

        private void addManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewManger frm = new AddNewManger();
            frm.ShowDialog();
        }

        private void schedulingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchedulingHistoryList frm = new SchedulingHistoryList();
            frm.ShowDialog();
        }

        private void btnNewRenting_Click(object sender, EventArgs e)
        {
            AddNewRenting frm = new AddNewRenting();
            frm.Show();
        }

        private void btnPayRenting_Click(object sender, EventArgs e)
        {
            PayRenting frm = new PayRenting();
            frm.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            UpdateAddCustomers frm = new UpdateAddCustomers();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeNewPayment frm = new MakeNewPayment();
            frm.Show();
        }

        private void toolStripNotification_Click(object sender, EventArgs e)
        {
            NotificationsList frm = new NotificationsList();
            frm.Show();
        }

        private void toolStripSearchVeh_Click(object sender, EventArgs e)
        {
            FindVehicle frm = new FindVehicle();
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FindCustomer frm = new FindCustomer();
            frm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogForm.Show();
            clsGlobal.LoggedUser = null;
            this.Close();
        }

        private void newRentingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewRenting frm = new AddNewRenting();
            frm.ShowDialog();
        }

        private void payRentingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PayRenting frm = new PayRenting();
            frm.ShowDialog();
        }

        private void editRentingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditingOnRenting frm = new EditingOnRenting();
            frm.ShowDialog();
        }
    }
}
