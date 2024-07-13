namespace CW
{
    partial class AdminCars
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
            this.labelCars = new System.Windows.Forms.Label();
            this.labelCarID = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelRentalRate = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxCarID = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.textBoxRentalRate = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.pictureBoxCarImage = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errorProviderCarID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOwner = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRentalRate = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxSearchCarID = new System.Windows.Forms.TextBox();
            this.labelSearchCarID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCarID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRentalRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCars
            // 
            this.labelCars.AutoSize = true;
            this.labelCars.BackColor = System.Drawing.Color.Transparent;
            this.labelCars.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCars.Location = new System.Drawing.Point(315, 4);
            this.labelCars.Name = "labelCars";
            this.labelCars.Size = new System.Drawing.Size(82, 41);
            this.labelCars.TabIndex = 0;
            this.labelCars.Text = "Cars";
            // 
            // labelCarID
            // 
            this.labelCarID.AutoSize = true;
            this.labelCarID.BackColor = System.Drawing.Color.Transparent;
            this.labelCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarID.Location = new System.Drawing.Point(51, 61);
            this.labelCarID.Name = "labelCarID";
            this.labelCarID.Size = new System.Drawing.Size(61, 20);
            this.labelCarID.TabIndex = 0;
            this.labelCarID.Text = "Car ID";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.Color.Transparent;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(51, 92);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(57, 20);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "Model";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.BackColor = System.Drawing.Color.Transparent;
            this.labelOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwner.Location = new System.Drawing.Point(51, 124);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(60, 20);
            this.labelOwner.TabIndex = 0;
            this.labelOwner.Text = "Owner";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.BackColor = System.Drawing.Color.Transparent;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(51, 158);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(72, 20);
            this.labelContact.TabIndex = 0;
            this.labelContact.Text = "Contact";
            // 
            // labelRentalRate
            // 
            this.labelRentalRate.AutoSize = true;
            this.labelRentalRate.BackColor = System.Drawing.Color.Transparent;
            this.labelRentalRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentalRate.Location = new System.Drawing.Point(51, 188);
            this.labelRentalRate.Name = "labelRentalRate";
            this.labelRentalRate.Size = new System.Drawing.Size(106, 20);
            this.labelRentalRate.TabIndex = 0;
            this.labelRentalRate.Text = "Rental Rate";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(159, 88);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(194, 26);
            this.textBoxModel.TabIndex = 1;
            // 
            // textBoxCarID
            // 
            this.textBoxCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarID.Location = new System.Drawing.Point(159, 57);
            this.textBoxCarID.Name = "textBoxCarID";
            this.textBoxCarID.Size = new System.Drawing.Size(194, 26);
            this.textBoxCarID.TabIndex = 0;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(159, 152);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(194, 26);
            this.textBoxContact.TabIndex = 3;
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOwner.Location = new System.Drawing.Point(159, 120);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(194, 26);
            this.textBoxOwner.TabIndex = 2;
            // 
            // textBoxRentalRate
            // 
            this.textBoxRentalRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRentalRate.Location = new System.Drawing.Point(159, 184);
            this.textBoxRentalRate.Name = "textBoxRentalRate";
            this.textBoxRentalRate.Size = new System.Drawing.Size(194, 26);
            this.textBoxRentalRate.TabIndex = 4;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(370, 178);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(223, 30);
            this.btnUploadImage.TabIndex = 5;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // pictureBoxCarImage
            // 
            this.pictureBoxCarImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCarImage.BackgroundImage = global::CW.Properties.Resources.LOGO__2_;
            this.pictureBoxCarImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxCarImage.Location = new System.Drawing.Point(370, 61);
            this.pictureBoxCarImage.Name = "pictureBoxCarImage";
            this.pictureBoxCarImage.Size = new System.Drawing.Size(222, 112);
            this.pictureBoxCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCarImage.TabIndex = 3;
            this.pictureBoxCarImage.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(614, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // errorProviderCarID
            // 
            this.errorProviderCarID.ContainerControl = this;
            // 
            // errorProviderModel
            // 
            this.errorProviderModel.ContainerControl = this;
            // 
            // errorProviderOwner
            // 
            this.errorProviderOwner.ContainerControl = this;
            // 
            // errorProviderContact
            // 
            this.errorProviderContact.ContainerControl = this;
            // 
            // errorProviderRentalRate
            // 
            this.errorProviderRentalRate.ContainerControl = this;
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.AllowUserToAddRows = false;
            this.dataGridViewCars.AllowUserToDeleteRows = false;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(55, 281);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.Size = new System.Drawing.Size(660, 147);
            this.dataGridViewCars.TabIndex = 5;
            this.dataGridViewCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCars_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(614, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(614, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(304, 252);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxSearchCarID
            // 
            this.textBoxSearchCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchCarID.Location = new System.Drawing.Point(109, 252);
            this.textBoxSearchCarID.Name = "textBoxSearchCarID";
            this.textBoxSearchCarID.Size = new System.Drawing.Size(194, 26);
            this.textBoxSearchCarID.TabIndex = 9;
            // 
            // labelSearchCarID
            // 
            this.labelSearchCarID.AutoSize = true;
            this.labelSearchCarID.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchCarID.Location = new System.Drawing.Point(51, 255);
            this.labelSearchCarID.Name = "labelSearchCarID";
            this.labelSearchCarID.Size = new System.Drawing.Size(61, 20);
            this.labelSearchCarID.TabIndex = 8;
            this.labelSearchCarID.Text = "Car ID";
            // 
            // AdminCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::CW.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearchCarID);
            this.Controls.Add(this.labelSearchCarID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewCars);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pictureBoxCarImage);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.textBoxRentalRate);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxCarID);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelRentalRate);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelCarID);
            this.Controls.Add(this.labelCars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminCars";
            this.Text = "AdminCars";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCarID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRentalRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCars;
        private System.Windows.Forms.Label labelCarID;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelRentalRate;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxCarID;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.TextBox textBoxRentalRate;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox pictureBoxCarImage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProviderCarID;
        private System.Windows.Forms.ErrorProvider errorProviderModel;
        private System.Windows.Forms.ErrorProvider errorProviderOwner;
        private System.Windows.Forms.ErrorProvider errorProviderContact;
        private System.Windows.Forms.ErrorProvider errorProviderRentalRate;
        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxSearchCarID;
        private System.Windows.Forms.Label labelSearchCarID;
    }
}