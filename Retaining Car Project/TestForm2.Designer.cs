namespace Retaining_Car_Project
{
    partial class TestForm2
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
            this.ctrVehicleInfoWithFilter1 = new Retaining_Car_Project.Vehciles.ctrVehicleInfoWithFilter();
            this.SuspendLayout();
            // 
            // ctrVehicleInfoWithFilter1
            // 
            this.ctrVehicleInfoWithFilter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrVehicleInfoWithFilter1.Location = new System.Drawing.Point(33, 18);
            this.ctrVehicleInfoWithFilter1.Name = "ctrVehicleInfoWithFilter1";
            this.ctrVehicleInfoWithFilter1.Size = new System.Drawing.Size(1231, 618);
            this.ctrVehicleInfoWithFilter1.TabIndex = 0;
            // 
            // TestForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 648);
            this.Controls.Add(this.ctrVehicleInfoWithFilter1);
            this.Name = "TestForm2";
            this.Text = "TestForm2";
            this.ResumeLayout(false);

        }

        #endregion

        private Vehciles.ctrVehicleInfoWithFilter ctrVehicleInfoWithFilter1;
    }
}