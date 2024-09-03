namespace Retaining_Car_Project.RentingsVehicles
{
    partial class AddNewRenting
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
            this.ctrAddNewRenting1 = new Retaining_Car_Project.RentingsVehicles.ctrAddNewRenting();
            this.SuspendLayout();
            // 
            // ctrAddNewRenting1
            // 
            this.ctrAddNewRenting1.BackColor = System.Drawing.Color.PaleGreen;
            this.ctrAddNewRenting1.Location = new System.Drawing.Point(-3, -2);
            this.ctrAddNewRenting1.Name = "ctrAddNewRenting1";
            this.ctrAddNewRenting1.Size = new System.Drawing.Size(1311, 914);
            this.ctrAddNewRenting1.TabIndex = 0;
            // 
            // AddNewRenting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1272, 899);
            this.Controls.Add(this.ctrAddNewRenting1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewRenting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewRenting";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrAddNewRenting ctrAddNewRenting1;
    }
}