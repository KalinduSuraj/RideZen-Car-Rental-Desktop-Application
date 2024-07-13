namespace CW
{
    partial class CreateBooking
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelCID = new System.Windows.Forms.Label();
            this.labelCTP = new System.Windows.Forms.Label();
            this.labelCarID = new System.Windows.Forms.Label();
            this.labelNoOfDays = new System.Windows.Forms.Label();
            this.labelBookingDate = new System.Windows.Forms.Label();
            this.dateTimePickerBookingStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBookingClose = new System.Windows.Forms.DateTimePicker();
            this.labelPayment = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelCreate_Booking = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxNIC = new System.Windows.Forms.TextBox();
            this.textBoxCTP = new System.Windows.Forms.TextBox();
            this.textBoxCarID = new System.Windows.Forms.TextBox();
            this.textBoxNoOfDays = new System.Windows.Forms.TextBox();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider9 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelBookingID = new System.Windows.Forms.Label();
            this.labelShowBookingID = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.Window;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(48, 485);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 30);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(235, 485);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.Leave += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.BackColor = System.Drawing.Color.Transparent;
            this.labelFName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(48, 106);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(85, 19);
            this.labelFName.TabIndex = 21;
            this.labelFName.Text = "First Name ";
            this.labelFName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCID
            // 
            this.labelCID.AutoSize = true;
            this.labelCID.BackColor = System.Drawing.Color.Transparent;
            this.labelCID.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCID.Location = new System.Drawing.Point(48, 190);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(121, 19);
            this.labelCID.TabIndex = 21;
            this.labelCID.Text = "Customer NIC     ";
            this.labelCID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCTP
            // 
            this.labelCTP.AutoSize = true;
            this.labelCTP.BackColor = System.Drawing.Color.Transparent;
            this.labelCTP.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCTP.Location = new System.Drawing.Point(48, 235);
            this.labelCTP.Name = "labelCTP";
            this.labelCTP.Size = new System.Drawing.Size(122, 19);
            this.labelCTP.TabIndex = 21;
            this.labelCTP.Text = "Customer TP       ";
            this.labelCTP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCarID
            // 
            this.labelCarID.AutoSize = true;
            this.labelCarID.BackColor = System.Drawing.Color.Transparent;
            this.labelCarID.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarID.Location = new System.Drawing.Point(48, 278);
            this.labelCarID.Name = "labelCarID";
            this.labelCarID.Size = new System.Drawing.Size(126, 19);
            this.labelCarID.TabIndex = 21;
            this.labelCarID.Text = "Car ID                   ";
            this.labelCarID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNoOfDays
            // 
            this.labelNoOfDays.AutoSize = true;
            this.labelNoOfDays.BackColor = System.Drawing.Color.Transparent;
            this.labelNoOfDays.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOfDays.Location = new System.Drawing.Point(48, 319);
            this.labelNoOfDays.Name = "labelNoOfDays";
            this.labelNoOfDays.Size = new System.Drawing.Size(124, 19);
            this.labelNoOfDays.TabIndex = 21;
            this.labelNoOfDays.Text = "No Of Days          ";
            this.labelNoOfDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBookingDate
            // 
            this.labelBookingDate.AutoSize = true;
            this.labelBookingDate.BackColor = System.Drawing.Color.Transparent;
            this.labelBookingDate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookingDate.Location = new System.Drawing.Point(48, 356);
            this.labelBookingDate.Name = "labelBookingDate";
            this.labelBookingDate.Size = new System.Drawing.Size(60, 19);
            this.labelBookingDate.TabIndex = 21;
            this.labelBookingDate.Text = "From    ";
            this.labelBookingDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerBookingStart
            // 
            this.dateTimePickerBookingStart.Location = new System.Drawing.Point(48, 378);
            this.dateTimePickerBookingStart.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBookingStart.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBookingStart.Name = "dateTimePickerBookingStart";
            this.dateTimePickerBookingStart.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerBookingStart.TabIndex = 6;
            this.dateTimePickerBookingStart.Value = new System.DateTime(2024, 6, 11, 0, 0, 0, 0);
            // 
            // dateTimePickerBookingClose
            // 
            this.dateTimePickerBookingClose.Location = new System.Drawing.Point(231, 378);
            this.dateTimePickerBookingClose.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBookingClose.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBookingClose.Name = "dateTimePickerBookingClose";
            this.dateTimePickerBookingClose.Size = new System.Drawing.Size(185, 20);
            this.dateTimePickerBookingClose.TabIndex = 7;
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.BackColor = System.Drawing.Color.Transparent;
            this.labelPayment.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayment.Location = new System.Drawing.Point(48, 442);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(79, 19);
            this.labelPayment.TabIndex = 21;
            this.labelPayment.Text = "Payment   ";
            this.labelPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.BackColor = System.Drawing.Color.Transparent;
            this.labelLName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(48, 144);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(83, 19);
            this.labelLName.TabIndex = 21;
            this.labelLName.Text = "Last Name ";
            this.labelLName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCreate_Booking
            // 
            this.labelCreate_Booking.AutoSize = true;
            this.labelCreate_Booking.BackColor = System.Drawing.Color.Transparent;
            this.labelCreate_Booking.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreate_Booking.Location = new System.Drawing.Point(140, 9);
            this.labelCreate_Booking.Name = "labelCreate_Booking";
            this.labelCreate_Booking.Size = new System.Drawing.Size(159, 26);
            this.labelCreate_Booking.TabIndex = 21;
            this.labelCreate_Booking.Text = "Create Booking";
            this.labelCreate_Booking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFName.Location = new System.Drawing.Point(174, 105);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(242, 22);
            this.textBoxFName.TabIndex = 0;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLName.Location = new System.Drawing.Point(174, 143);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(242, 22);
            this.textBoxLName.TabIndex = 1;
            // 
            // textBoxNIC
            // 
            this.textBoxNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNIC.Location = new System.Drawing.Point(174, 189);
            this.textBoxNIC.Name = "textBoxNIC";
            this.textBoxNIC.Size = new System.Drawing.Size(242, 22);
            this.textBoxNIC.TabIndex = 2;
            // 
            // textBoxCTP
            // 
            this.textBoxCTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCTP.Location = new System.Drawing.Point(174, 232);
            this.textBoxCTP.Name = "textBoxCTP";
            this.textBoxCTP.Size = new System.Drawing.Size(242, 22);
            this.textBoxCTP.TabIndex = 3;
            // 
            // textBoxCarID
            // 
            this.textBoxCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarID.Location = new System.Drawing.Point(174, 277);
            this.textBoxCarID.Name = "textBoxCarID";
            this.textBoxCarID.Size = new System.Drawing.Size(242, 22);
            this.textBoxCarID.TabIndex = 4;
            // 
            // textBoxNoOfDays
            // 
            this.textBoxNoOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoOfDays.Location = new System.Drawing.Point(174, 318);
            this.textBoxNoOfDays.Name = "textBoxNoOfDays";
            this.textBoxNoOfDays.Size = new System.Drawing.Size(242, 22);
            this.textBoxNoOfDays.TabIndex = 5;
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPayment.Location = new System.Drawing.Point(174, 442);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(242, 22);
            this.textBoxPayment.TabIndex = 8;
            this.textBoxPayment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPayment_KeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // errorProvider9
            // 
            this.errorProvider9.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBookingID
            // 
            this.labelBookingID.AutoSize = true;
            this.labelBookingID.BackColor = System.Drawing.Color.Transparent;
            this.labelBookingID.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookingID.Location = new System.Drawing.Point(121, 51);
            this.labelBookingID.Name = "labelBookingID";
            this.labelBookingID.Size = new System.Drawing.Size(91, 19);
            this.labelBookingID.TabIndex = 21;
            this.labelBookingID.Text = "Booking ID :";
            this.labelBookingID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelShowBookingID
            // 
            this.labelShowBookingID.AutoSize = true;
            this.labelShowBookingID.BackColor = System.Drawing.Color.Transparent;
            this.labelShowBookingID.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowBookingID.Location = new System.Drawing.Point(210, 51);
            this.labelShowBookingID.Name = "labelShowBookingID";
            this.labelShowBookingID.Size = new System.Drawing.Size(23, 19);
            this.labelShowBookingID.TabIndex = 21;
            this.labelShowBookingID.Text = "ID";
            this.labelShowBookingID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(48, 406);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(126, 30);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate Payment ";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(465, 550);
            this.Controls.Add(this.textBoxPayment);
            this.Controls.Add(this.textBoxNoOfDays);
            this.Controls.Add(this.textBoxCarID);
            this.Controls.Add(this.textBoxCTP);
            this.Controls.Add(this.textBoxNIC);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.dateTimePickerBookingClose);
            this.Controls.Add(this.dateTimePickerBookingStart);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBookingDate);
            this.Controls.Add(this.labelNoOfDays);
            this.Controls.Add(this.labelCarID);
            this.Controls.Add(this.labelCTP);
            this.Controls.Add(this.labelCID);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelCreate_Booking);
            this.Controls.Add(this.labelShowBookingID);
            this.Controls.Add(this.labelBookingID);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateBooking";
            this.Load += new System.EventHandler(this.CreateBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelCID;
        private System.Windows.Forms.Label labelCTP;
        private System.Windows.Forms.Label labelCarID;
        private System.Windows.Forms.Label labelNoOfDays;
        private System.Windows.Forms.Label labelBookingDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookingStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookingClose;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelCreate_Booking;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxNIC;
        private System.Windows.Forms.TextBox textBoxCTP;
        private System.Windows.Forms.TextBox textBoxCarID;
        private System.Windows.Forms.TextBox textBoxNoOfDays;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ErrorProvider errorProvider9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBookingID;
        private System.Windows.Forms.Label labelShowBookingID;
        private System.Windows.Forms.Button btnCalculate;
    }
}