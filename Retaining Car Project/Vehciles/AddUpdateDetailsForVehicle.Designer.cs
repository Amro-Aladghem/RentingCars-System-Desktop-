namespace Retaining_Car_Project.Vehciles
{
    partial class AddUpdateDetailsForVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateDetailsForVehicle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExsits = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHead = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrAdding_UpdatingVehicleDetails1 = new Retaining_Car_Project.Vehciles.ctrAdding_UpdatingVehicleDetails();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnExsits);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbHead);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 112);
            this.panel1.TabIndex = 0;
            // 
            // btnExsits
            // 
            this.btnExsits.BackColor = System.Drawing.Color.White;
            this.btnExsits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExsits.BackgroundImage")));
            this.btnExsits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExsits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExsits.Location = new System.Drawing.Point(1186, 0);
            this.btnExsits.Name = "btnExsits";
            this.btnExsits.Size = new System.Drawing.Size(122, 112);
            this.btnExsits.TabIndex = 2;
            this.btnExsits.UseVisualStyleBackColor = false;
            this.btnExsits.Click += new System.EventHandler(this.btnExsits_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(588, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHead.ForeColor = System.Drawing.Color.White;
            this.lbHead.Location = new System.Drawing.Point(3, 33);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(432, 48);
            this.lbHead.TabIndex = 0;
            this.lbHead.Text = "Add/Update Details:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1106, 798);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 52);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrAdding_UpdatingVehicleDetails1
            // 
            this.ctrAdding_UpdatingVehicleDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ctrAdding_UpdatingVehicleDetails1.Location = new System.Drawing.Point(46, 133);
            this.ctrAdding_UpdatingVehicleDetails1.Name = "ctrAdding_UpdatingVehicleDetails1";
            this.ctrAdding_UpdatingVehicleDetails1.Size = new System.Drawing.Size(1223, 659);
            this.ctrAdding_UpdatingVehicleDetails1.TabIndex = 1;
            this.ctrAdding_UpdatingVehicleDetails1.OnSearchClick += new System.EventHandler<Retaining_Car_Project.Vehciles.ctrAdding_UpdatingVehicleDetails.GetTypeOfMood>(this.ctrAdding_UpdatingVehicleDetails1_OnSearchClick);
            // 
            // AddUpdateDetailsForVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1312, 851);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrAdding_UpdatingVehicleDetails1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUpdateDetailsForVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateDetailsForVehicle";
            this.Load += new System.EventHandler(this.AddUpdateDetailsForVehicle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHead;
        private ctrAdding_UpdatingVehicleDetails ctrAdding_UpdatingVehicleDetails1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExsits;
    }
}