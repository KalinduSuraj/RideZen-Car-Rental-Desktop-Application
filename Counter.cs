using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace CW
{
    internal class Counter
    {
       
        AdminHomeForm adminHome = new AdminHomeForm();

        public int GenarateID()
        {
            int rowCount = 0;
            try
            {
                DB_Connection connection = new DB_Connection();
                SqlConnection sqlCon = new SqlConnection(connection.Con);
                sqlCon.Open();

                string query = @"SELECT COUNT(*) FROM Logins;";

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    rowCount = (int)command.ExecuteScalar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong  \n" + ex.Message);
            }
            //MessageBox.Show("U0"+rowCount);
            return rowCount;
        }
        public void CounterLogin(String UserID, String Password)
        {
            try
            {
                DB_Connection connection = new DB_Connection();
                SqlConnection sqlCon = new SqlConnection(connection.Con);
                sqlCon.Open();

                String Query = @"select UserID,Password from Logins where UserID= @UserID AND Password=@Password";
                using (SqlCommand command = new SqlCommand(Query, sqlCon))
                {
                    command.Parameters.AddWithValue("@userID", UserID);
                    command.Parameters.AddWithValue("@password", Password);
                    command.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {

                            CounterHome counterHome = new CounterHome();
                            counterHome.getName_ID(UserID);
                            counterHome.Show();




                            MessageBox.Show("Login Successful");

                            //CounterLoginForm counterLoginForm = new CounterLoginForm();
                            //counterLoginForm.Hide();


                        }
                        else
                        {

                            CounterLoginForm counterLogin = new CounterLoginForm();
                            counterLogin.Show();
                            MessageBox.Show("Invalid Password");

                        }

                    }
                }

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong\n\t" + ex.Message);
            }
        }

        public void CreateLogin(String UserID, String First_Name, String Last_Name, String Password)
        {
            try
            {
                DB_Connection connection = new DB_Connection();
                SqlConnection sqlCon = new SqlConnection(connection.Con);
                sqlCon.Open();

                String Query = @"Insert into Logins(UserID,First_Name,Last_Name,Password) values(@UserID,@First_Name,@Last_Name,@Password);";
                using (SqlCommand command = new SqlCommand(Query, sqlCon))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@First_Name", First_Name);
                    command.Parameters.AddWithValue("@Last_Name", Last_Name);
                    command.Parameters.AddWithValue("@password", Password);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("User created successfully.");                        
                    }
                    else
                    {
                        MessageBox.Show("Failed to create user.");
                    }
                }

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong\n\n" + ex.Message);
            }

        }

        public int UpdateLogin(String UserID, String First_Name, String Last_Name, String Password)
        {
            int result = 0;

            try
            {
                DB_Connection connection = new DB_Connection();
                using (SqlConnection sqlCon = new SqlConnection(connection.Con))
                {
                    sqlCon.Open();

                    String Query = @"Update Logins SET First_Name = @First_Name, Last_Name = @Last_Name, Password = @Password WHERE UserID = @UserID;";
                    using (SqlCommand command = new SqlCommand(Query, sqlCon))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@First_Name", First_Name);
                        command.Parameters.AddWithValue("@Last_Name", Last_Name);
                        command.Parameters.AddWithValue("@Password", Password);

                        result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Update successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update user.");
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Database error ....... !!!\n\t" + Ex.Message);
            }

            return result;
        }


        public int DeleteLogin(String UserID)
        {
            int result = 0;
            try
            {
                DB_Connection connection = new DB_Connection();
                SqlConnection sqlCon = new SqlConnection(connection.Con);
                sqlCon.Open();

                
                String Query = @"DELETE FROM Logins WHERE UserID=@UserID;";
                using (SqlCommand command = new SqlCommand(Query, sqlCon))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show(" Delete Login successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Login.");
                    }
                }
                sqlCon.Close();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong\n\n\t" + ex.Message);
                return 0;
            }

            
        }

        public DataTable ViewLogins()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DB_Connection connection = new DB_Connection();
                SqlConnection sqlCon = new SqlConnection(connection.Con);
                sqlCon.Open();

                String Query = @"SELECT * FROM Logins";

                using (SqlCommand command = new SqlCommand(Query, sqlCon))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(dataTable);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong\n\t" + ex.Message);
            }
            return dataTable;
        }

        public DataTable SearchUserID(String UserID)
        {
            DataTable dataTable = new DataTable();

            DB_Connection connection = new DB_Connection();
            
            try
            {
                SqlConnection sqlCon = new SqlConnection(connection.Con);
                sqlCon.Open();

                String Query = @"SELECT * FROM Logins WHERE UserID LIKE '%'+ @UserID +'%'";

                using (SqlCommand command = new SqlCommand(Query, sqlCon))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(dataTable);
                    
                }
                sqlCon.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong\n\t" + ex.Message);
            }
            return dataTable;
            
        }

    }
}
