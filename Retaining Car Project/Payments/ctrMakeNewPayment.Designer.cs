namespace Retaining_Car_Project.Payments
{
    partial class ctrMakeNewPayment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrMakeNewPayment));
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ctrRentingInfo1 = new Retaining_Car_Project.RentingsVehicles.ctrRentingInfo();
            this.rdRentID = new System.Windows.Forms.RadioButton();
            this.rdCustomer = new System.Windows.Forms.RadioButton();
            this.gbRentID = new System.Windows.Forms.GroupBox();
            this.btnSeacthRent = new System.Windows.Forms.Button();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPaymentInfo = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbReason = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPaymentAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.gbCustomer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbRentID.SuspendLayout();
            this.gbPaymentInfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomer
            // 
            this.gbCustomer.BackColor = System.Drawing.Color.White;
            this.gbCustomer.Controls.Add(this.btnSearchCustomer);
            this.gbCustomer.Controls.Add(this.txtLastName);
            this.gbCustomer.Controls.Add(this.label3);
            this.gbCustomer.Controls.Add(this.label2);
            this.gbCustomer.Controls.Add(this.txtFirstName);
            this.gbCustomer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbCustomer.Location = new System.Drawing.Point(10, 33);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(1009, 116);
            this.gbCustomer.TabIndex = 23;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Search CustomerName";
            this.gbCustomer.Visible = false;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.BackgroundImage")));
            this.btnSearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Location = new System.Drawing.Point(914, 37);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(69, 65);
            this.btnSearchCustomer.TabIndex = 3;
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click_1);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Silver;
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtLastName.Location = new System.Drawing.Point(650, 63);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(236, 39);
            this.txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(480, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "LastName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(43, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "FirstName:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Silver;
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.Location = new System.Drawing.Point(235, 66);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(236, 39);
            this.txtFirstName.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.ctrRentingInfo1);
            this.panel3.Location = new System.Drawing.Point(17, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 349);
            this.panel3.TabIndex = 26;
            // 
            // ctrRentingInfo1
            // 
            this.ctrRentingInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrRentingInfo1.Location = new System.Drawing.Point(0, 3);
            this.ctrRentingInfo1.Name = "ctrRentingInfo1";
            this.ctrRentingInfo1.Size = new System.Drawing.Size(983, 477);
            this.ctrRentingInfo1.TabIndex = 0;
            // 
            // rdRentID
            // 
            this.rdRentID.AutoSize = true;
            this.rdRentID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdRentID.Location = new System.Drawing.Point(671, 3);
            this.rdRentID.Name = "rdRentID";
            this.rdRentID.Size = new System.Drawing.Size(117, 23);
            this.rdRentID.TabIndex = 25;
            this.rdRentID.TabStop = true;
            this.rdRentID.Text = "By RentID";
            this.rdRentID.UseVisualStyleBackColor = true;
            this.rdRentID.CheckedChanged += new System.EventHandler(this.rdRentID_CheckedChanged);
            // 
            // rdCustomer
            // 
            this.rdCustomer.AutoSize = true;
            this.rdCustomer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdCustomer.Location = new System.Drawing.Point(840, 2);
            this.rdCustomer.Name = "rdCustomer";
            this.rdCustomer.Size = new System.Drawing.Size(179, 23);
            this.rdCustomer.TabIndex = 24;
            this.rdCustomer.TabStop = true;
            this.rdCustomer.Text = "ByCustomerName";
            this.rdCustomer.UseVisualStyleBackColor = true;
            this.rdCustomer.CheckedChanged += new System.EventHandler(this.rdCustomer_CheckedChanged);
            // 
            // gbRentID
            // 
            this.gbRentID.BackColor = System.Drawing.Color.White;
            this.gbRentID.Controls.Add(this.btnSeacthRent);
            this.gbRentID.Controls.Add(this.txtRentID);
            this.gbRentID.Controls.Add(this.label1);
            this.gbRentID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbRentID.Location = new System.Drawing.Point(17, 31);
            this.gbRentID.Name = "gbRentID";
            this.gbRentID.Size = new System.Drawing.Size(998, 115);
            this.gbRentID.TabIndex = 22;
            this.gbRentID.TabStop = false;
            this.gbRentID.Text = "Search By Rent";
            // 
            // btnSeacthRent
            // 
            this.btnSeacthRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSeacthRent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeacthRent.BackgroundImage")));
            this.btnSeacthRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeacthRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeacthRent.Location = new System.Drawing.Point(788, 29);
            this.btnSeacthRent.Name = "btnSeacthRent";
            this.btnSeacthRent.Size = new System.Drawing.Size(76, 66);
            this.btnSeacthRent.TabIndex = 2;
            this.btnSeacthRent.UseVisualStyleBackColor = false;
            this.btnSeacthRent.Click += new System.EventHandler(this.btnSeacthRent_Click_1);
            // 
            // txtRentID
            // 
            this.txtRentID.BackColor = System.Drawing.Color.Silver;
            this.txtRentID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtRentID.Location = new System.Drawing.Point(287, 56);
            this.txtRentID.Multiline = true;
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(427, 39);
            this.txtRentID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(120, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rent ID :";
            // 
            // gbPaymentInfo
            // 
            this.gbPaymentInfo.BackColor = System.Drawing.Color.White;
            this.gbPaymentInfo.Controls.Add(this.label9);
            this.gbPaymentInfo.Controls.Add(this.btnCheck);
            this.gbPaymentInfo.Controls.Add(this.txtReturn);
            this.gbPaymentInfo.Controls.Add(this.txtPaid);
            this.gbPaymentInfo.Controls.Add(this.label8);
            this.gbPaymentInfo.Controls.Add(this.label5);
            this.gbPaymentInfo.Controls.Add(this.panel5);
            this.gbPaymentInfo.Controls.Add(this.panel4);
            this.gbPaymentInfo.Controls.Add(this.panel2);
            this.gbPaymentInfo.Controls.Add(this.panel1);
            this.gbPaymentInfo.Location = new System.Drawing.Point(17, 517);
            this.gbPaymentInfo.Name = "gbPaymentInfo";
            this.gbPaymentInfo.Size = new System.Drawing.Size(1002, 222);
            this.gbPaymentInfo.TabIndex = 27;
            this.gbPaymentInfo.TabStop = false;
            this.gbPaymentInfo.Text = "Payment Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(628, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Calculate/Check";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Gray;
            this.btnCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.BackgroundImage")));
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(529, 159);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 56);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtReturn
            // 
            this.txtReturn.BackColor = System.Drawing.Color.DarkGray;
            this.txtReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtReturn.Location = new System.Drawing.Point(633, 91);
            this.txtReturn.Multiline = true;
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(341, 43);
            this.txtReturn.TabIndex = 7;
            this.txtReturn.Text = "0";
            this.txtReturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReturn_KeyPress);
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.Color.DarkGray;
            this.txtPaid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtPaid.Location = new System.Drawing.Point(633, 26);
            this.txtPaid.Multiline = true;
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(341, 43);
            this.txtPaid.TabIndex = 6;
            this.txtPaid.Text = "0";
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            this.txtPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaid_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(524, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Return:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(526, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Paid:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Location = new System.Drawing.Point(479, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(25, 222);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.lbReason);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(20, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 56);
            this.panel4.TabIndex = 3;
            // 
            // lbReason
            // 
            this.lbReason.AutoSize = true;
            this.lbReason.BackColor = System.Drawing.Color.White;
            this.lbReason.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbReason.Location = new System.Drawing.Point(117, 14);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(55, 29);
            this.lbReason.TabIndex = 1;
            this.lbReason.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Reason:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.txtNote);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(20, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 56);
            this.panel2.TabIndex = 2;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(98, 3);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(301, 48);
            this.txtNote.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Note:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.lbPaymentAmount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(20, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 56);
            this.panel1.TabIndex = 0;
            // 
            // lbPaymentAmount
            // 
            this.lbPaymentAmount.AutoSize = true;
            this.lbPaymentAmount.BackColor = System.Drawing.Color.White;
            this.lbPaymentAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbPaymentAmount.Location = new System.Drawing.Point(238, 14);
            this.lbPaymentAmount.Name = "lbPaymentAmount";
            this.lbPaymentAmount.Size = new System.Drawing.Size(55, 29);
            this.lbPaymentAmount.TabIndex = 1;
            this.lbPaymentAmount.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Payment Amount:";
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.BackColor = System.Drawing.Color.White;
            this.btnMakePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakePayment.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakePayment.Location = new System.Drawing.Point(349, 769);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(329, 74);
            this.btnMakePayment.TabIndex = 28;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = false;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // ctrMakeNewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.gbPaymentInfo);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rdRentID);
            this.Controls.Add(this.rdCustomer);
            this.Controls.Add(this.gbRentID);
            this.Name = "ctrMakeNewPayment";
            this.Size = new System.Drawing.Size(1036, 868);
            this.Load += new System.EventHandler(this.ctrMakeNewPayment_Load);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gbRentID.ResumeLayout(false);
            this.gbRentID.PerformLayout();
            this.gbPaymentInfo.ResumeLayout(false);
            this.gbPaymentInfo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Panel panel3;
        private RentingsVehicles.ctrRentingInfo ctrRentingInfo1;
        private System.Windows.Forms.RadioButton rdRentID;
        private System.Windows.Forms.RadioButton rdCustomer;
        private System.Windows.Forms.GroupBox gbRentID;
        private System.Windows.Forms.Button btnSeacthRent;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPaymentInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbReason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPaymentAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.TextBox txtNote;
    }
}
