namespace Retaining_Car_Project.RentingsVehicles
{
    partial class ctrPayRenting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrPayRenting));
            this.gbRentID = new System.Windows.Forms.GroupBox();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeacthRent = new System.Windows.Forms.Button();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdCustomer = new System.Windows.Forms.RadioButton();
            this.rdRentID = new System.Windows.Forms.RadioButton();
            this.gbRentInfo = new System.Windows.Forms.GroupBox();
            this.ctrRentingInfo1 = new Retaining_Car_Project.RentingsVehicles.ctrRentingInfo();
            this.gbReturnInfo = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtAdditionalFees = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInitialMil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinalMileage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDistanseCoverd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnRentPay = new System.Windows.Forms.Button();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbexceedKmFees = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbReturnMoney = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbRentID.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.gbRentInfo.SuspendLayout();
            this.gbReturnInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRentID
            // 
            this.gbRentID.BackColor = System.Drawing.Color.White;
            this.gbRentID.Controls.Add(this.gbCustomer);
            this.gbRentID.Controls.Add(this.btnSeacthRent);
            this.gbRentID.Controls.Add(this.txtRentID);
            this.gbRentID.Controls.Add(this.label1);
            this.gbRentID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbRentID.Location = new System.Drawing.Point(15, 33);
            this.gbRentID.Name = "gbRentID";
            this.gbRentID.Size = new System.Drawing.Size(998, 131);
            this.gbRentID.TabIndex = 0;
            this.gbRentID.TabStop = false;
            this.gbRentID.Text = "Search By Rent";
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
            this.gbCustomer.Location = new System.Drawing.Point(3, 0);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(998, 131);
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
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
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
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
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
            // btnSeacthRent
            // 
            this.btnSeacthRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSeacthRent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeacthRent.BackgroundImage")));
            this.btnSeacthRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeacthRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeacthRent.Location = new System.Drawing.Point(819, 37);
            this.btnSeacthRent.Name = "btnSeacthRent";
            this.btnSeacthRent.Size = new System.Drawing.Size(98, 79);
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
            // rdCustomer
            // 
            this.rdCustomer.AutoSize = true;
            this.rdCustomer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdCustomer.Location = new System.Drawing.Point(834, 3);
            this.rdCustomer.Name = "rdCustomer";
            this.rdCustomer.Size = new System.Drawing.Size(179, 23);
            this.rdCustomer.TabIndex = 1;
            this.rdCustomer.TabStop = true;
            this.rdCustomer.Text = "ByCustomerName";
            this.rdCustomer.UseVisualStyleBackColor = true;
            this.rdCustomer.CheckedChanged += new System.EventHandler(this.rdCustomer_CheckedChanged);
            // 
            // rdRentID
            // 
            this.rdRentID.AutoSize = true;
            this.rdRentID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdRentID.Location = new System.Drawing.Point(665, 4);
            this.rdRentID.Name = "rdRentID";
            this.rdRentID.Size = new System.Drawing.Size(117, 23);
            this.rdRentID.TabIndex = 2;
            this.rdRentID.TabStop = true;
            this.rdRentID.Text = "By RentID";
            this.rdRentID.UseVisualStyleBackColor = true;
            this.rdRentID.CheckedChanged += new System.EventHandler(this.rdRentID_CheckedChanged);
            // 
            // gbRentInfo
            // 
            this.gbRentInfo.BackColor = System.Drawing.Color.White;
            this.gbRentInfo.Controls.Add(this.ctrRentingInfo1);
            this.gbRentInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbRentInfo.Location = new System.Drawing.Point(18, 184);
            this.gbRentInfo.Name = "gbRentInfo";
            this.gbRentInfo.Size = new System.Drawing.Size(995, 469);
            this.gbRentInfo.TabIndex = 3;
            this.gbRentInfo.TabStop = false;
            this.gbRentInfo.Text = "Rent Info";
            // 
            // ctrRentingInfo1
            // 
            this.ctrRentingInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrRentingInfo1.Location = new System.Drawing.Point(0, 26);
            this.ctrRentingInfo1.Name = "ctrRentingInfo1";
            this.ctrRentingInfo1.Size = new System.Drawing.Size(995, 440);
            this.ctrRentingInfo1.TabIndex = 0;
            // 
            // gbReturnInfo
            // 
            this.gbReturnInfo.BackColor = System.Drawing.Color.White;
            this.gbReturnInfo.Controls.Add(this.linkLabel2);
            this.gbReturnInfo.Controls.Add(this.btnCalculate);
            this.gbReturnInfo.Controls.Add(this.txtAdditionalFees);
            this.gbReturnInfo.Controls.Add(this.label8);
            this.gbReturnInfo.Controls.Add(this.txtNot);
            this.gbReturnInfo.Controls.Add(this.label7);
            this.gbReturnInfo.Controls.Add(this.dateReturnDate);
            this.gbReturnInfo.Controls.Add(this.label6);
            this.gbReturnInfo.Controls.Add(this.txtInitialMil);
            this.gbReturnInfo.Controls.Add(this.label5);
            this.gbReturnInfo.Controls.Add(this.txtFinalMileage);
            this.gbReturnInfo.Controls.Add(this.label4);
            this.gbReturnInfo.Enabled = false;
            this.gbReturnInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gbReturnInfo.Location = new System.Drawing.Point(18, 669);
            this.gbReturnInfo.Name = "gbReturnInfo";
            this.gbReturnInfo.Size = new System.Drawing.Size(995, 272);
            this.gbReturnInfo.TabIndex = 4;
            this.gbReturnInfo.TabStop = false;
            this.gbReturnInfo.Text = "Return Information";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(459, 223);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 43);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtAdditionalFees
            // 
            this.txtAdditionalFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAdditionalFees.Location = new System.Drawing.Point(221, 179);
            this.txtAdditionalFees.Mask = "0000.000";
            this.txtAdditionalFees.Name = "txtAdditionalFees";
            this.txtAdditionalFees.PromptChar = '0';
            this.txtAdditionalFees.Size = new System.Drawing.Size(252, 29);
            this.txtAdditionalFees.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12.5F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 30);
            this.label8.TabIndex = 8;
            this.label8.Text = "Additinal Fees:";
            // 
            // txtNot
            // 
            this.txtNot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNot.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtNot.Location = new System.Drawing.Point(715, 106);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(252, 99);
            this.txtNot.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12.5F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(519, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Not  Fees:";
            // 
            // dateReturnDate
            // 
            this.dateReturnDate.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dateReturnDate.Location = new System.Drawing.Point(221, 107);
            this.dateReturnDate.Name = "dateReturnDate";
            this.dateReturnDate.Size = new System.Drawing.Size(252, 29);
            this.dateReturnDate.TabIndex = 5;
            this.dateReturnDate.Value = new System.DateTime(2024, 8, 27, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12.5F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(22, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "Return Date:";
            // 
            // txtInitialMil
            // 
            this.txtInitialMil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtInitialMil.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtInitialMil.Location = new System.Drawing.Point(221, 46);
            this.txtInitialMil.Name = "txtInitialMil";
            this.txtInitialMil.ReadOnly = true;
            this.txtInitialMil.Size = new System.Drawing.Size(252, 32);
            this.txtInitialMil.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(22, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Initial Mileage:";
            // 
            // txtFinalMileage
            // 
            this.txtFinalMileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFinalMileage.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtFinalMileage.Location = new System.Drawing.Point(715, 46);
            this.txtFinalMileage.Name = "txtFinalMileage";
            this.txtFinalMileage.Size = new System.Drawing.Size(252, 32);
            this.txtFinalMileage.TabIndex = 1;
            this.txtFinalMileage.Validating += new System.ComponentModel.CancelEventHandler(this.txtFinalMileage_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(519, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Final Mileage:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(13, 954);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "DistanseCoverd(Km):\r\n";
            // 
            // lbDistanseCoverd
            // 
            this.lbDistanseCoverd.AutoSize = true;
            this.lbDistanseCoverd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbDistanseCoverd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbDistanseCoverd.Location = new System.Drawing.Point(289, 954);
            this.lbDistanseCoverd.Name = "lbDistanseCoverd";
            this.lbDistanseCoverd.Size = new System.Drawing.Size(28, 29);
            this.lbDistanseCoverd.TabIndex = 6;
            this.lbDistanseCoverd.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbTotalPrice);
            this.panel1.Location = new System.Drawing.Point(609, 947);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 49);
            this.panel1.TabIndex = 14;
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(14, 1093);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(208, 38);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "if the Customer only want ,\r\nto Pay for renting click here!";
            // 
            // btnRentPay
            // 
            this.btnRentPay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnRentPay.Location = new System.Drawing.Point(13, 1149);
            this.btnRentPay.Name = "btnRentPay";
            this.btnRentPay.Size = new System.Drawing.Size(204, 54);
            this.btnRentPay.TabIndex = 16;
            this.btnRentPay.Text = "Renting Pay";
            this.btnRentPay.UseVisualStyleBackColor = true;
            this.btnRentPay.Click += new System.EventHandler(this.btnReturnPay_Click);
            // 
            // btnPayNow
            // 
            this.btnPayNow.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnPayNow.Location = new System.Drawing.Point(380, 1082);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(267, 59);
            this.btnPayNow.TabIndex = 17;
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = true;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btnFinish.Location = new System.Drawing.Point(746, 1144);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(267, 59);
            this.btnFinish.TabIndex = 18;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(13, 1013);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "exceed40(Km)Fees:";
            // 
            // lbexceedKmFees
            // 
            this.lbexceedKmFees.AutoSize = true;
            this.lbexceedKmFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbexceedKmFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbexceedKmFees.Location = new System.Drawing.Point(289, 1013);
            this.lbexceedKmFees.Name = "lbexceedKmFees";
            this.lbexceedKmFees.Size = new System.Drawing.Size(28, 29);
            this.lbexceedKmFees.TabIndex = 20;
            this.lbexceedKmFees.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbReturnMoney);
            this.panel2.Location = new System.Drawing.Point(609, 1002);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 49);
            this.panel2.TabIndex = 15;
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
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(721, 244);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(246, 22);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Show History for this Rent";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrPayRenting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbexceedKmFees);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.btnRentPay);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbDistanseCoverd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbReturnInfo);
            this.Controls.Add(this.gbRentInfo);
            this.Controls.Add(this.rdRentID);
            this.Controls.Add(this.rdCustomer);
            this.Controls.Add(this.gbRentID);
            this.Name = "ctrPayRenting";
            this.Size = new System.Drawing.Size(1032, 1218);
            this.Load += new System.EventHandler(this.ctrPayRenting_Load);
            this.gbRentID.ResumeLayout(false);
            this.gbRentID.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbRentInfo.ResumeLayout(false);
            this.gbReturnInfo.ResumeLayout(false);
            this.gbReturnInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRentID;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.RadioButton rdCustomer;
        private System.Windows.Forms.RadioButton rdRentID;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeacthRent;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.GroupBox gbRentInfo;
        private ctrRentingInfo ctrRentingInfo1;
        private System.Windows.Forms.GroupBox gbReturnInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInitialMil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFinalMileage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtAdditionalFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateReturnDate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDistanseCoverd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnRentPay;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbexceedKmFees;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbReturnMoney;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
