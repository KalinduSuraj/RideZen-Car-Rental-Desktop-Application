namespace CW
{
    partial class FormCars
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
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.pictureBoxCarImage = new System.Windows.Forms.PictureBox();
            this.labelRentalRate = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelCarID = new System.Windows.Forms.Label();
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.textBoxRentalRate = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxCarID = new System.Windows.Forms.TextBox();
            this.labelCar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(13, 35);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.Size = new System.Drawing.Size(575, 223);
            this.dataGridViewCars.TabIndex = 13;
            this.dataGridViewCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCars_CellContentClick);
            // 
            // pictureBoxCarImage
            // 
            this.pictureBoxCarImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCarImage.BackgroundImage = global::CW.Properties.Resources.LOGO__2_;
            this.pictureBoxCarImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxCarImage.Location = new System.Drawing.Point(317, 266);
            this.pictureBoxCarImage.Name = "pictureBoxCarImage";
            this.pictureBoxCarImage.Size = new System.Drawing.Size(233, 112);
            this.pictureBoxCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCarImage.TabIndex = 24;
            this.pictureBoxCarImage.TabStop = false;
            // 
            // labelRentalRate
            // 
            this.labelRentalRate.AutoSize = true;
            this.labelRentalRate.BackColor = System.Drawing.Color.Transparent;
            this.labelRentalRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentalRate.Location = new System.Drawing.Point(14, 396);
            this.labelRentalRate.Name = "labelRentalRate";
            this.labelRentalRate.Size = new System.Drawing.Size(106, 20);
            this.labelRentalRate.TabIndex = 14;
            this.labelRentalRate.Text = "Rental Rate";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.BackColor = System.Drawing.Color.Transparent;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(14, 366);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(72, 20);
            this.labelContact.TabIndex = 15;
            this.labelContact.Text = "Contact";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.BackColor = System.Drawing.Color.Transparent;
            this.labelOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwner.Location = new System.Drawing.Point(14, 332);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(60, 20);
            this.labelOwner.TabIndex = 16;
            this.labelOwner.Text = "Owner";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.Color.Transparent;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(14, 300);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(57, 20);
            this.labelModel.TabIndex = 17;
            this.labelModel.Text = "Model";
            // 
            // labelCarID
            // 
            this.labelCarID.AutoSize = true;
            this.labelCarID.BackColor = System.Drawing.Color.Transparent;
            this.labelCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarID.Location = new System.Drawing.Point(14, 269);
            this.labelCarID.Name = "labelCarID";
            this.labelCarID.Size = new System.Drawing.Size(61, 20);
            this.labelCarID.TabIndex = 18;
            this.labelCarID.Text = "Car ID";
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSelectCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCar.Location = new System.Drawing.Point(317, 388);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(233, 30);
            this.btnSelectCar.TabIndex = 5;
            this.btnSelectCar.Text = "Select This Car";
            this.btnSelectCar.UseVisualStyleBackColor = false;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // textBoxRentalRate
            // 
            this.textBoxRentalRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRentalRate.Location = new System.Drawing.Point(122, 392);
            this.textBoxRentalRate.Name = "textBoxRentalRate";
            this.textBoxRentalRate.ReadOnly = true;
            this.textBoxRentalRate.Size = new System.Drawing.Size(189, 26);
            this.textBoxRentalRate.TabIndex = 4;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(122, 360);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.ReadOnly = true;
            this.textBoxContact.Size = new System.Drawing.Size(189, 26);
            this.textBoxContact.TabIndex = 3;
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOwner.Location = new System.Drawing.Point(122, 328);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.ReadOnly = true;
            this.textBoxOwner.Size = new System.Drawing.Size(189, 26);
            this.textBoxOwner.TabIndex = 2;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(122, 296);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new System.Drawing.Size(189, 26);
            this.textBoxModel.TabIndex = 1;
            // 
            // textBoxCarID
            // 
            this.textBoxCarID.CausesValidation = false;
            this.textBoxCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarID.Location = new System.Drawing.Point(122, 265);
            this.textBoxCarID.Name = "textBoxCarID";
            this.textBoxCarID.ReadOnly = true;
            this.textBoxCarID.Size = new System.Drawing.Size(189, 26);
            this.textBoxCarID.TabIndex = 0;
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.BackColor = System.Drawing.Color.Transparent;
            this.labelCar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.labelCar.Location = new System.Drawing.Point(14, 9);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(44, 23);
            this.labelCar.TabIndex = 9;
            this.labelCar.Text = "Cars";
            // 
            // FormCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnSelectCar);
            this.Controls.Add(this.pictureBoxCarImage);
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
            this.Controls.Add(this.dataGridViewCars);
            this.Controls.Add(this.labelCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCars";
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.PictureBox pictureBoxCarImage;
        private System.Windows.Forms.Label labelRentalRate;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelCarID;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.TextBox textBoxRentalRate;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxCarID;
        private System.Windows.Forms.Label labelCar;
    }
}