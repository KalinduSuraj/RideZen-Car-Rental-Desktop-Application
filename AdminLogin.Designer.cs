namespace CW
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.panelCounterLogin = new System.Windows.Forms.Panel();
            this.btnCounterLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnPasswordTextBox = new System.Windows.Forms.Button();
            this.errorProviderAdminPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCounterLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdminPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCounterLogin
            // 
            this.panelCounterLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelCounterLogin.Controls.Add(this.btnCounterLogin);
            this.panelCounterLogin.Controls.Add(this.btnExit);
            this.panelCounterLogin.Controls.Add(this.labelPassword);
            this.panelCounterLogin.Controls.Add(this.textBoxPassword);
            this.panelCounterLogin.Controls.Add(this.labelLogin);
            this.panelCounterLogin.Controls.Add(this.btnAdminLogin);
            this.panelCounterLogin.Controls.Add(this.btnPasswordTextBox);
            this.panelCounterLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCounterLogin.Location = new System.Drawing.Point(0, 0);
            this.panelCounterLogin.Name = "panelCounterLogin";
            this.panelCounterLogin.Size = new System.Drawing.Size(384, 461);
            this.panelCounterLogin.TabIndex = 3;
            // 
            // btnCounterLogin
            // 
            this.btnCounterLogin.FlatAppearance.BorderSize = 0;
            this.btnCounterLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCounterLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCounterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCounterLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCounterLogin.Location = new System.Drawing.Point(150, 307);
            this.btnCounterLogin.Name = "btnCounterLogin";
            this.btnCounterLogin.Size = new System.Drawing.Size(85, 23);
            this.btnCounterLogin.TabIndex = 2;
            this.btnCounterLogin.Text = "Counter Login";
            this.btnCounterLogin.UseVisualStyleBackColor = true;
            this.btnCounterLogin.Click += new System.EventHandler(this.btnCounterLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(283, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.labelPassword.Location = new System.Drawing.Point(93, 182);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(86, 23);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(108, 212);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(160, 20);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(94, 112);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(141, 53);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Admin";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdminLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdminLogin.FlatAppearance.BorderSize = 0;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.Location = new System.Drawing.Point(97, 271);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(200, 33);
            this.btnAdminLogin.TabIndex = 1;
            this.btnAdminLogin.Text = "Log In";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnPasswordTextBox
            // 
            this.btnPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.btnPasswordTextBox.FlatAppearance.BorderSize = 0;
            this.btnPasswordTextBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPasswordTextBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPasswordTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordTextBox.Location = new System.Drawing.Point(97, 207);
            this.btnPasswordTextBox.Name = "btnPasswordTextBox";
            this.btnPasswordTextBox.Size = new System.Drawing.Size(200, 30);
            this.btnPasswordTextBox.TabIndex = 6;
            this.btnPasswordTextBox.UseVisualStyleBackColor = false;
            // 
            // errorProviderAdminPassword
            // 
            this.errorProviderAdminPassword.ContainerControl = this;
            this.errorProviderAdminPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderAdminPassword.Icon")));
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CW.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.panelCounterLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.panelCounterLogin.ResumeLayout(false);
            this.panelCounterLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdminPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCounterLogin;
        private System.Windows.Forms.Button btnCounterLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnPasswordTextBox;
        private System.Windows.Forms.ErrorProvider errorProviderAdminPassword;
    }
}