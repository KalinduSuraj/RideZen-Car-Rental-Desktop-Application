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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                Bookings bookings = new Bookings();
                DataTable BookingData = bookings.DashBoardView();
                dataGridViewTodayBookings.DataSource = BookingData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data. \n" + ex.Message);
            }
        }
    }
}
