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
    internal class BookingCustomer
    {
        public int CheckCustomer(String NIC)
        {
            int Result = 0;
            try
            {
                DB_Connection connection = new DB_Connection();
                SqlConnection sqlCon = new SqlConnection(connection.Con);
                sqlCon.Open();

                String Query = @"select* from Customer where NIC = @NIC;";


                using (SqlCommand command = new SqlCommand(Query, sqlCon))
                {
                    command.Parameters.AddWithValue("@NIC", NIC);
                    
                    Result = command.ExecuteNonQuery();

                   
                }

                sqlCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong " +ex.Message);
            }
            return Result;


        }
        public void CreateCustomer(String NIC, String First_Name, String Last_Name, String Contact)
        {
            int Result = 0;
            try
            {
                DB_Connection connection = new DB_Connection();
                SqlConnection sqlCon = new SqlConnection(connection.Con);
                sqlCon.Open();

                String Query = @"Insert into Customer(NIC,First_Name,Last_Name,Contact) 
                                         values(@NIC,@First_Name,@Last_Name,@Contact);";

                using (SqlCommand command = new SqlCommand(Query, sqlCon))
                {
                    command.Parameters.AddWithValue("@NIC", NIC);
                    command.Parameters.AddWithValue("@First_Name", First_Name);
                    command.Parameters.AddWithValue("@Last_Name", Last_Name);
                    command.Parameters.AddWithValue("@Contact", Contact);


                    Result = command.ExecuteNonQuery();


                }

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong \n(Create Customer)\n" + ex.Message);
            }
        }

        public DataTable ViewCustomer()
        {
            DataTable dt = new DataTable();
            try
            {
                DB_Connection connection = new DB_Connection();
                using (SqlConnection sqlCon = new SqlConnection(connection.Con))
                {
                    sqlCon.Open();

                    string query = "SELECT * FROM Customer";
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
