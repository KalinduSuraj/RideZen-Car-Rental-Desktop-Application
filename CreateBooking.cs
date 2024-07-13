using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CW
{
    public partial class CreateBooking : Form
    {
        decimal RentalRate = 0;

        public CreateBooking()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        public void Selectcar(String CarID ,String Rental_Rate)
        {
            textBoxCarID.Text = CarID;
            RentalRate = Convert.ToDecimal(Rental_Rate);
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxFName.Text))
                {
                    errorProvider1.SetError(textBoxFName, "First Name is Required");
                    return;
                }
                else
                {
                    errorProvider1.SetError(textBoxFName, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxFName.Text))
                {
                    errorProvider2.SetError(textBoxLName, "Last Name is Required");
                    return;
                }
                else
                {
                    errorProvider2.SetError(textBoxLName, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxNIC.Text))
                {
                    errorProvider3.SetError(textBoxNIC, "Customer ID is Required");
                    return;
                }
                else
                {
                    errorProvider3.SetError(textBoxNIC, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxCTP.Text))
                {
                    errorProvider4.SetError(textBoxCTP, "Customer TP is Required");
                    return;
                }
                else
                {
                    errorProvider4.SetError(textBoxCTP, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxCarID.Text))
                {
                    errorProvider5.SetError(textBoxCarID, "Car ID is Required");
                    return;
                }
                else
                {
                    errorProvider5.SetError(textBoxCarID, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxNoOfDays.Text))
                {
                    errorProvider6.SetError(textBoxNoOfDays, "NO OF Days are Required");
                    return;
                }
                else
                {
                    errorProvider6.SetError(textBoxNoOfDays, String.Empty);
                }

                if (String.IsNullOrEmpty(dateTimePickerBookingStart.Text))
                {
                    errorProvider7.SetError(dateTimePickerBookingStart, "Date is Required");
                    return;
                }
                else
                {
                    errorProvider7.SetError(dateTimePickerBookingStart, String.Empty);
                }

                if (String.IsNullOrEmpty(dateTimePickerBookingStart.Text))
                {
                    errorProvider8.SetError(dateTimePickerBookingClose, "Date is Required");
                    return;
                }
                else
                {
                    errorProvider8.SetError(dateTimePickerBookingClose, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxPayment.Text))
                {
                    errorProvider9.SetError(textBoxPayment, "Payment is Required");
                    return;
                }
                else
                {
                    errorProvider9.SetError(textBoxPayment, String.Empty);
                }

                String CustomerNIC = textBoxNIC.Text;
                String FirstName = textBoxFName.Text;
                String LastName = textBoxLName.Text;
                String Contact = textBoxCTP.Text;

                String BookingID = labelShowBookingID.Text;
                int Days = Convert.ToInt16(textBoxNoOfDays.Text);
                String From = Convert.ToString(dateTimePickerBookingStart.Value);
                String To = Convert.ToString(dateTimePickerBookingClose.Value);
                decimal Payment = Convert.ToDecimal(textBoxPayment.Text);
                String CarID = textBoxCarID.Text;
                
                BookingCustomer bookingCustomer = new BookingCustomer();
                int Result = bookingCustomer.CheckCustomer(CustomerNIC);

                if (Result < 1)
                {
                    bookingCustomer.CreateCustomer(CustomerNIC,FirstName, LastName,Contact);

                }
                Bookings bookings = new Bookings();
                bookings.CreateBooking(BookingID,Days,From,To,Payment,CarID,CustomerNIC);



                this.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Something went wrong ....... !!!\n" + Ex.Message);
            }
        }

        private void CreateBooking_Load(object sender, EventArgs e)
        {
            Bookings bookings = new Bookings();
            int rowCount = bookings.GenarateID();
            rowCount++;
            labelShowBookingID.Text = "B00" + (rowCount.ToString()) ;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreate.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Days = Convert.ToDecimal(textBoxNoOfDays.Text);
            decimal Payment = Days * RentalRate;
            textBoxPayment.Text = Payment.ToString();
        }
    }
}
