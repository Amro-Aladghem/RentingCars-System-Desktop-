namespace Retaining_Car_Project.RentingsVehicles
{
    partial class PayRenting
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
            this.ctrPayRenting1 = new Retaining_Car_Project.RentingsVehicles.ctrPayRenting();
            this.SuspendLayout();
            // 
            // ctrPayRenting1
            // 
            this.ctrPayRenting1.AutoSize = true;
            this.ctrPayRenting1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ctrPayRenting1.Location = new System.Drawing.Point(0, -6);
            this.ctrPayRenting1.Name = "ctrPayRenting1";
            this.ctrPayRenting1.Size = new System.Drawing.Size(1459, 923);
            this.ctrPayRenting1.TabIndex = 0;
            // 
            // PayRenting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1460, 915);
            this.Controls.Add(this.ctrPayRenting1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PayRenting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayRenting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrPayRenting ctrPayRenting1;
    }
}