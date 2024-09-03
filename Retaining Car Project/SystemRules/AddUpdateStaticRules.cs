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
    public partial class AddUpdateStaticRules : Form
    {
        enum eMode { Addnew=1,Update=2}
        eMode Mode;


        public AddUpdateStaticRules()
        {
            InitializeComponent();
            Mode = eMode.Addnew;
        }

        public AddUpdateStaticRules(int StaticRulesID)
        {
            InitializeComponent();
            this.StaticRulesID = StaticRulesID;
            txtRulesName.Enabled = false;
            Mode = eMode.Update;
        }

        int StaticRulesID;

        private void AddUpdateStaticRules_Load(object sender, EventArgs e)
        {

        }


        private void btnExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Mode == eMode.Addnew)
            {
                if(!clsSystemRules.AddNewStaticRules(txtRulesName.Text,txtDiscribtion.Text))
                {
                    MessageBox.Show("Somting Error!,The Process has been Cancled!");
                    return;
                }
            }
            else
            {
                if(!clsSystemRules.UpdateStaticRules(StaticRulesID,txtDiscribtion.Text))
                {
                    MessageBox.Show("Somting Error!,The Process has been Cancled!");
                    return;
                }
            }


            MessageBox.Show("The Process has been Done Successfully!", "informateion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
