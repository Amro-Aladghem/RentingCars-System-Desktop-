namespace Retaining_Car_Project.Vehciles
{
    partial class ctrAdding_UpdatingVehicleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrAdding_UpdatingVehicleDetails));
            this.gbSearching = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarTypeID = new System.Windows.Forms.TextBox();
            this.lbCarTypeID = new System.Windows.Forms.Label();
            this.txtVehiclID = new System.Windows.Forms.TextBox();
            this.lbVehicleID = new System.Windows.Forms.Label();
            this.lbFirstTime = new System.Windows.Forms.LinkLabel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtProducedYear = new System.Windows.Forms.TextBox();
            this.gbSearching.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearching
            // 
            this.gbSearching.BackColor = System.Drawing.Color.DarkGray;
            this.gbSearching.Controls.Add(this.btnSearch);
            this.gbSearching.Controls.Add(this.cbxModel);
            this.gbSearching.Controls.Add(this.label2);
            this.gbSearching.Controls.Add(this.cbxType);
            this.gbSearching.Controls.Add(this.label1);
            this.gbSearching.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearching.Location = new System.Drawing.Point(23, 14);
            this.gbSearching.Name = "gbSearching";
            this.gbSearching.Size = new System.Drawing.Size(1174, 100);
            this.gbSearching.TabIndex = 0;
            this.gbSearching.TabStop = false;
            this.gbSearching.Text = "Searching Vehicle";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(943, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 69);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Location = new System.Drawing.Point(619, 50);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(267, 32);
            this.cbxModel.TabIndex = 3;
            this.cbxModel.SelectedIndexChanged += new System.EventHandler(this.cbxModel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(232, 45);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(267, 32);
            this.cbxType.TabIndex = 1;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txtProducedYear);
            this.groupBox1.Controls.Add(this.cbxRentStatus);
            this.groupBox1.Controls.Add(this.cbxColor);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.txtIssue);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCarNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtmillageCounter);
            this.groupBox1.Controls.Add(this.label7);
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
            this.groupBox1.Location = new System.Drawing.Point(23, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 447);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Details";
            // 
            // cbxRentStatus
            // 
            this.cbxRentStatus.FormattingEnabled = true;
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
            this.txtCarNumber.Size = new System.Drawing.Size(283, 34);
            this.txtCarNumber.TabIndex = 15;
            this.txtCarNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarNumber_KeyPress);
            this.txtCarNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtCarNumber_Validating);
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
            this.txtmillageCounter.Size = new System.Drawing.Size(283, 34);
            this.txtmillageCounter.TabIndex = 13;
            this.txtmillageCounter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmillageCounter_KeyPress);
            this.txtmillageCounter.Validating += new System.ComponentModel.CancelEventHandler(this.txtmillageCounter_Validating);
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
            this.txtCarTypeID.Size = new System.Drawing.Size(212, 34);
            this.txtCarTypeID.TabIndex = 3;
            this.txtCarTypeID.Text = "[???]";
            this.txtCarTypeID.TextChanged += new System.EventHandler(this.txtCarTypeID_TextChanged);
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
            this.txtVehiclID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // lbFirstTime
            // 
            this.lbFirstTime.AutoSize = true;
            this.lbFirstTime.BackColor = System.Drawing.Color.Yellow;
            this.lbFirstTime.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lbFirstTime.LinkColor = System.Drawing.Color.Red;
            this.lbFirstTime.Location = new System.Drawing.Point(311, 117);
            this.lbFirstTime.Name = "lbFirstTime";
            this.lbFirstTime.Size = new System.Drawing.Size(694, 19);
            this.lbFirstTime.TabIndex = 19;
            this.lbFirstTime.TabStop = true;
            this.lbFirstTime.Text = "This is First Time For this Vehicle , You must Add Detail After that You can Upda" +
    "ting";
            this.lbFirstTime.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(543, 597);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(161, 53);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtProducedYear
            // 
            this.txtProducedYear.Location = new System.Drawing.Point(794, 68);
            this.txtProducedYear.MaxLength = 4;
            this.txtProducedYear.Name = "txtProducedYear";
            this.txtProducedYear.Size = new System.Drawing.Size(283, 34);
            this.txtProducedYear.TabIndex = 21;
            // 
            // ctrAdding_UpdatingVehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbFirstTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSearching);
            this.Name = "ctrAdding_UpdatingVehicleDetails";
            this.Size = new System.Drawing.Size(1223, 659);
            this.Load += new System.EventHandler(this.ctrAdding_UpdatingVehicleDetails_Load);
            this.gbSearching.ResumeLayout(false);
            this.gbSearching.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearching;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbVehicleID;
        private System.Windows.Forms.TextBox txtVehiclID;
        private System.Windows.Forms.TextBox txtModelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarTypeID;
        private System.Windows.Forms.Label lbCarTypeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmillageCounter;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lbFirstTime;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.ComboBox cbxRentStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtProducedYear;
    }
}
