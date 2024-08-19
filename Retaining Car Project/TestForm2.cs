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
    public partial class TestForm2 : Form
    {
        public TestForm2()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            dataGridView1.DataSource = clsUsers.GetAllPeople();
        }

        private void TestForm2_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
