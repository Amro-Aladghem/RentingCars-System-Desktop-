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

namespace Retaining_Car_Project.Managment
{
    public partial class AddNewManger : Form
    {
        public AddNewManger()
        {
            InitializeComponent();
        }

        int UserID;
        clsManager NewManager = new clsManager();

        private DataTable GetAllSectionsName()
        {
            DataTable result = new DataTable();
            result = clsManager.GetAllSectionsNameInSys();
            return result;
        }

        private void _PerformCbx(DataTable dt)
        {
            foreach(DataRow dr in dt.Rows)
            {
                cbxSections.Items.Add(dr["SectionName"]);
            }

            cbxSections.SelectedIndex = 0;
        }




        private void ctrUserInfoWithFilter1_OnSearchClick(object sender, Users.ctrUserInfoWithFilter.GetUserObject e)
        {
            if (clsManager.IsUserIsAManager(e.User.UserID))
            {
                MessageBox.Show("This User is already is a Manager , you cant adding with ths same User!");
                return;
            }

            UserID = e.User.UserID;
            txtManagerName.Enabled = true;
            cbxSections.Enabled = true;
            btnSave.Enabled= true;
            lbUserId.Text = UserID.ToString();
        }

        private void AddNewManger_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                // Simulate loading small data
                var data = GetAllSectionsName();

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    _PerformCbx(data);
                }));
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtManagerName.Text=="")
            {
                MessageBox.Show("You must Enter the Mangaer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(MessageBox.Show("Are You sure to Add this Manager!","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Cancel)
            {
                MessageBox.Show("The Process has been Cancled!");
                return;
            }


            if(!clsManager.AddNewManager(cbxSections.SelectedIndex+1,txtManagerName.Text,UserID))
            {
                MessageBox.Show("The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Proces has been Done Successfully!, You can close this window!");
            btnSave.Enabled = false;
        }
    }
}
