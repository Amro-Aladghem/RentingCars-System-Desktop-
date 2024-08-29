namespace Retaining_Car_Project.RentingsVehicles
{
    partial class EditingRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingRent));
            this.panel3 = new System.Windows.Forms.Panel();
            this.ctrRentingInfo1 = new Retaining_Car_Project.RentingsVehicles.ctrRentingInfo();
            this.rdRentID = new System.Windows.Forms.RadioButton();
            this.rdCustomer = new System.Windows.Forms.RadioButton();
            this.gbRentID = new System.Windows.Forms.GroupBox();
            this.btnSeacthRent = new System.Windows.Forms.Button();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbEditing = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbCarInfo = new System.Windows.Forms.LinkLabel();
            this.cbwithdriver = new System.Windows.Forms.CheckBox();
            this.cbxDriver = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numaricDayNum = new System.Windows.Forms.NumericUpDown();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cbxModels = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbReturnMoney = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.btnReturnPay = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.gbRentID.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.gbEditing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricDayNum)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.ctrRentingInfo1);
            this.panel3.Location = new System.Drawing.Point(17, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 349);
            this.panel3.TabIndex = 25;
            // 
            // ctrRentingInfo1
            // 
            this.ctrRentingInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrRentingInfo1.Location = new System.Drawing.Point(0, -1);
            this.ctrRentingInfo1.Name = "ctrRentingInfo1";
            this.ctrRentingInfo1.Size = new System.Drawing.Size(986, 477);
            this.ctrRentingInfo1.TabIndex = 0;
            // 
            // rdRentID
            // 
            this.rdRentID.AutoSize = true;
            this.rdRentID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdRentID.Location = new System.Drawing.Point(694, 4);
            this.rdRentID.Name = "rdRentID";
            this.rdRentID.Size = new System.Drawing.Size(117, 23);
            this.rdRentID.TabIndex = 24;
            this.rdRentID.TabStop = true;
            this.rdRentID.Text = "By RentID";
            this.rdRentID.UseVisualStyleBackColor = true;
            this.rdRentID.CheckedChanged += new System.EventHandler(this.rdRentID_CheckedChanged);
            // 
            // rdCustomer
            // 
            this.rdCustomer.AutoSize = true;
            this.rdCustomer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdCustomer.Location = new System.Drawing.Point(844, 4);
            this.rdCustomer.Name = "rdCustomer";
            this.rdCustomer.Size = new System.Drawing.Size(179, 23);
            this.rdCustomer.TabIndex = 23;
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
            this.gbRentID.Location = new System.Drawing.Point(14, 32);
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
            this.btnSeacthRent.Click += new System.EventHandler(this.btnSeacthRent_Click);
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
            this.txtRentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentID_KeyPress);
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
            // gbCustomer
            // 
            this.gbCustomer.BackColor = System.Drawing.Color.White;
            this.gbCustomer.Controls.Add(this.btnSearchCustomer);
            this.gbCustomer.Controls.Add(this.txtLastName);
            this.gbCustomer.Controls.Add(this.label3);
            this.gbCustomer.Controls.Add(this.txtFirstName);
            this.gbCustomer.Controls.Add(this.label2);
            this.gbCustomer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbCustomer.Location = new System.Drawing.Point(20, 32);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(998, 116);
            this.gbCustomer.TabIndex = 1;
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
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
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
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Silver;
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.Location = new System.Drawing.Point(209, 58);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(236, 39);
            this.txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "FirstName:";
            // 
            // gbEditing
            // 
            this.gbEditing.BackColor = System.Drawing.Color.White;
            this.gbEditing.Controls.Add(this.btnCalculate);
            this.gbEditing.Controls.Add(this.lbCarInfo);
            this.gbEditing.Controls.Add(this.cbwithdriver);
            this.gbEditing.Controls.Add(this.cbxDriver);
            this.gbEditing.Controls.Add(this.label9);
            this.gbEditing.Controls.Add(this.numaricDayNum);
            this.gbEditing.Controls.Add(this.dateTimeStart);
            this.gbEditing.Controls.Add(this.label8);
            this.gbEditing.Controls.Add(this.label7);
            this.gbEditing.Controls.Add(this.lbHeader);
            this.gbEditing.Controls.Add(this.label6);
            this.gbEditing.Controls.Add(this.btnCheck);
            this.gbEditing.Controls.Add(this.cbxModels);
            this.gbEditing.Controls.Add(this.label5);
            this.gbEditing.Controls.Add(this.cbxTypes);
            this.gbEditing.Controls.Add(this.label4);
            this.gbEditing.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbEditing.Location = new System.Drawing.Point(20, 510);
            this.gbEditing.Name = "gbEditing";
            this.gbEditing.Size = new System.Drawing.Size(1003, 232);
            this.gbEditing.TabIndex = 26;
            this.gbEditing.TabStop = false;
            this.gbEditing.Text = "Editing Renting";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(609, 184);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 42);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbCarInfo
            // 
            this.lbCarInfo.AutoSize = true;
            this.lbCarInfo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbCarInfo.Location = new System.Drawing.Point(860, 208);
            this.lbCarInfo.Name = "lbCarInfo";
            this.lbCarInfo.Size = new System.Drawing.Size(155, 24);
            this.lbCarInfo.TabIndex = 14;
            this.lbCarInfo.TabStop = true;
            this.lbCarInfo.Text = "Show Car Info";
            this.lbCarInfo.Visible = false;
            this.lbCarInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbCarInfo_LinkClicked);
            // 
            // cbwithdriver
            // 
            this.cbwithdriver.AutoSize = true;
            this.cbwithdriver.Location = new System.Drawing.Point(406, 169);
            this.cbwithdriver.Name = "cbwithdriver";
            this.cbwithdriver.Size = new System.Drawing.Size(121, 23);
            this.cbwithdriver.TabIndex = 13;
            this.cbwithdriver.Text = "withDriver";
            this.cbwithdriver.UseVisualStyleBackColor = true;
            this.cbwithdriver.CheckedChanged += new System.EventHandler(this.cbwithdriver_CheckedChanged);
            // 
            // cbxDriver
            // 
            this.cbxDriver.BackColor = System.Drawing.Color.Silver;
            this.cbxDriver.Enabled = false;
            this.cbxDriver.FormattingEnabled = true;
            this.cbxDriver.Location = new System.Drawing.Point(147, 167);
            this.cbxDriver.Name = "cbxDriver";
            this.cbxDriver.Size = new System.Drawing.Size(238, 27);
            this.cbxDriver.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(32, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Driver:";
            // 
            // numaricDayNum
            // 
            this.numaricDayNum.BackColor = System.Drawing.Color.Silver;
            this.numaricDayNum.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.numaricDayNum.Location = new System.Drawing.Point(559, 107);
            this.numaricDayNum.Name = "numaricDayNum";
            this.numaricDayNum.Size = new System.Drawing.Size(213, 32);
            this.numaricDayNum.TabIndex = 10;
            this.numaricDayNum.ValueChanged += new System.EventHandler(this.numaricDayNum_ValueChanged);
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(147, 107);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(238, 27);
            this.dateTimeStart.TabIndex = 9;
            this.dateTimeStart.ValueChanged += new System.EventHandler(this.dateTimeStart_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(416, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "DayNumber:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(22, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "StartFrom:";
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.BackColor = System.Drawing.Color.Red;
            this.lbHeader.LinkColor = System.Drawing.Color.Yellow;
            this.lbHeader.Location = new System.Drawing.Point(381, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(232, 19);
            this.lbHeader.TabIndex = 6;
            this.lbHeader.TabStop = true;
            this.lbHeader.Text = "This Car Not Available Now";
            this.lbHeader.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(860, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Check?";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Gray;
            this.btnCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.BackgroundImage")));
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(791, 26);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(63, 48);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // cbxModels
            // 
            this.cbxModels.BackColor = System.Drawing.Color.Silver;
            this.cbxModels.FormattingEnabled = true;
            this.cbxModels.Location = new System.Drawing.Point(534, 47);
            this.cbxModels.Name = "cbxModels";
            this.cbxModels.Size = new System.Drawing.Size(238, 27);
            this.cbxModels.TabIndex = 3;
            this.cbxModels.SelectedIndexChanged += new System.EventHandler(this.cbxModels_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(416, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "CarModel:";
            // 
            // cbxTypes
            // 
            this.cbxTypes.BackColor = System.Drawing.Color.Silver;
            this.cbxTypes.FormattingEnabled = true;
            this.cbxTypes.Location = new System.Drawing.Point(147, 44);
            this.cbxTypes.Name = "cbxTypes";
            this.cbxTypes.Size = new System.Drawing.Size(238, 27);
            this.cbxTypes.TabIndex = 1;
            this.cbxTypes.SelectedIndexChanged += new System.EventHandler(this.cbxTypes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(32, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "CarName:";
            // 
            // btnPayNow
            // 
            this.btnPayNow.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayNow.Location = new System.Drawing.Point(1061, 465);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(252, 78);
            this.btnPayNow.TabIndex = 27;
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = true;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbReturnMoney);
            this.panel2.Location = new System.Drawing.Point(1038, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 49);
            this.panel2.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(9, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 27);
            this.label12.TabIndex = 6;
            this.label12.Text = "Return money:";
            // 
            // lbReturnMoney
            // 
            this.lbReturnMoney.AutoSize = true;
            this.lbReturnMoney.BackColor = System.Drawing.Color.White;
            this.lbReturnMoney.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lbReturnMoney.Location = new System.Drawing.Point(192, 9);
            this.lbReturnMoney.Name = "lbReturnMoney";
            this.lbReturnMoney.Size = new System.Drawing.Size(83, 27);
            this.lbReturnMoney.TabIndex = 7;
            this.lbReturnMoney.Text = "00.0jd";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbTotalPrice);
            this.panel1.Location = new System.Drawing.Point(1038, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 49);
            this.panel1.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(9, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 27);
            this.label11.TabIndex = 6;
            this.label11.Text = "Total Price :";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.BackColor = System.Drawing.Color.White;
            this.lbTotalPrice.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lbTotalPrice.Location = new System.Drawing.Point(159, 9);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(83, 27);
            this.lbTotalPrice.TabIndex = 7;
            this.lbTotalPrice.Text = "00.0jd";
            // 
            // btnReturnPay
            // 
            this.btnReturnPay.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnPay.Location = new System.Drawing.Point(1061, 277);
            this.btnReturnPay.Name = "btnReturnPay";
            this.btnReturnPay.Size = new System.Drawing.Size(252, 78);
            this.btnReturnPay.TabIndex = 28;
            this.btnReturnPay.Text = "Return Pay";
            this.btnReturnPay.UseVisualStyleBackColor = true;
            this.btnReturnPay.Click += new System.EventHandler(this.btnReturnPay_Click);
            // 
            // EditingRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbRentID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReturnPay);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.gbEditing);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rdRentID);
            this.Controls.Add(this.rdCustomer);
            this.Name = "EditingRent";
            this.Size = new System.Drawing.Size(1360, 751);
            this.Load += new System.EventHandler(this.EditingRent_Load);
            this.panel3.ResumeLayout(false);
            this.gbRentID.ResumeLayout(false);
            this.gbRentID.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbEditing.ResumeLayout(false);
            this.gbEditing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricDayNum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private ctrRentingInfo ctrRentingInfo1;
        private System.Windows.Forms.RadioButton rdRentID;
        private System.Windows.Forms.RadioButton rdCustomer;
        private System.Windows.Forms.GroupBox gbRentID;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeacthRent;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEditing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox cbxModels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbHeader;
        private System.Windows.Forms.CheckBox cbwithdriver;
        private System.Windows.Forms.ComboBox cbxDriver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numaricDayNum;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbReturnMoney;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Button btnReturnPay;
        private System.Windows.Forms.LinkLabel lbCarInfo;
        private System.Windows.Forms.Button btnCalculate;
    }
}
