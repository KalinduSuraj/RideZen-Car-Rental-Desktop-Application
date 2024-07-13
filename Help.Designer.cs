namespace CW
{
    partial class Help
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
            this.labelTP = new System.Windows.Forms.Label();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.pictureBoxAdminAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTP
            // 
            this.labelTP.AutoSize = true;
            this.labelTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTP.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTP.Location = new System.Drawing.Point(263, 225);
            this.labelTP.Name = "labelTP";
            this.labelTP.Size = new System.Drawing.Size(267, 28);
            this.labelTP.TabIndex = 4;
            this.labelTP.Text = "T.P.       : 077 XX XX XXX";
            this.labelTP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAdminName
            // 
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAdminName.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminName.Location = new System.Drawing.Point(263, 185);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(248, 28);
            this.labelAdminName.TabIndex = 3;
            this.labelAdminName.Text = "Admin  : Kalindu Suraj";
            this.labelAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxAdminAvatar
            // 
            this.pictureBoxAdminAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxAdminAvatar.Image = global::CW.Properties.Resources.help_desk__1_;
            this.pictureBoxAdminAvatar.Location = new System.Drawing.Point(121, 154);
            this.pictureBoxAdminAvatar.Name = "pictureBoxAdminAvatar";
            this.pictureBoxAdminAvatar.Size = new System.Drawing.Size(123, 137);
            this.pictureBoxAdminAvatar.TabIndex = 2;
            this.pictureBoxAdminAvatar.TabStop = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.labelTP);
            this.Controls.Add(this.labelAdminName);
            this.Controls.Add(this.pictureBoxAdminAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdminAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTP;
        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.PictureBox pictureBoxAdminAvatar;
    }
}