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

namespace Retaining_Car_Project.SystemRules
{
    public partial class StaticReulesList : Form
    {
        public StaticReulesList()
        {
            InitializeComponent();
        }

        private void _ReffreshData()
        {
            dataGridView1.DataSource = clsSystemRules.GetAllStaticRulesRecord();
            lbRecords.Text = dataGridView1.RowCount.ToString();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();
            dt = clsSystemRules.GetAllStaticRulesRecord();
            return dt;
        }





        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateStaticRules frm = new AddUpdateStaticRules();
            frm.ShowDialog();
            _ReffreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=1)
            {
                MessageBox.Show("You must select one 1 record","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
            }

            AddUpdateStaticRules frm = new AddUpdateStaticRules((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateStaticRules frm = new AddUpdateStaticRules((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _ReffreshData();
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Record,This will impact on Renting Process", "Warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            if(!clsSystemRules.DeleteStaticRules((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("The Process has been Cancled!,Please try again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
                return;
            }

            _ReffreshData();
        }

        private void StaticReulesList_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {

                // Simulate loading small data
                var data = _LoadData();

                // Safely update the DataGridView on the UI thread
                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }));
            });
        }
    }


}


                    