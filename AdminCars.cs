using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace CW
{
    public partial class AdminCars : Form
    {
        
        public AdminCars()
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

        private void clear()
        {
            textBoxCarID.Text = String.Empty;
            textBoxModel.Text = String.Empty;
            textBoxOwner.Text = String.Empty;
            textBoxContact.Text = String.Empty;
            textBoxRentalRate.Text = String.Empty;
            pictureBoxCarImage.Image = null;
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

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*.jpeg";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCarImage.Image=Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxCarID.Text))
                {
                    errorProviderCarID.SetError(textBoxCarID, "First Name is Required");
                    return;
                }
                else
                {
                    errorProviderCarID.SetError(textBoxCarID, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxModel.Text))
                {
                    errorProviderModel.SetError(textBoxModel, "First Name is Required");
                    return;
                }
                else
                {
                    errorProviderModel.SetError(textBoxModel, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxOwner.Text))
                {
                    errorProviderOwner.SetError(textBoxOwner, "First Name is Required");
                    return;
                }
                else
                {
                    errorProviderOwner.SetError(textBoxOwner, String.Empty);
                }
                if (String.IsNullOrEmpty(textBoxContact.Text))
                {
                    errorProviderContact.SetError(textBoxContact, "First Name is Required");
                    return;
                }
                else
                {
                    errorProviderContact.SetError(textBoxContact, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxRentalRate.Text))
                {
                    errorProviderRentalRate.SetError(textBoxRentalRate, "First Name is Required");
                    return;
                }
                else
                {
                    errorProviderRentalRate.SetError(textBoxRentalRate, String.Empty);
                }


                String CarID = textBoxCarID.Text;
                String Model = textBoxModel.Text;
                String Owner = textBoxOwner.Text;
                String Contact = textBoxContact.Text;
                Decimal RentalRate = Convert.ToDecimal(textBoxRentalRate.Text);
                Image image = pictureBoxCarImage.Image;

                Car car = new Car();
                int Result = car.AddCar(CarID, Model, Owner, Contact, RentalRate, image);

                if (Result > 0)
                {
                    clear();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong \n" + ex.Message);
            }
            finally
            {
                LoadCarData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxCarID.Text))
                {
                    errorProviderCarID.SetError(textBoxCarID, "First Name is Required");
                    return;
                }
                else
                {
                    errorProviderCarID.SetError(textBoxCarID, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxModel.Text))
                {
                    errorProviderModel.SetError(textBoxModel, "First Name is Required");
                    return;
                }
                else
                {
                    errorProviderModel.SetError(textBoxModel, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxOwner.Text))
                {
                    errorProviderOwner.SetError(textBoxOwner, "First Name is Required");
                    return;
                }
                else
                {
                    errorProviderOwner.SetError(textBoxOwner, String.Empty);
                }
                if (String.IsNullOrEmpty(textBoxContact.Text))
                {
                    errorProviderContact.SetError(textBoxContact, "First Name is Required");
                    return;
                }
                else
                {
                    errorProviderContact.SetError(textBoxContact, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxRentalRate.Text))
                {
                    errorProviderRentalRate.SetError(textBoxRentalRate, "First Name is Required");
                    return;
                }
                else
                {
                    errorProviderRentalRate.SetError(textBoxRentalRate, String.Empty);
                }

                string carID = textBoxCarID.Text;
                string model = textBoxModel.Text;
                string carOwner = textBoxOwner.Text;
                string contact = textBoxContact.Text;
                decimal rentalRate = decimal.Parse(textBoxRentalRate.Text);
                

                Car carManager = new Car();
                int result = carManager.UpdateCar(carID, model, carOwner, contact, rentalRate);

                if (result > 0)
                {
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong\n" + ex.Message);
            }
            finally
            {
                LoadCarData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string carID = textBoxCarID.Text;

                if (string.IsNullOrEmpty(carID))
                {
                    MessageBox.Show("Please select a car to delete.");
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this car?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Car carManager = new Car();
                    int result = carManager.DeleteCar(carID);

                    if (result > 0)
                    {
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete car.\n\n\t" + ex.Message);
            }
            finally
            {
                LoadCarData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = textBoxSearchCarID.Text;

                if (string.IsNullOrEmpty(searchValue))
                {
                    MessageBox.Show("Please enter a search value.");
                    return;
                }

                Car car = new Car();
                DataTable dt = car.SearchCar(searchValue);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewCars.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No cars found matching the search criteria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to search cars.\n\n\t" + ex.Message);
            }
        }
    }   
}
