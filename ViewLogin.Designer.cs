namespace CW
{
    partial class ViewLogin
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
            this.panelViewLogin = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.DataGridViewLogins = new System.Windows.Forms.DataGridView();
            this.btnCreateLogin = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxSearchUserID = new System.Windows.Forms.TextBox();
            this.labelUserID1 = new System.Windows.Forms.Label();
            this.errorProviderUserID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelViewLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLogins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panelViewLogin
            // 
            this.panelViewLogin.Controls.Add(this.btnDelete);
            this.panelViewLogin.Controls.Add(this.btnClear);
            this.panelViewLogin.Controls.Add(this.btnUpdate);
            this.panelViewLogin.Controls.Add(this.textBoxPassword);
            this.panelViewLogin.Controls.Add(this.textBoxUserID);
            this.panelViewLogin.Controls.Add(this.textBoxLName);
            this.panelViewLogin.Controls.Add(this.textBoxFName);
            this.panelViewLogin.Controls.Add(this.labelPassword);
            this.panelViewLogin.Controls.Add(this.labelUserID);
            this.panelViewLogin.Controls.Add(this.labelLName);
            this.panelViewLogin.Controls.Add(this.labelFName);
            this.panelViewLogin.Controls.Add(this.DataGridViewLogins);
            this.panelViewLogin.Controls.Add(this.btnCreateLogin);
            this.panelViewLogin.Location = new System.Drawing.Point(12, 56);
            this.panelViewLogin.Name = "panelViewLogin";
            this.panelViewLogin.Size = new System.Drawing.Size(776, 376);
            this.panelViewLogin.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(231, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(269, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 25);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(131, 291);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxPassword.Location = new System.Drawing.Point(138, 222);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(180, 32);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxUserID.Location = new System.Drawing.Point(138, 59);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(180, 32);
            this.textBoxUserID.TabIndex = 0;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxLName.Location = new System.Drawing.Point(138, 167);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(180, 32);
            this.textBoxLName.TabIndex = 2;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxFName.Location = new System.Drawing.Point(138, 114);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(180, 32);
            this.textBoxFName.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(30, 231);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(95, 23);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(30, 68);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(75, 23);
            this.labelUserID.TabIndex = 4;
            this.labelUserID.Text = "User ID";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(30, 176);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(102, 23);
            this.labelLName.TabIndex = 5;
            this.labelLName.Text = "Last Name";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(30, 123);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(105, 23);
            this.labelFName.TabIndex = 6;
            this.labelFName.Text = "First Name";
            // 
            // DataGridViewLogins
            // 
            this.DataGridViewLogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLogins.Location = new System.Drawing.Point(335, 59);
            this.DataGridViewLogins.Name = "DataGridViewLogins";
            this.DataGridViewLogins.Size = new System.Drawing.Size(405, 282);
            this.DataGridViewLogins.TabIndex = 1;
            this.DataGridViewLogins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLogins_CellContentClick);
            // 
            // btnCreateLogin
            // 
            this.btnCreateLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCreateLogin.Location = new System.Drawing.Point(34, 291);
            this.btnCreateLogin.Name = "btnCreateLogin";
            this.btnCreateLogin.Size = new System.Drawing.Size(91, 31);
            this.btnCreateLogin.TabIndex = 4;
            this.btnCreateLogin.Text = "Create";
            this.btnCreateLogin.UseVisualStyleBackColor = true;
            this.btnCreateLogin.Click += new System.EventHandler(this.btnCreateLogin_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(350, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxSearchUserID
            // 
            this.textBoxSearchUserID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSearchUserID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxSearchUserID.Location = new System.Drawing.Point(153, 19);
            this.textBoxSearchUserID.Name = "textBoxSearchUserID";
            this.textBoxSearchUserID.Size = new System.Drawing.Size(180, 32);
            this.textBoxSearchUserID.TabIndex = 0;
            this.textBoxSearchUserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchUserID_KeyDown);
            // 
            // labelUserID1
            // 
            this.labelUserID1.AutoSize = true;
            this.labelUserID1.BackColor = System.Drawing.Color.Transparent;
            this.labelUserID1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID1.Location = new System.Drawing.Point(45, 28);
            this.labelUserID1.Name = "labelUserID1";
            this.labelUserID1.Size = new System.Drawing.Size(75, 23);
            this.labelUserID1.TabIndex = 12;
            this.labelUserID1.Text = "User ID";
            // 
            // errorProviderUserID
            // 
            this.errorProviderUserID.ContainerControl = this;
            // 
            // errorProviderFName
            // 
            this.errorProviderFName.ContainerControl = this;
            // 
            // errorProviderLName
            // 
            this.errorProviderLName.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // ViewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CW.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.textBoxSearchUserID);
            this.Controls.Add(this.panelViewLogin);
            this.Controls.Add(this.labelUserID1);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewLogin";
            this.Text = "CreateLogin";
            this.Load += new System.EventHandler(this.ViewLogin_Load);
            this.panelViewLogin.ResumeLayout(false);
            this.panelViewLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLogins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelViewLogin;
        private System.Windows.Forms.Button btnCreateLogin;
        private System.Windows.Forms.DataGridView DataGridViewLogins;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxSearchUserID;
        private System.Windows.Forms.Label labelUserID1;
        private System.Windows.Forms.ErrorProvider errorProviderUserID;
        private System.Windows.Forms.ErrorProvider errorProviderFName;
        private System.Windows.Forms.ErrorProvider errorProviderLName;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.Button btnClear;
    }
}