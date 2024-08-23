namespace Retaining_Car_Project.Vehciles
{
    partial class ctrVehicleInfoWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrVehicleInfoWithFilter));
            this.gbSearching = new System.Windows.Forms.GroupBox();
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbSearching.SuspendLayout();
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
            this.gbSearching.Location = new System.Drawing.Point(15, 3);
            this.gbSearching.Name = "gbSearching";
            this.gbSearching.Size = new System.Drawing.Size(1203, 100);
            this.gbSearching.TabIndex = 1;
            this.gbSearching.TabStop = false;
            this.gbSearching.Text = "Searching Vehicle";
            // 
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Location = new System.Drawing.Point(619, 50);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(267, 32);
            this.cbxModel.TabIndex = 3;
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
            // 
            // ctrVehicleInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "ctrVehicleInfoWithFilter";
            this.Size = new System.Drawing.Size(1247, 670);
            this.Load += new System.EventHandler(this.ctrVehicleInfoWithFilter_Load_1);
            this.gbSearching.ResumeLayout(false);
            this.gbSearching.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrVehicleInfo ctrVehicleInfo1;
        private System.Windows.Forms.GroupBox gbSearching;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label1;
    }
}
