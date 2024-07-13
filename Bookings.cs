using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW
{
    internal class Bookings
    {
        public int GenarateID()
        {
            int rowCount = 0;
            try
            {
                DB_Connection connection = new DB_Connection();
                SqlConnection sqlCon = new SqlConnection(connection.Con);
                sqlCon.Open();

                string query = @"SELECT COUNT(*) FROM Booking;";

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    rowCount = (int)command.ExecuteScalar();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong  \n"+ex.Message);
            }
            return rowCount;
        }

        public void CreateBooking(String Booking_ID, int No_oF_Days, String StartDate, String EndDate, decimal Payment, String Car_ID, String NIC)
        {
            int Result = 0;
            try
            {
                DB_Connection connection = new DB_Connection();
                using (SqlConnection sqlCon = new SqlConnection(connection.Con))
                {
                    sqlCon.Open();

                    String Query = @"Insert into Booking(Booking_ID, No_oF_Days, StartDate, EndDate, Payment, Car_ID, NIC) 
                             values(@Booking_ID, @No_oF_Days, @StartDate, @EndDate, @Payment, @Car_ID, @NIC);";
                    using (SqlCommand command = new SqlCommand(Query, sqlCon))
                    {
                        command.Parameters.AddWithValue("@Booking_ID", Booking_ID);
                        command.Parameters.AddWithValue("@No_oF_Days", No_oF_Days);
                        command.Parameters.AddWithValue("@StartDate", StartDate);
                        command.Parameters.AddWithValue("@EndDate", EndDate);
                        command.Parameters.AddWithValue("@Payment", Payment);
                        command.Parameters.AddWithValue("@Car_ID", Car_ID);
                        command.Parameters.AddWithValue("@NIC", NIC);

                        Result = command.ExecuteNonQuery();

                        if (Result > 0)
                        {
                            MessageBox.Show("Booking successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to Book Car.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong \n" + ex.Message);
            }
        }


        public DataTable ViewBooking()
        {
            DataTable dt = new DataTable();
            try
            {
                DB_Connection connection = new DB_Connection();
                using (SqlConnection sqlCon = new SqlConnection(connection.Con))
                {
                    sqlCon.Open();

                    string query = "SELECT * FROM Booking";
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

        public DataTable DashBoardView()
        {
            DataTable dt = new DataTable();
            try
            {
                DB_Connection connection = new DB_Connection();
                using (SqlConnection sqlCon = new SqlConnection(connection.Con))
                {
                    sqlCon.Open();

                    string query = @"SELECT * FROM DashboardView";
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

        public DataTable Payment()
        {
            DataTable dt = new DataTable();
            try
            {
                DB_Connection connection = new DB_Connection();
                using (SqlConnection sqlCon = new SqlConnection(connection.Con))
                {
                    sqlCon.Open();

                    string query = @"Select B.Booking_ID,B.Date,B.Car_ID,B.NIC,B.Payment 
                                            From Booking B;";
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


    }
}
