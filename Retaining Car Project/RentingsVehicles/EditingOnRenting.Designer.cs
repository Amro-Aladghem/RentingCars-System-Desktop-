namespace Retaining_Car_Project.RentingsVehicles
{
    partial class EditingOnRenting
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
            this.editingRent1 = new Retaining_Car_Project.RentingsVehicles.EditingRent();
            this.SuspendLayout();
            // 
            // editingRent1
            // 
            this.editingRent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editingRent1.Location = new System.Drawing.Point(0, 1);
            this.editingRent1.Name = "editingRent1";
            this.editingRent1.Size = new System.Drawing.Size(1343, 751);
            this.editingRent1.TabIndex = 0;
            // 
            // EdingOnRenting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1340, 749);
            this.Controls.Add(this.editingRent1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EdingOnRenting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EdingOnRenting";
            this.ResumeLayout(false);

        }

        #endregion

        private EditingRent editingRent1;
    }
}