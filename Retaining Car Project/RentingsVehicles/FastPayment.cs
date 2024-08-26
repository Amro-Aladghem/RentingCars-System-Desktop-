﻿using clsBuesnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaining_Car_Project.RentingsVehicles
{
    public partial class FastPayment : Form
    {
        public FastPayment(clsRenting Renting)
        {
            InitializeComponent();
            this.Renting = Renting;
        }

        public FastPayment(decimal TotalAmount)
        {
            InitializeComponent();
            this.TotalAmount= TotalAmount;
        }


        clsRenting Renting;

        clsPayment NewPayment;

        decimal  ReturnAmount;

        decimal TotalAmount;
        private void FastPayment_Load(object sender, EventArgs e)
        {
            lbTotalPrice.Text=Renting.TotalPrice.ToString()+"jd";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(txtPaidAmount.Text)<Renting.TotalPrice)
            {
                MessageBox.Show("The Paid Amount less than TotalPrice!");
                return;
            }

            decimal Different = Convert.ToDecimal(txtPaidAmount.Text) - Renting.TotalPrice;
            ReturnAmount = Different;
            lbReturn.Text = Different.ToString() + "jd";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtPaidAmount.Text) < Renting.TotalPrice)
            {
                MessageBox.Show("The Paid Amount less than TotalPrice!");
                return;
            }

            NewPayment.PaidAmount = Convert.ToDecimal(txtPaidAmount.Text);
            NewPayment.ReturnAmount = ReturnAmount;
            NewPayment.Note = txtNote.Text;
            NewPayment.DateOfPaid = DateTime.Now;
            NewPayment.RentID = Renting.RentID;

            if(!NewPayment.save())
            {
                MessageBox.Show("There is Somting Error,The Process Canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The Process has done Successfully!");
            this.Close();
        }
    }
}