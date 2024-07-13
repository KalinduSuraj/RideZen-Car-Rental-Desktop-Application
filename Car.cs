using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW
{
    internal class Car
    {
        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public int AddCar(String Car_ID,String Model,String Car_Owner,String Contact,Decimal Rental_Rate,Image Car_Image)
        {
            int Result = 0;
            try
            {
                DB_Connection connection = new DB_Connection();
                SqlConnection sqlCon = new SqlConnection(connection.Con);
                sqlCon.Open();

                String Query = @"Insert into Car(Car_ID,Model,Car_Owner,Contact,Rental_Rate,Car_Image) 
                                        values(@Car_ID,@Model,@Car_Owner,@Contact,@Rental_Rate,@Car_Image);";
                using (SqlCommand command = new SqlCommand(Query, sqlCon))
                {
                    command.Parameters.AddWithValue("@Car_ID", Car_ID);
                    command.Parameters.AddWithValue("@Model", Model);
                    command.Parameters.AddWithValue("@Car_Owner", Car_Owner);
                    command.Parameters.AddWithValue("@Contact", Contact);
                    command.Parameters.AddWithValue("@Rental_Rate", Rental_Rate);
                    command.Parameters.AddWithValue("@Car_Image", ConvertImageToByteArray(Car_Image));


                    Result = command.ExecuteNonQuery();

                    if (Result > 0)
                    {
                        MessageBox.Show("Car Added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Add Car.");
                    }
                }

                sqlCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong \n" + ex.Message);
            }

            return Result;
        }

        public int UpdateCar(string Car_ID, string Model, string Car_Owner, string Contact, decimal Rental_Rate)
        {
            int result = 0;
            try
            {
                DB_Connection connection = new DB_Connection();
                using (SqlConnection sqlCon = new SqlConnection(connection.Con))
                {
                    sqlCon.Open();

                    string query = @"UPDATE Car 
                                     SET Model = @Model, Car_Owner = @Car_Owner, Contact = @Contact, Rental_Rate = @Rental_Rate
                                     WHERE Car_ID = @Car_ID";
                    using (SqlCommand command = new SqlCommand(query, sqlCon))
                    {
                        command.Parameters.AddWithValue("@Car_ID", Car_ID);
                        command.Parameters.AddWithValue("@Model", Model);
                        command.Parameters.AddWithValue("@Car_Owner", Car_Owner);
                        command.Parameters.AddWithValue("@Contact", Contact);
                        command.Parameters.AddWithValue("@Rental_Rate", Rental_Rate);
                       

                        result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Car Updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to Update Car.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong \n" + ex.Message);
            }

            return result;
        }

        public int DeleteCar(string Car_ID)
        {
            int result = 0;
            try
            {
                DB_Connection connection = new DB_Connection();
                using (SqlConnection sqlCon = new SqlConnection(connection.Con))
                {
                    sqlCon.Open();

                    string query = "DELETE FROM Car WHERE Car_ID = @Car_ID";
                    using (SqlCommand command = new SqlCommand(query, sqlCon))
                    {
                        command.Parameters.AddWithValue("@Car_ID", Car_ID);

                        result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Car deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete car.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong \n" + ex.Message);
            }

            return result;
        }


        public DataTable ViewCar()
        {
            DataTable dt = new DataTable();
            try
            {
                DB_Connection connection = new DB_Connection();
                using (SqlConnection sqlCon = new SqlConnection(connection.Con))
                {
                    sqlCon.Open();

                    string query = "SELECT * FROM Car";
                    using (SqlCommand command = new SqlCommand(query, sqlCon))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong \n" + ex.Message);
            }

            return dt;
        }

        public DataTable SearchCar(string searchValue)
        {
            DataTable dt = new DataTable();
            try
            {
                DB_Connection connection = new DB_Connection();
                using (SqlConnection sqlCon = new SqlConnection(connection.Con))
                {
                    sqlCon.Open();

                    string query = @"SELECT * FROM Car 
                             WHERE Car_ID LIKE '%' + @SearchValue + '%'";

                    using (SqlCommand command = new SqlCommand(query, sqlCon))
                    {
                        command.Parameters.AddWithValue("@SearchValue", searchValue);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong \n" + ex.Message);
            }

            return dt;
        }

    }
}

