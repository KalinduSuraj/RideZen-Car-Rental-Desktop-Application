using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace CW
{
    internal class Admin
    {
        public void AdminLogin(String username, String password)
        {
            DB_Connection connection = new DB_Connection();
            SqlConnection sqlCon = new SqlConnection(connection.Con);
            sqlCon.Open();

            String Query = @"select * from Addmin_Login where username= @username AND Password=@password";
            SqlCommand command = new SqlCommand(Query, sqlCon);
            command.Parameters.AddWithValue("@username", "admin");
            command.Parameters.AddWithValue("@password", password);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {

                AdminHomeForm adminHome = new AdminHomeForm();
                adminHome.Show();
                MessageBox.Show("Login Successful");

               // AdminLoginForm adminLoginForm = new AdminLoginForm();
                //adminLoginForm.Hide();

                
                


            }
            else
            {
                AdminLoginForm adminLoginForm = new AdminLoginForm();
                adminLoginForm.Show();
                MessageBox.Show("Invalid Password");
                
            }

            sqlCon.Close();
        }
    }
}
