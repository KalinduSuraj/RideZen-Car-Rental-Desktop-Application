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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateBooking createBooking = new CreateBooking();
            createBooking.Show();
        }

        private void LoadData()
        {
            try
            {
                Bookings bookings = new Bookings();
                DataTable datatable = bookings.ViewBooking();
                dataGridViewBooking.DataSource = datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data. \n" + ex.Message);
            }
        }


    }
}
