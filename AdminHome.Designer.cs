namespace CW
{
    partial class AdminHomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeForm));
            this.panelDashboardTop = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnViewLogin = new System.Windows.Forms.Button();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelShowDate = new System.Windows.Forms.Label();
            this.labelShowTime = new System.Windows.Forms.Label();
            this.labelRideZen = new System.Windows.Forms.Label();
            this.btnCLose = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.panelAdminHome = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.panelDashboardTop.SuspendLayout();
            this.panelAdminHome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashboardTop
            // 
            this.panelDashboardTop.BackColor = System.Drawing.Color.Transparent;
            this.panelDashboardTop.Controls.Add(this.btnLogOut);
            this.panelDashboardTop.Controls.Add(this.btnViewLogin);
            this.panelDashboardTop.Controls.Add(this.btnCars);
            this.panelDashboardTop.Controls.Add(this.btnHome);
            this.panelDashboardTop.Controls.Add(this.labelDate);
            this.panelDashboardTop.Controls.Add(this.labelTime);
            this.panelDashboardTop.Controls.Add(this.labelShowDate);
            this.panelDashboardTop.Controls.Add(this.labelShowTime);
            this.panelDashboardTop.Location = new System.Drawing.Point(0, 30);
            this.panelDashboardTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDashboardTop.Name = "panelDashboardTop";
            this.panelDashboardTop.Size = new System.Drawing.Size(800, 113);
            this.panelDashboardTop.TabIndex = 16;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = global::CW.Properties.Resources.logout;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(691, 73);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 30);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnViewLogin
            // 
            this.btnViewLogin.FlatAppearance.BorderSize = 0;
            this.btnViewLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnViewLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLogin.Location = new System.Drawing.Point(464, 73);
            this.btnViewLogin.Name = "btnViewLogin";
            this.btnViewLogin.Size = new System.Drawing.Size(200, 30);
            this.btnViewLogin.TabIndex = 2;
            this.btnViewLogin.Text = "View Logins";
            this.btnViewLogin.UseVisualStyleBackColor = true;
            this.btnViewLogin.Click += new System.EventHandler(this.btnViewLogin_Click);
            // 
            // btnCars
            // 
            this.btnCars.FlatAppearance.BorderSize = 0;
            this.btnCars.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCars.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCars.Location = new System.Drawing.Point(264, 73);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(200, 30);
            this.btnCars.TabIndex = 1;
            this.btnCars.Text = "Cars";
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(64, 73);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 30);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.labelDate.Location = new System.Drawing.Point(20, 17);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(65, 31);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Date   :";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold);
            this.labelTime.Location = new System.Drawing.Point(622, 19);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(68, 31);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Time   :";
            // 
            // labelShowDate
            // 
            this.labelShowDate.AutoSize = true;
            this.labelShowDate.BackColor = System.Drawing.Color.Transparent;
            this.labelShowDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.labelShowDate.Location = new System.Drawing.Point(80, 23);
            this.labelShowDate.Name = "labelShowDate";
            this.labelShowDate.Size = new System.Drawing.Size(120, 21);
            this.labelShowDate.TabIndex = 4;
            this.labelShowDate.Text = "DD/MM/YYYY";
            // 
            // labelShowTime
            // 
            this.labelShowTime.AutoSize = true;
            this.labelShowTime.BackColor = System.Drawing.Color.Transparent;
            this.labelShowTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.labelShowTime.Location = new System.Drawing.Point(686, 24);
            this.labelShowTime.Name = "labelShowTime";
            this.labelShowTime.Size = new System.Drawing.Size(50, 21);
            this.labelShowTime.TabIndex = 4;
            this.labelShowTime.Text = "00:00";
            // 
            // labelRideZen
            // 
            this.labelRideZen.AutoSize = true;
            this.labelRideZen.BackColor = System.Drawing.Color.Transparent;
            this.labelRideZen.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRideZen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelRideZen.Location = new System.Drawing.Point(100, 170);
            this.labelRideZen.Name = "labelRideZen";
            this.labelRideZen.Size = new System.Drawing.Size(627, 81);
            this.labelRideZen.TabIndex = 6;
            this.labelRideZen.Text = "Ride Zen Car Rental";
            this.labelRideZen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Transparent;
            this.btnCLose.FlatAppearance.BorderSize = 0;
            this.btnCLose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCLose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.Location = new System.Drawing.Point(770, 0);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(30, 30);
            this.btnCLose.TabIndex = 14;
            this.btnCLose.Text = "X";
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.Image = global::CW.Properties.Resources.About_Us;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAboutUs.Location = new System.Drawing.Point(712, 580);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(88, 20);
            this.btnAboutUs.TabIndex = 0;
            this.btnAboutUs.Text = "About Us     ";
            this.btnAboutUs.UseMnemonic = false;
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // panelAdminHome
            // 
            this.panelAdminHome.BackColor = System.Drawing.Color.Transparent;
            this.panelAdminHome.Controls.Add(this.labelRideZen);
            this.panelAdminHome.Location = new System.Drawing.Point(0, 136);
            this.panelAdminHome.Name = "panelAdminHome";
            this.panelAdminHome.Size = new System.Drawing.Size(800, 440);
            this.panelAdminHome.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnCLose);
            this.panel1.Controls.Add(this.labelAdmin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 18;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(3, 3);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(64, 22);
            this.labelAdmin.TabIndex = 4;
            this.labelAdmin.Text = "Admin";
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::CW.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAdminHome);
            this.Controls.Add(this.panelDashboardTop);
            this.Controls.Add(this.btnAboutUs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.panelDashboardTop.ResumeLayout(false);
            this.panelDashboardTop.PerformLayout();
            this.panelAdminHome.ResumeLayout(false);
            this.panelAdminHome.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDashboardTop;
        private System.Windows.Forms.Label labelRideZen;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelShowDate;
        private System.Windows.Forms.Label labelShowTime;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Panel panelAdminHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnViewLogin;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAdmin;
    }
}