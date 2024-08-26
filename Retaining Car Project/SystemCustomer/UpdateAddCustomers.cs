using clsBuesnesLayer;
using Retaining_Car_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.SystemCustomer
{
    public partial class UpdateAddCustomers : Form
    {
        enum eMode { AddNew=1,Udpate=2}
        eMode Mode;

        public delegate void OnAddNewCustomer(int CustomerID);
        public OnAddNewCustomer OnAddNew;

        public UpdateAddCustomers()
        {
            InitializeComponent();
            Mode = eMode.AddNew;
            lbHead.Text = "AddNew Customer";
            pictureBox1.Image = Resources.add__1_;
        }

        public UpdateAddCustomers(clsCustomers Customer)
        {
            InitializeComponent();
            Mode=eMode.Udpate;
            ctrUpdateAddCustomer1.GetObjectAndCreatClass(Customer);
            lbHead.Text = "Update Customer";
            pictureBox1.Image = Resources.business;

        }



        private void UpdateAddCustomers_Load(object sender, EventArgs e)
        {
            
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrUpdateAddCustomer1_OnSaveClick(object sender, ctrUpdateAddCustomer.GetObjectOfCustomer e)
        {
            if (Mode == eMode.AddNew)
            {

                lbHead.Text = "Update Customer";
                pictureBox1.Image = Resources.business;
                OnAddNew?.Invoke(e.Customer.CustomerID);
            }
        }
    }
}
