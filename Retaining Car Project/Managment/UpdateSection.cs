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
    public partial class UpdateSection : Form
    {
        public UpdateSection(int ManagerID)
        {
            InitializeComponent();
            this.ManagerId= ManagerID;
        }

        int ManagerId;

        private DataTable GetAllSectionsName()
        {
            DataTable result = new DataTable();
            result = clsManager.GetAllSectionsNameInSys();
            return result;
        }

        private void _PerformCbx(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                cbxSections.Items.Add(dr["SectionName"]);
            }

            cbxSections.SelectedIndex = 0;
        }


        private void UpdateSection_Load(object sender, EventArgs e)
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
            if (MessageBox.Show("Are You sure to Update this Manager!", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                MessageBox.Show("The Process has been Cancled!");
                return;
            }

            if(!clsManager.UpdateManger(ManagerId, cbxSections.SelectedIndex+1))
            {
                MessageBox.Show("The Process has been Cancled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Proces has been Done Successfully!, You can close this window!");
            btnSave.Enabled = false;

        }
    }
}
