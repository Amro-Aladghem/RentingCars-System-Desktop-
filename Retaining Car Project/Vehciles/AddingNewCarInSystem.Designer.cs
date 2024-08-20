namespace Retaining_Car_Project.Vehciles
{
    partial class AddingNewCarInSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingNewCarInSystem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdOldType = new System.Windows.Forms.RadioButton();
            this.rdNewType = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNewType = new System.Windows.Forms.GroupBox();
            this.txtModelName_New = new System.Windows.Forms.TextBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSystemType = new System.Windows.Forms.GroupBox();
            this.txtModelName_Old = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbNewType.SuspendLayout();
            this.gbSystemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.rdOldType);
            this.panel1.Controls.Add(this.rdNewType);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 105);
            this.panel1.TabIndex = 0;
            // 
            // rdOldType
            // 
            this.rdOldType.AutoSize = true;
            this.rdOldType.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.rdOldType.ForeColor = System.Drawing.Color.White;
            this.rdOldType.Location = new System.Drawing.Point(786, 48);
            this.rdOldType.Name = "rdOldType";
            this.rdOldType.Size = new System.Drawing.Size(177, 31);
            this.rdOldType.TabIndex = 3;
            this.rdOldType.TabStop = true;
            this.rdOldType.Text = "System Type";
            this.rdOldType.UseVisualStyleBackColor = true;
            this.rdOldType.CheckedChanged += new System.EventHandler(this.rdOldType_CheckedChanged);
            // 
            // rdNewType
            // 
            this.rdNewType.AutoSize = true;
            this.rdNewType.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.rdNewType.ForeColor = System.Drawing.Color.White;
            this.rdNewType.Location = new System.Drawing.Point(619, 45);
            this.rdNewType.Name = "rdNewType";
            this.rdNewType.Size = new System.Drawing.Size(146, 31);
            this.rdNewType.TabIndex = 2;
            this.rdNewType.TabStop = true;
            this.rdNewType.Text = "New Type";
            this.rdNewType.UseVisualStyleBackColor = true;
            this.rdNewType.CheckedChanged += new System.EventHandler(this.rdNewType_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Car:";
            // 
            // gbNewType
            // 
            this.gbNewType.BackColor = System.Drawing.Color.DarkGray;
            this.gbNewType.Controls.Add(this.txtModelName_New);
            this.gbNewType.Controls.Add(this.txtTypeName);
            this.gbNewType.Controls.Add(this.label3);
            this.gbNewType.Controls.Add(this.label2);
            this.gbNewType.Enabled = false;
            this.gbNewType.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gbNewType.Location = new System.Drawing.Point(12, 118);
            this.gbNewType.Name = "gbNewType";
            this.gbNewType.Size = new System.Drawing.Size(974, 155);
            this.gbNewType.TabIndex = 1;
            this.gbNewType.TabStop = false;
            this.gbNewType.Text = "New Type";
            // 
            // txtModelName_New
            // 
            this.txtModelName_New.Location = new System.Drawing.Point(655, 72);
            this.txtModelName_New.Name = "txtModelName_New";
            this.txtModelName_New.Size = new System.Drawing.Size(281, 34);
            this.txtModelName_New.TabIndex = 3;
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(165, 72);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(281, 34);
            this.txtTypeName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Model Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type Name:";
            // 
            // gbSystemType
            // 
            this.gbSystemType.BackColor = System.Drawing.Color.DarkGray;
            this.gbSystemType.Controls.Add(this.txtModelName_Old);
            this.gbSystemType.Controls.Add(this.label5);
            this.gbSystemType.Controls.Add(this.cbxTypes);
            this.gbSystemType.Controls.Add(this.label4);
            this.gbSystemType.Enabled = false;
            this.gbSystemType.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gbSystemType.Location = new System.Drawing.Point(12, 308);
            this.gbSystemType.Name = "gbSystemType";
            this.gbSystemType.Size = new System.Drawing.Size(974, 155);
            this.gbSystemType.TabIndex = 2;
            this.gbSystemType.TabStop = false;
            this.gbSystemType.Text = "System Type";
            // 
            // txtModelName_Old
            // 
            this.txtModelName_Old.Location = new System.Drawing.Point(655, 69);
            this.txtModelName_Old.Name = "txtModelName_Old";
            this.txtModelName_Old.Size = new System.Drawing.Size(281, 34);
            this.txtModelName_Old.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "ModelName:";
            // 
            // cbxTypes
            // 
            this.cbxTypes.FormattingEnabled = true;
            this.cbxTypes.Location = new System.Drawing.Point(165, 76);
            this.cbxTypes.Name = "cbxTypes";
            this.cbxTypes.Size = new System.Drawing.Size(281, 35);
            this.cbxTypes.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type Name:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(422, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddingNewCarInSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(998, 539);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSystemType);
            this.Controls.Add(this.gbNewType);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddingNewCarInSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddingNewCarInSystem";
            this.Load += new System.EventHandler(this.AddingNewCarInSystem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbNewType.ResumeLayout(false);
            this.gbNewType.PerformLayout();
            this.gbSystemType.ResumeLayout(false);
            this.gbSystemType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdOldType;
        private System.Windows.Forms.RadioButton rdNewType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbNewType;
        private System.Windows.Forms.TextBox txtModelName_New;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSystemType;
        private System.Windows.Forms.TextBox txtModelName_Old;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
    }
}