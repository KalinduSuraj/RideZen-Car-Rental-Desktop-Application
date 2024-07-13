namespace CW
{
    partial class AdminDefultHome
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
            this.labelRideZen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRideZen
            // 
            this.labelRideZen.AutoSize = true;
            this.labelRideZen.BackColor = System.Drawing.Color.Transparent;
            this.labelRideZen.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRideZen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelRideZen.Location = new System.Drawing.Point(116, 222);
            this.labelRideZen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRideZen.Name = "labelRideZen";
            this.labelRideZen.Size = new System.Drawing.Size(627, 81);
            this.labelRideZen.TabIndex = 7;
            this.labelRideZen.Text = "Ride Zen Car Rental";
            this.labelRideZen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminDefultHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::CW.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(1067, 542);
            this.Controls.Add(this.labelRideZen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminDefultHome";
            this.Text = "AdminDefultHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRideZen;
    }
}