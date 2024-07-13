namespace CW
{
    partial class CounterLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterLoginForm));
            this.errorProviderUserID = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCounterLogin = new System.Windows.Forms.Panel();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.btnCounterLogin = new System.Windows.Forms.Button();
            this.btnUserIDTextBox = new System.Windows.Forms.Button();
            this.btnPasswordTextBox = new System.Windows.Forms.Button();
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserID)).BeginInit();
            this.panelCounterLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProviderUserID
            // 
            this.errorProviderUserID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderUserID.ContainerControl = this;
            resources.ApplyResources(this.errorProviderUserID, "errorProviderUserID");
            // 
            // panelCounterLogin
            // 
            resources.ApplyResources(this.panelCounterLogin, "panelCounterLogin");
            this.panelCounterLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelCounterLogin.BackgroundImage = global::CW.Properties.Resources.BackGround;
            this.panelCounterLogin.Controls.Add(this.btnAdminLogin);
            this.panelCounterLogin.Controls.Add(this.btnExit);
            this.panelCounterLogin.Controls.Add(this.labelPassword);
            this.panelCounterLogin.Controls.Add(this.labelUserId);
            this.panelCounterLogin.Controls.Add(this.textBoxPassword);
            this.panelCounterLogin.Controls.Add(this.textBoxUserID);
            this.panelCounterLogin.Controls.Add(this.labelLogin);
            this.panelCounterLogin.Controls.Add(this.btnCounterLogin);
            this.panelCounterLogin.Controls.Add(this.btnUserIDTextBox);
            this.panelCounterLogin.Controls.Add(this.btnPasswordTextBox);
            this.errorProviderPassword.SetError(this.panelCounterLogin, resources.GetString("panelCounterLogin.Error"));
            this.errorProviderUserID.SetError(this.panelCounterLogin, resources.GetString("panelCounterLogin.Error1"));
            this.errorProviderUserID.SetIconAlignment(this.panelCounterLogin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panelCounterLogin.IconAlignment"))));
            this.errorProviderPassword.SetIconAlignment(this.panelCounterLogin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panelCounterLogin.IconAlignment1"))));
            this.errorProviderPassword.SetIconPadding(this.panelCounterLogin, ((int)(resources.GetObject("panelCounterLogin.IconPadding"))));
            this.errorProviderUserID.SetIconPadding(this.panelCounterLogin, ((int)(resources.GetObject("panelCounterLogin.IconPadding1"))));
            this.panelCounterLogin.Name = "panelCounterLogin";
            // 
            // btnAdminLogin
            // 
            resources.ApplyResources(this.btnAdminLogin, "btnAdminLogin");
            this.errorProviderUserID.SetError(this.btnAdminLogin, resources.GetString("btnAdminLogin.Error"));
            this.errorProviderPassword.SetError(this.btnAdminLogin, resources.GetString("btnAdminLogin.Error1"));
            this.btnAdminLogin.FlatAppearance.BorderSize = 0;
            this.btnAdminLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdminLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdminLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.errorProviderUserID.SetIconAlignment(this.btnAdminLogin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAdminLogin.IconAlignment"))));
            this.errorProviderPassword.SetIconAlignment(this.btnAdminLogin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAdminLogin.IconAlignment1"))));
            this.errorProviderUserID.SetIconPadding(this.btnAdminLogin, ((int)(resources.GetObject("btnAdminLogin.IconPadding"))));
            this.errorProviderPassword.SetIconPadding(this.btnAdminLogin, ((int)(resources.GetObject("btnAdminLogin.IconPadding1"))));
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.errorProviderUserID.SetError(this.btnExit, resources.GetString("btnExit.Error"));
            this.errorProviderPassword.SetError(this.btnExit, resources.GetString("btnExit.Error1"));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.errorProviderUserID.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment"))));
            this.errorProviderPassword.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment1"))));
            this.errorProviderUserID.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding"))));
            this.errorProviderPassword.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding1"))));
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelPassword
            // 
            resources.ApplyResources(this.labelPassword, "labelPassword");
            this.errorProviderUserID.SetError(this.labelPassword, resources.GetString("labelPassword.Error"));
            this.errorProviderPassword.SetError(this.labelPassword, resources.GetString("labelPassword.Error1"));
            this.errorProviderUserID.SetIconAlignment(this.labelPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelPassword.IconAlignment"))));
            this.errorProviderPassword.SetIconAlignment(this.labelPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelPassword.IconAlignment1"))));
            this.errorProviderUserID.SetIconPadding(this.labelPassword, ((int)(resources.GetObject("labelPassword.IconPadding"))));
            this.errorProviderPassword.SetIconPadding(this.labelPassword, ((int)(resources.GetObject("labelPassword.IconPadding1"))));
            this.labelPassword.Name = "labelPassword";
            // 
            // labelUserId
            // 
            resources.ApplyResources(this.labelUserId, "labelUserId");
            this.errorProviderUserID.SetError(this.labelUserId, resources.GetString("labelUserId.Error"));
            this.errorProviderPassword.SetError(this.labelUserId, resources.GetString("labelUserId.Error1"));
            this.errorProviderUserID.SetIconAlignment(this.labelUserId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelUserId.IconAlignment"))));
            this.errorProviderPassword.SetIconAlignment(this.labelUserId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelUserId.IconAlignment1"))));
            this.errorProviderUserID.SetIconPadding(this.labelUserId, ((int)(resources.GetObject("labelUserId.IconPadding"))));
            this.errorProviderPassword.SetIconPadding(this.labelUserId, ((int)(resources.GetObject("labelUserId.IconPadding1"))));
            this.labelUserId.Name = "labelUserId";
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorProviderUserID.SetError(this.textBoxPassword, resources.GetString("textBoxPassword.Error"));
            this.errorProviderPassword.SetError(this.textBoxPassword, resources.GetString("textBoxPassword.Error1"));
            this.errorProviderPassword.SetIconAlignment(this.textBoxPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBoxPassword.IconAlignment"))));
            this.errorProviderUserID.SetIconAlignment(this.textBoxPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBoxPassword.IconAlignment1"))));
            this.errorProviderPassword.SetIconPadding(this.textBoxPassword, ((int)(resources.GetObject("textBoxPassword.IconPadding"))));
            this.errorProviderUserID.SetIconPadding(this.textBoxPassword, ((int)(resources.GetObject("textBoxPassword.IconPadding1"))));
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // textBoxUserID
            // 
            resources.ApplyResources(this.textBoxUserID, "textBoxUserID");
            this.textBoxUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorProviderUserID.SetError(this.textBoxUserID, resources.GetString("textBoxUserID.Error"));
            this.errorProviderPassword.SetError(this.textBoxUserID, resources.GetString("textBoxUserID.Error1"));
            this.errorProviderPassword.SetIconAlignment(this.textBoxUserID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBoxUserID.IconAlignment"))));
            this.errorProviderUserID.SetIconAlignment(this.textBoxUserID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBoxUserID.IconAlignment1"))));
            this.errorProviderPassword.SetIconPadding(this.textBoxUserID, ((int)(resources.GetObject("textBoxUserID.IconPadding"))));
            this.errorProviderUserID.SetIconPadding(this.textBoxUserID, ((int)(resources.GetObject("textBoxUserID.IconPadding1"))));
            this.textBoxUserID.Name = "textBoxUserID";
            // 
            // labelLogin
            // 
            resources.ApplyResources(this.labelLogin, "labelLogin");
            this.errorProviderUserID.SetError(this.labelLogin, resources.GetString("labelLogin.Error"));
            this.errorProviderPassword.SetError(this.labelLogin, resources.GetString("labelLogin.Error1"));
            this.errorProviderUserID.SetIconAlignment(this.labelLogin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelLogin.IconAlignment"))));
            this.errorProviderPassword.SetIconAlignment(this.labelLogin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("labelLogin.IconAlignment1"))));
            this.errorProviderUserID.SetIconPadding(this.labelLogin, ((int)(resources.GetObject("labelLogin.IconPadding"))));
            this.errorProviderPassword.SetIconPadding(this.labelLogin, ((int)(resources.GetObject("labelLogin.IconPadding1"))));
            this.labelLogin.Name = "labelLogin";
            // 
            // btnCounterLogin
            // 
            resources.ApplyResources(this.btnCounterLogin, "btnCounterLogin");
            this.btnCounterLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCounterLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorProviderUserID.SetError(this.btnCounterLogin, resources.GetString("btnCounterLogin.Error"));
            this.errorProviderPassword.SetError(this.btnCounterLogin, resources.GetString("btnCounterLogin.Error1"));
            this.btnCounterLogin.FlatAppearance.BorderSize = 0;
            this.errorProviderUserID.SetIconAlignment(this.btnCounterLogin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCounterLogin.IconAlignment"))));
            this.errorProviderPassword.SetIconAlignment(this.btnCounterLogin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCounterLogin.IconAlignment1"))));
            this.errorProviderUserID.SetIconPadding(this.btnCounterLogin, ((int)(resources.GetObject("btnCounterLogin.IconPadding"))));
            this.errorProviderPassword.SetIconPadding(this.btnCounterLogin, ((int)(resources.GetObject("btnCounterLogin.IconPadding1"))));
            this.btnCounterLogin.Name = "btnCounterLogin";
            this.btnCounterLogin.UseVisualStyleBackColor = false;
            this.btnCounterLogin.Click += new System.EventHandler(this.btnCounterLogin_Click);
            // 
            // btnUserIDTextBox
            // 
            resources.ApplyResources(this.btnUserIDTextBox, "btnUserIDTextBox");
            this.btnUserIDTextBox.BackColor = System.Drawing.Color.White;
            this.errorProviderUserID.SetError(this.btnUserIDTextBox, resources.GetString("btnUserIDTextBox.Error"));
            this.errorProviderPassword.SetError(this.btnUserIDTextBox, resources.GetString("btnUserIDTextBox.Error1"));
            this.btnUserIDTextBox.FlatAppearance.BorderSize = 0;
            this.btnUserIDTextBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUserIDTextBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.errorProviderUserID.SetIconAlignment(this.btnUserIDTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnUserIDTextBox.IconAlignment"))));
            this.errorProviderPassword.SetIconAlignment(this.btnUserIDTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnUserIDTextBox.IconAlignment1"))));
            this.errorProviderUserID.SetIconPadding(this.btnUserIDTextBox, ((int)(resources.GetObject("btnUserIDTextBox.IconPadding"))));
            this.errorProviderPassword.SetIconPadding(this.btnUserIDTextBox, ((int)(resources.GetObject("btnUserIDTextBox.IconPadding1"))));
            this.btnUserIDTextBox.Name = "btnUserIDTextBox";
            this.btnUserIDTextBox.UseVisualStyleBackColor = false;
            // 
            // btnPasswordTextBox
            // 
            resources.ApplyResources(this.btnPasswordTextBox, "btnPasswordTextBox");
            this.btnPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.errorProviderUserID.SetError(this.btnPasswordTextBox, resources.GetString("btnPasswordTextBox.Error"));
            this.errorProviderPassword.SetError(this.btnPasswordTextBox, resources.GetString("btnPasswordTextBox.Error1"));
            this.btnPasswordTextBox.FlatAppearance.BorderSize = 0;
            this.btnPasswordTextBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPasswordTextBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.errorProviderUserID.SetIconAlignment(this.btnPasswordTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnPasswordTextBox.IconAlignment"))));
            this.errorProviderPassword.SetIconAlignment(this.btnPasswordTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnPasswordTextBox.IconAlignment1"))));
            this.errorProviderUserID.SetIconPadding(this.btnPasswordTextBox, ((int)(resources.GetObject("btnPasswordTextBox.IconPadding"))));
            this.errorProviderPassword.SetIconPadding(this.btnPasswordTextBox, ((int)(resources.GetObject("btnPasswordTextBox.IconPadding1"))));
            this.btnPasswordTextBox.Name = "btnPasswordTextBox";
            this.btnPasswordTextBox.UseVisualStyleBackColor = false;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPassword.ContainerControl = this;
            resources.ApplyResources(this.errorProviderPassword, "errorProviderPassword");
            // 
            // CounterLoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCounterLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CounterLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserID)).EndInit();
            this.panelCounterLogin.ResumeLayout(false);
            this.panelCounterLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button btnCounterLogin;
        private System.Windows.Forms.Panel panelCounterLogin;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUserIDTextBox;
        private System.Windows.Forms.Button btnPasswordTextBox;
        private System.Windows.Forms.ErrorProvider errorProviderUserID;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
    }
}