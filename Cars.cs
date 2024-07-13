using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW
{
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
            LoadCarData();
        }
        private void LoadCarData()
        {
            try
            {
                Car car = new Car();
                DataTable carData = car.ViewCar();
                dataGridViewCars.DataSource = carData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load car data. \n" + ex.Message);
            }
        }

        private void dataGridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewCars.Rows[e.RowIndex];

                    textBoxCarID.Text = row.Cells["Car_ID"].Value.ToString();
                    textBoxModel.Text = row.Cells["Model"].Value.ToString();
                    textBoxOwner.Text = row.Cells["Car_Owner"].Value.ToString();
                    textBoxContact.Text = row.Cells["Contact"].Value.ToString();
                    textBoxRentalRate.Text = row.Cells["Rental_Rate"].Value.ToString();

                    if (row.Cells["Car_Image"].Value != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])row.Cells["Car_Image"].Value;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBoxCarImage.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBoxCarImage.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n\n\t" + ex.Message);
            }
        }

        private void btnSelectCar_Click(object sender, EventArgs e)
        {
            String CarID = textBoxCarID.Text;
            String RentalRate = textBoxRentalRate.Text;
            CreateBooking createBooking = new CreateBooking();
            createBooking.Selectcar(CarID , RentalRate);
            createBooking.Show();
        }
    }
}
