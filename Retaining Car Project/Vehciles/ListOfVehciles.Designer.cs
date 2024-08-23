namespace Retaining_Car_Project.Vehciles
{
    partial class ListOfVehciles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfVehciles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxModels = new System.Windows.Forms.ComboBox();
            this.cbxTypes = new System.Windows.Forms.ComboBox();
            this.lbModel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vehicleInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVehicleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLastRentDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRentStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isAvaliableForRentingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.cbxModels);
            this.panel1.Controls.Add(this.cbxTypes);
            this.panel1.Controls.Add(this.lbModel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1446, 100);
            this.panel1.TabIndex = 0;
            // 
            // cbxModels
            // 
            this.cbxModels.FormattingEnabled = true;
            this.cbxModels.Location = new System.Drawing.Point(884, 54);
            this.cbxModels.Name = "cbxModels";
            this.cbxModels.Size = new System.Drawing.Size(244, 27);
            this.cbxModels.TabIndex = 8;
            this.cbxModels.Visible = false;
            this.cbxModels.SelectedIndexChanged += new System.EventHandler(this.cbxModels_SelectedIndexChanged);
            // 
            // cbxTypes
            // 
            this.cbxTypes.FormattingEnabled = true;
            this.cbxTypes.Items.AddRange(new object[] {
            "All"});
            this.cbxTypes.Location = new System.Drawing.Point(627, 52);
            this.cbxTypes.Name = "cbxTypes";
            this.cbxTypes.Size = new System.Drawing.Size(148, 27);
            this.cbxTypes.TabIndex = 7;
            this.cbxTypes.SelectedIndexChanged += new System.EventHandler(this.cbxTypes_SelectedIndexChanged);
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.ForeColor = System.Drawing.Color.White;
            this.lbModel.Location = new System.Drawing.Point(796, 52);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(94, 29);
            this.lbModel.TabIndex = 6;
            this.lbModel.Text = "Model:";
            this.lbModel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(551, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1251, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 70);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1357, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 70);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicles List:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1446, 546);
            this.dataGridView1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 657);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "#Records:";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbRecords.Location = new System.Drawing.Point(156, 659);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(28, 29);
            this.lbRecords.TabIndex = 3;
            this.lbRecords.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1262, 657);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(185, 53);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleInfoToolStripMenuItem,
            this.updateVehicleDetailsToolStripMenuItem,
            this.deleteVehicleToolStripMenuItem,
            this.changeLastRentDateToolStripMenuItem,
            this.changeRentStatusToolStripMenuItem,
            this.isAvaliableForRentingToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(278, 196);
            // 
            // vehicleInfoToolStripMenuItem
            // 
            this.vehicleInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vehicleInfoToolStripMenuItem.Image")));
            this.vehicleInfoToolStripMenuItem.Name = "vehicleInfoToolStripMenuItem";
            this.vehicleInfoToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.vehicleInfoToolStripMenuItem.Text = "Vehicle Info";
            this.vehicleInfoToolStripMenuItem.Click += new System.EventHandler(this.vehicleInfoToolStripMenuItem_Click);
            // 
            // updateVehicleDetailsToolStripMenuItem
            // 
            this.updateVehicleDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateVehicleDetailsToolStripMenuItem.Image")));
            this.updateVehicleDetailsToolStripMenuItem.Name = "updateVehicleDetailsToolStripMenuItem";
            this.updateVehicleDetailsToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.updateVehicleDetailsToolStripMenuItem.Text = "Update Vehicle Details";
            this.updateVehicleDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateVehicleDetailsToolStripMenuItem_Click);
            // 
            // deleteVehicleToolStripMenuItem
            // 
            this.deleteVehicleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteVehicleToolStripMenuItem.Image")));
            this.deleteVehicleToolStripMenuItem.Name = "deleteVehicleToolStripMenuItem";
            this.deleteVehicleToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.deleteVehicleToolStripMenuItem.Text = "Delete Vehicle";
            this.deleteVehicleToolStripMenuItem.Click += new System.EventHandler(this.deleteVehicleToolStripMenuItem_Click);
            // 
            // changeLastRentDateToolStripMenuItem
            // 
            this.changeLastRentDateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeLastRentDateToolStripMenuItem.Image")));
            this.changeLastRentDateToolStripMenuItem.Name = "changeLastRentDateToolStripMenuItem";
            this.changeLastRentDateToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.changeLastRentDateToolStripMenuItem.Text = "Change Last Rent Date";
            // 
            // changeRentStatusToolStripMenuItem
            // 
            this.changeRentStatusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeRentStatusToolStripMenuItem.Image")));
            this.changeRentStatusToolStripMenuItem.Name = "changeRentStatusToolStripMenuItem";
            this.changeRentStatusToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.changeRentStatusToolStripMenuItem.Text = "Change Rent Status";
            // 
            // isAvaliableForRentingToolStripMenuItem
            // 
            this.isAvaliableForRentingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("isAvaliableForRentingToolStripMenuItem.Image")));
            this.isAvaliableForRentingToolStripMenuItem.Name = "isAvaliableForRentingToolStripMenuItem";
            this.isAvaliableForRentingToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.isAvaliableForRentingToolStripMenuItem.Text = "Is Avaliable For Renting";
            this.isAvaliableForRentingToolStripMenuItem.Click += new System.EventHandler(this.isAvaliableForRentingToolStripMenuItem_Click);
            // 
            // ListOfVehciles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1448, 711);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListOfVehciles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfVehciles";
            this.Load += new System.EventHandler(this.ListOfVehciles_Load);
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbxModels;
        private System.Windows.Forms.ComboBox cbxTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vehicleInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateVehicleDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLastRentDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeRentStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isAvaliableForRentingToolStripMenuItem;
    }
}