namespace CW
{
    partial class DashBoard
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
            this.labelTodayBooking = new System.Windows.Forms.Label();
            this.dataGridViewTodayBookings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodayBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTodayBooking
            // 
            this.labelTodayBooking.AutoSize = true;
            this.labelTodayBooking.BackColor = System.Drawing.Color.Transparent;
            this.labelTodayBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTodayBooking.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTodayBooking.Location = new System.Drawing.Point(27, 9);
            this.labelTodayBooking.Name = "labelTodayBooking";
            this.labelTodayBooking.Size = new System.Drawing.Size(154, 23);
            this.labelTodayBooking.TabIndex = 7;
            this.labelTodayBooking.Text = "Today Bookings";
            // 
            // dataGridViewTodayBookings
            // 
            this.dataGridViewTodayBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTodayBookings.Location = new System.Drawing.Point(31, 85);
            this.dataGridViewTodayBookings.Name = "dataGridViewTodayBookings";
            this.dataGridViewTodayBookings.Size = new System.Drawing.Size(537, 284);
            this.dataGridViewTodayBookings.TabIndex = 13;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.dataGridViewTodayBookings);
            this.Controls.Add(this.labelTodayBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodayBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTodayBooking;
        private System.Windows.Forms.DataGridView dataGridViewTodayBookings;
    }
}