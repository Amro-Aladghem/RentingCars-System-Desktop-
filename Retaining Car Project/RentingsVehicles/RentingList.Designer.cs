namespace Retaining_Car_Project.RentingsVehicles
{
    partial class RentingList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentingList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxActive = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewRenting = new System.Windows.Forms.Button();
            this.btnPayRenting = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.payRentingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRentingInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInScheduleTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelRentingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTheCarAndDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeActiveStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.cbxActive);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.cbxFilter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnNewRenting);
            this.panel1.Controls.Add(this.btnPayRenting);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1709, 102);
            this.panel1.TabIndex = 0;
            // 
            // cbxActive
            // 
            this.cbxActive.FormattingEnabled = true;
            this.cbxActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbxActive.Location = new System.Drawing.Point(1444, 37);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(127, 27);
            this.cbxActive.TabIndex = 11;
            this.cbxActive.Visible = false;
            this.cbxActive.SelectedIndexChanged += new System.EventHandler(this.cbxActive_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(1444, 37);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(215, 27);
            this.txtFilter.TabIndex = 10;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbxFilter
            // 
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Items.AddRange(new object[] {
            "None",
            "ScheduleID",
            "VehicleID",
            "CustomerID",
            "isActive",
            "isPaid"});
            this.cbxFilter.Location = new System.Drawing.Point(1258, 37);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(180, 27);
            this.cbxFilter.TabIndex = 9;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1120, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "FilterBy :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(564, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "New";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(451, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pay";
            // 
            // btnNewRenting
            // 
            this.btnNewRenting.BackColor = System.Drawing.Color.White;
            this.btnNewRenting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewRenting.BackgroundImage")));
            this.btnNewRenting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewRenting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRenting.Location = new System.Drawing.Point(549, 3);
            this.btnNewRenting.Name = "btnNewRenting";
            this.btnNewRenting.Size = new System.Drawing.Size(82, 71);
            this.btnNewRenting.TabIndex = 4;
            this.btnNewRenting.UseVisualStyleBackColor = false;
            this.btnNewRenting.Click += new System.EventHandler(this.btnNewRenting_Click);
            // 
            // btnPayRenting
            // 
            this.btnPayRenting.BackColor = System.Drawing.Color.White;
            this.btnPayRenting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayRenting.BackgroundImage")));
            this.btnPayRenting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPayRenting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayRenting.Location = new System.Drawing.Point(432, 3);
            this.btnPayRenting.Name = "btnPayRenting";
            this.btnPayRenting.Size = new System.Drawing.Size(82, 71);
            this.btnPayRenting.TabIndex = 3;
            this.btnPayRenting.UseVisualStyleBackColor = false;
            this.btnPayRenting.Click += new System.EventHandler(this.btnPayRenting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(783, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rentings List :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1706, 641);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payRentingToolStripMenuItem,
            this.showRentingInfoToolStripMenuItem,
            this.showInScheduleTableToolStripMenuItem,
            this.cancelRentingToolStripMenuItem,
            this.changeTheCarAndDriverToolStripMenuItem,
            this.changeActiveStatusToolStripMenuItem,
            this.vehicleInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(304, 228);
            // 
            // payRentingToolStripMenuItem
            // 
            this.payRentingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("payRentingToolStripMenuItem.Image")));
            this.payRentingToolStripMenuItem.Name = "payRentingToolStripMenuItem";
            this.payRentingToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.payRentingToolStripMenuItem.Text = "Pay Renting";
            this.payRentingToolStripMenuItem.Click += new System.EventHandler(this.payRentingToolStripMenuItem_Click);
            // 
            // showRentingInfoToolStripMenuItem
            // 
            this.showRentingInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showRentingInfoToolStripMenuItem.Image")));
            this.showRentingInfoToolStripMenuItem.Name = "showRentingInfoToolStripMenuItem";
            this.showRentingInfoToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.showRentingInfoToolStripMenuItem.Text = "Show Renting Info";
            this.showRentingInfoToolStripMenuItem.Click += new System.EventHandler(this.showRentingInfoToolStripMenuItem_Click);
            // 
            // showInScheduleTableToolStripMenuItem
            // 
            this.showInScheduleTableToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showInScheduleTableToolStripMenuItem.Image")));
            this.showInScheduleTableToolStripMenuItem.Name = "showInScheduleTableToolStripMenuItem";
            this.showInScheduleTableToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.showInScheduleTableToolStripMenuItem.Text = "Show in Schedule table";
            this.showInScheduleTableToolStripMenuItem.Click += new System.EventHandler(this.showInScheduleTableToolStripMenuItem_Click);
            // 
            // cancelRentingToolStripMenuItem
            // 
            this.cancelRentingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelRentingToolStripMenuItem.Image")));
            this.cancelRentingToolStripMenuItem.Name = "cancelRentingToolStripMenuItem";
            this.cancelRentingToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.cancelRentingToolStripMenuItem.Text = "Cancel Renting";
            this.cancelRentingToolStripMenuItem.Click += new System.EventHandler(this.cancelRentingToolStripMenuItem_Click);
            // 
            // changeTheCarAndDriverToolStripMenuItem
            // 
            this.changeTheCarAndDriverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeTheCarAndDriverToolStripMenuItem.Image")));
            this.changeTheCarAndDriverToolStripMenuItem.Name = "changeTheCarAndDriverToolStripMenuItem";
            this.changeTheCarAndDriverToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.changeTheCarAndDriverToolStripMenuItem.Text = "Change the Car And Driver";
            this.changeTheCarAndDriverToolStripMenuItem.Click += new System.EventHandler(this.changeTheCarAndDriverToolStripMenuItem_Click);
            // 
            // changeActiveStatusToolStripMenuItem
            // 
            this.changeActiveStatusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeActiveStatusToolStripMenuItem.Image")));
            this.changeActiveStatusToolStripMenuItem.Name = "changeActiveStatusToolStripMenuItem";
            this.changeActiveStatusToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.changeActiveStatusToolStripMenuItem.Text = "Customer Info";
            this.changeActiveStatusToolStripMenuItem.Click += new System.EventHandler(this.changeActiveStatusToolStripMenuItem_Click);
            // 
            // vehicleInfoToolStripMenuItem
            // 
            this.vehicleInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vehicleInfoToolStripMenuItem.Image")));
            this.vehicleInfoToolStripMenuItem.Name = "vehicleInfoToolStripMenuItem";
            this.vehicleInfoToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.vehicleInfoToolStripMenuItem.Text = "Vehicle Info";
            this.vehicleInfoToolStripMenuItem.Click += new System.EventHandler(this.vehicleInfoToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 749);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "#Records:";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(156, 749);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(33, 34);
            this.lbRecord.TabIndex = 3;
            this.lbRecord.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1525, 749);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 55);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RentingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1706, 808);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentingList";
            this.Load += new System.EventHandler(this.RentingList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewRenting;
        private System.Windows.Forms.Button btnPayRenting;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxActive;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem payRentingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRentingInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInScheduleTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelRentingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTheCarAndDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeActiveStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleInfoToolStripMenuItem;
    }
}