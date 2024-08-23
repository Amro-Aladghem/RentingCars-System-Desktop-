namespace Retaining_Car_Project.Vehciles
{
    partial class ctrVehicleInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxRentStatus = new System.Windows.Forms.ComboBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmillageCounter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProducedYear = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarTypeID = new System.Windows.Forms.TextBox();
            this.lbCarTypeID = new System.Windows.Forms.Label();
            this.txtVehiclID = new System.Windows.Forms.TextBox();
            this.lbVehicleID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLastRentingDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.lbLastRentingDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxRentStatus);
            this.groupBox1.Controls.Add(this.cbxColor);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.txtIssue);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCarNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtmillageCounter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtProducedYear);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtModelID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCarTypeID);
            this.groupBox1.Controls.Add(this.lbCarTypeID);
            this.groupBox1.Controls.Add(this.txtVehiclID);
            this.groupBox1.Controls.Add(this.lbVehicleID);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 447);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Details";
            // 
            // cbxRentStatus
            // 
            this.cbxRentStatus.Enabled = false;
            this.cbxRentStatus.FormattingEnabled = true;
            this.cbxRentStatus.IntegralHeight = false;
            this.cbxRentStatus.Items.AddRange(new object[] {
            "Rented",
            "Not Rented",
            "Hasing Issues"});
            this.cbxRentStatus.Location = new System.Drawing.Point(183, 327);
            this.cbxRentStatus.Name = "cbxRentStatus";
            this.cbxRentStatus.Size = new System.Drawing.Size(212, 35);
            this.cbxRentStatus.TabIndex = 20;
            // 
            // cbxColor
            // 
            this.cbxColor.Enabled = false;
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(183, 266);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(212, 35);
            this.cbxColor.TabIndex = 19;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(802, 399);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(262, 38);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "You Can leave it without\r\nChange,If No Issues was Found";
            // 
            // txtIssue
            // 
            this.txtIssue.Location = new System.Drawing.Point(794, 279);
            this.txtIssue.Multiline = true;
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.ReadOnly = true;
            this.txtIssue.Size = new System.Drawing.Size(283, 106);
            this.txtIssue.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 54);
            this.label9.TabIndex = 16;
            this.label9.Text = "Some Issue:\r\n\r\n";
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.Location = new System.Drawing.Point(794, 215);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.ReadOnly = true;
            this.txtCarNumber.Size = new System.Drawing.Size(283, 34);
            this.txtCarNumber.TabIndex = 15;
            this.txtCarNumber.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 54);
            this.label8.TabIndex = 14;
            this.label8.Text = "CarNumber:\r\n\r\n";
            // 
            // txtmillageCounter
            // 
            this.txtmillageCounter.Location = new System.Drawing.Point(794, 142);
            this.txtmillageCounter.Name = "txtmillageCounter";
            this.txtmillageCounter.ReadOnly = true;
            this.txtmillageCounter.Size = new System.Drawing.Size(283, 34);
            this.txtmillageCounter.TabIndex = 13;
            this.txtmillageCounter.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "MillageCounterValue:\r\n";
            // 
            // txtProducedYear
            // 
            this.txtProducedYear.Location = new System.Drawing.Point(794, 69);
            this.txtProducedYear.Mask = "----";
            this.txtProducedYear.Name = "txtProducedYear";
            this.txtProducedYear.ReadOnly = true;
            this.txtProducedYear.Size = new System.Drawing.Size(283, 34);
            this.txtProducedYear.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "ProducedYear:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rent Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color :";
            // 
            // txtModelID
            // 
            this.txtModelID.Location = new System.Drawing.Point(183, 196);
            this.txtModelID.Name = "txtModelID";
            this.txtModelID.ReadOnly = true;
            this.txtModelID.Size = new System.Drawing.Size(212, 34);
            this.txtModelID.TabIndex = 5;
            this.txtModelID.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model ID:";
            // 
            // txtCarTypeID
            // 
            this.txtCarTypeID.Location = new System.Drawing.Point(183, 133);
            this.txtCarTypeID.Name = "txtCarTypeID";
            this.txtCarTypeID.ReadOnly = true;
            this.txtCarTypeID.Size = new System.Drawing.Size(212, 34);
            this.txtCarTypeID.TabIndex = 3;
            this.txtCarTypeID.Text = "[???]";
            // 
            // lbCarTypeID
            // 
            this.lbCarTypeID.AutoSize = true;
            this.lbCarTypeID.Location = new System.Drawing.Point(19, 130);
            this.lbCarTypeID.Name = "lbCarTypeID";
            this.lbCarTypeID.Size = new System.Drawing.Size(139, 27);
            this.lbCarTypeID.TabIndex = 2;
            this.lbCarTypeID.Text = "CarTypeID:";
            // 
            // txtVehiclID
            // 
            this.txtVehiclID.Location = new System.Drawing.Point(183, 62);
            this.txtVehiclID.Name = "txtVehiclID";
            this.txtVehiclID.ReadOnly = true;
            this.txtVehiclID.Size = new System.Drawing.Size(212, 34);
            this.txtVehiclID.TabIndex = 1;
            this.txtVehiclID.Text = "[???]";
            // 
            // lbVehicleID
            // 
            this.lbVehicleID.AutoSize = true;
            this.lbVehicleID.Location = new System.Drawing.Point(19, 62);
            this.lbVehicleID.Name = "lbVehicleID";
            this.lbVehicleID.Size = new System.Drawing.Size(135, 27);
            this.lbVehicleID.TabIndex = 0;
            this.lbVehicleID.Text = "Vehicle ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Last RentingDay:";
            // 
            // lbLastRentingDate
            // 
            this.lbLastRentingDate.AutoSize = true;
            this.lbLastRentingDate.Location = new System.Drawing.Point(227, 393);
            this.lbLastRentingDate.Name = "lbLastRentingDate";
            this.lbLastRentingDate.Size = new System.Drawing.Size(68, 27);
            this.lbLastRentingDate.TabIndex = 22;
            this.lbLastRentingDate.Text = "[???]";
            // 
            // ctrVehicleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrVehicleInfo";
            this.Size = new System.Drawing.Size(1203, 480);
            this.Load += new System.EventHandler(this.ctrVehicleInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxRentStatus;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmillageCounter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtProducedYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarTypeID;
        private System.Windows.Forms.Label lbCarTypeID;
        private System.Windows.Forms.TextBox txtVehiclID;
        private System.Windows.Forms.Label lbVehicleID;
        private System.Windows.Forms.Label lbLastRentingDate;
        private System.Windows.Forms.Label label1;
    }
}
