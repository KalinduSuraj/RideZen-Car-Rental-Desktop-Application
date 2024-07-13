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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                BookingCustomer bookingCustomer = new BookingCustomer();
                DataTable dataTable = bookingCustomer.ViewCustomer();
                dataGridViewCustomer.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data. \n" + ex.Message);
            }
        }
    }
}
