namespace Retaining_Car_Project.SystemCustomer
{
    partial class UpdateAddCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAddCustomers));
            this.ctrUpdateAddCustomer1 = new Retaining_Car_Project.SystemCustomer.ctrUpdateAddCustomer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHead = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrUpdateAddCustomer1
            // 
            this.ctrUpdateAddCustomer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrUpdateAddCustomer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrUpdateAddCustomer1.Location = new System.Drawing.Point(25, 116);
            this.ctrUpdateAddCustomer1.Name = "ctrUpdateAddCustomer1";
            this.ctrUpdateAddCustomer1.Size = new System.Drawing.Size(1170, 507);
            this.ctrUpdateAddCustomer1.TabIndex = 0;
            this.ctrUpdateAddCustomer1.OnSaveClick += new System.EventHandler(this.ctrUpdateAddCustomer1_OnSaveClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbHead);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 100);
            this.panel1.TabIndex = 1;
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lbHead.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbHead.Location = new System.Drawing.Point(3, 27);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(449, 48);
            this.lbHead.TabIndex = 0;
            this.lbHead.Text = "AddUpdate Customer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(567, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1047, 630);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 44);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UpdateAddCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1216, 686);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrUpdateAddCustomer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateAddCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAddCustomers";
            this.Load += new System.EventHandler(this.UpdateAddCustomers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrUpdateAddCustomer ctrUpdateAddCustomer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.Button btnClose;
    }
}