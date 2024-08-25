﻿namespace Retaining_Car_Project.RentingsVehicles
{
    partial class ctrAddNewRenting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrAddNewRenting));
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbNewRent = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCarType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCarModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCheckCar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbHeadOfCar = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.numaricNumberOfDays = new System.Windows.Forms.NumericUpDown();
            this.lbCarInfo = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxDriver = new System.Windows.Forms.CheckBox();
            this.gbDriver = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxAvaDriver = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbDriverInfo = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.btnReturnPay = new System.Windows.Forms.Button();
            this.gbCustomer.SuspendLayout();
            this.gbNewRent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricNumberOfDays)).BeginInit();
            this.gbDriver.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomer
            // 
            this.gbCustomer.BackColor = System.Drawing.Color.White;
            this.gbCustomer.Controls.Add(this.btnAdd);
            this.gbCustomer.Controls.Add(this.btnSearch);
            this.gbCustomer.Controls.Add(this.txtCustomerID);
            this.gbCustomer.Controls.Add(this.label1);
            this.gbCustomer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomer.Location = new System.Drawing.Point(18, 17);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(1028, 113);
            this.gbCustomer.TabIndex = 0;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.Silver;
            this.txtCustomerID.Location = new System.Drawing.Point(241, 51);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(320, 36);
            this.txtCustomerID.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(580, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(746, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(233, 49);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add New \r\n";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // gbNewRent
            // 
            this.gbNewRent.BackColor = System.Drawing.Color.White;
            this.gbNewRent.Controls.Add(this.btnReturnPay);
            this.gbNewRent.Controls.Add(this.btnPayNow);
            this.gbNewRent.Controls.Add(this.panel1);
            this.gbNewRent.Controls.Add(this.gbDriver);
            this.gbNewRent.Controls.Add(this.cbxDriver);
            this.gbNewRent.Controls.Add(this.label8);
            this.gbNewRent.Controls.Add(this.numaricNumberOfDays);
            this.gbNewRent.Controls.Add(this.label7);
            this.gbNewRent.Controls.Add(this.groupBox1);
            this.gbNewRent.Enabled = false;
            this.gbNewRent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewRent.Location = new System.Drawing.Point(18, 153);
            this.gbNewRent.Name = "gbNewRent";
            this.gbNewRent.Size = new System.Drawing.Size(1028, 863);
            this.gbNewRent.TabIndex = 1;
            this.gbNewRent.TabStop = false;
            this.gbNewRent.Text = "New Renting";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.lbCarInfo);
            this.groupBox1.Controls.Add(this.lbHeadOfCar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCheckCar);
            this.groupBox1.Controls.Add(this.dateTimeEnd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimeStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxCarModel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxCarType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(37, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "select car:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "CarType:";
            // 
            // cbxCarType
            // 
            this.cbxCarType.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.cbxCarType.FormattingEnabled = true;
            this.cbxCarType.Location = new System.Drawing.Point(160, 50);
            this.cbxCarType.Name = "cbxCarType";
            this.cbxCarType.Size = new System.Drawing.Size(216, 35);
            this.cbxCarType.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(434, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "CarModel:";
            // 
            // cbxCarModel
            // 
            this.cbxCarModel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.cbxCarModel.FormattingEnabled = true;
            this.cbxCarModel.Location = new System.Drawing.Point(566, 55);
            this.cbxCarModel.Name = "cbxCarModel";
            this.cbxCarModel.Size = new System.Drawing.Size(216, 35);
            this.cbxCarModel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(262, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "StartDate:";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dateTimeStart.Location = new System.Drawing.Point(379, 128);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(215, 27);
            this.dateTimeStart.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(271, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "EndDate:";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dateTimeEnd.Location = new System.Drawing.Point(379, 180);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(215, 27);
            this.dateTimeEnd.TabIndex = 7;
            // 
            // btnCheckCar
            // 
            this.btnCheckCar.BackColor = System.Drawing.Color.White;
            this.btnCheckCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckCar.BackgroundImage")));
            this.btnCheckCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCheckCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCar.Location = new System.Drawing.Point(818, 36);
            this.btnCheckCar.Name = "btnCheckCar";
            this.btnCheckCar.Size = new System.Drawing.Size(88, 65);
            this.btnCheckCar.TabIndex = 8;
            this.btnCheckCar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(824, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Check?";
            // 
            // lbHeadOfCar
            // 
            this.lbHeadOfCar.AutoSize = true;
            this.lbHeadOfCar.BackColor = System.Drawing.Color.Red;
            this.lbHeadOfCar.LinkColor = System.Drawing.Color.Yellow;
            this.lbHeadOfCar.Location = new System.Drawing.Point(336, 11);
            this.lbHeadOfCar.Name = "lbHeadOfCar";
            this.lbHeadOfCar.Size = new System.Drawing.Size(258, 22);
            this.lbHeadOfCar.TabIndex = 10;
            this.lbHeadOfCar.TabStop = true;
            this.lbHeadOfCar.Text = "This Car Not Available! Now";
            this.lbHeadOfCar.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "NumberOfDays:";
            // 
            // numaricNumberOfDays
            // 
            this.numaricNumberOfDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numaricNumberOfDays.Location = new System.Drawing.Point(241, 318);
            this.numaricNumberOfDays.Name = "numaricNumberOfDays";
            this.numaricNumberOfDays.Size = new System.Drawing.Size(250, 36);
            this.numaricNumberOfDays.TabIndex = 2;
            // 
            // lbCarInfo
            // 
            this.lbCarInfo.AutoSize = true;
            this.lbCarInfo.Location = new System.Drawing.Point(802, 201);
            this.lbCarInfo.Name = "lbCarInfo";
            this.lbCarInfo.Size = new System.Drawing.Size(152, 22);
            this.lbCarInfo.TabIndex = 11;
            this.lbCarInfo.TabStop = true;
            this.lbCarInfo.Text = "Car information";
            this.lbCarInfo.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "With Driver :\r\n";
            // 
            // cbxDriver
            // 
            this.cbxDriver.AutoSize = true;
            this.cbxDriver.Location = new System.Drawing.Point(241, 391);
            this.cbxDriver.Name = "cbxDriver";
            this.cbxDriver.Size = new System.Drawing.Size(165, 33);
            this.cbxDriver.TabIndex = 4;
            this.cbxDriver.Text = "withDriver";
            this.cbxDriver.UseVisualStyleBackColor = true;
            // 
            // gbDriver
            // 
            this.gbDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbDriver.Controls.Add(this.lbDriverInfo);
            this.gbDriver.Controls.Add(this.btnSelect);
            this.gbDriver.Controls.Add(this.cbxAvaDriver);
            this.gbDriver.Controls.Add(this.label9);
            this.gbDriver.Enabled = false;
            this.gbDriver.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbDriver.Location = new System.Drawing.Point(37, 448);
            this.gbDriver.Name = "gbDriver";
            this.gbDriver.Size = new System.Drawing.Size(942, 183);
            this.gbDriver.TabIndex = 5;
            this.gbDriver.TabStop = false;
            this.gbDriver.Text = "select Driver:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(53, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "Available Drivers :";
            // 
            // cbxAvaDriver
            // 
            this.cbxAvaDriver.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.cbxAvaDriver.FormattingEnabled = true;
            this.cbxAvaDriver.Location = new System.Drawing.Point(274, 59);
            this.cbxAvaDriver.Name = "cbxAvaDriver";
            this.cbxAvaDriver.Size = new System.Drawing.Size(222, 35);
            this.cbxAvaDriver.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelect.Location = new System.Drawing.Point(708, 52);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(198, 45);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // lbDriverInfo
            // 
            this.lbDriverInfo.AutoSize = true;
            this.lbDriverInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbDriverInfo.Location = new System.Drawing.Point(783, 149);
            this.lbDriverInfo.Name = "lbDriverInfo";
            this.lbDriverInfo.Size = new System.Drawing.Size(181, 22);
            this.lbDriverInfo.TabIndex = 12;
            this.lbDriverInfo.TabStop = true;
            this.lbDriverInfo.Text = "Driver Information";
            this.lbDriverInfo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 29);
            this.label10.TabIndex = 6;
            this.label10.Text = "Total Price :";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.BackColor = System.Drawing.Color.White;
            this.lbTotalPrice.Location = new System.Drawing.Point(166, 11);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(90, 29);
            this.lbTotalPrice.TabIndex = 7;
            this.lbTotalPrice.Text = "00.0jd";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbTotalPrice);
            this.panel1.Location = new System.Drawing.Point(37, 668);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 49);
            this.panel1.TabIndex = 13;
            // 
            // btnPayNow
            // 
            this.btnPayNow.Location = new System.Drawing.Point(197, 778);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(194, 51);
            this.btnPayNow.TabIndex = 14;
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = true;
            // 
            // btnReturnPay
            // 
            this.btnReturnPay.Location = new System.Drawing.Point(625, 778);
            this.btnReturnPay.Name = "btnReturnPay";
            this.btnReturnPay.Size = new System.Drawing.Size(194, 51);
            this.btnReturnPay.TabIndex = 15;
            this.btnReturnPay.Text = "Return Pay";
            this.btnReturnPay.UseVisualStyleBackColor = true;
            // 
            // ctrAddNewRenting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.gbNewRent);
            this.Controls.Add(this.gbCustomer);
            this.Name = "ctrAddNewRenting";
            this.Size = new System.Drawing.Size(1065, 1048);
            this.Load += new System.EventHandler(this.ctrAddNewRenting_Load);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbNewRent.ResumeLayout(false);
            this.gbNewRent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricNumberOfDays)).EndInit();
            this.gbDriver.ResumeLayout(false);
            this.gbDriver.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbNewRent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxCarType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCarModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckCar;
        private System.Windows.Forms.LinkLabel lbHeadOfCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numaricNumberOfDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lbCarInfo;
        private System.Windows.Forms.GroupBox gbDriver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbxDriver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lbDriverInfo;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cbxAvaDriver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Button btnReturnPay;
        private System.Windows.Forms.Button btnPayNow;
    }
}