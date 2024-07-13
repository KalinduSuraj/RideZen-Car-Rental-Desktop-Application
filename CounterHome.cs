using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW
{
    public partial class CounterHome : Form
    {
        private Form activeForm;
        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChange.Controls.Add(childForm);
            this.panelChange.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public CounterHome()
        {
            InitializeComponent();
            object sender = null;
            openChildForm(new DashBoard(), sender);
 

        }
        public void getName_ID(String UserID)
        {
            String name;

            try
            {
                DB_Connection connection = new DB_Connection();
                SqlConnection sqlCon = new SqlConnection(connection.Con);
                sqlCon.Open();

                String Query = @"SELECT  First_Name From Logins  WHERE UserID= @UserID ;";

                using (SqlCommand command = new SqlCommand(Query, sqlCon))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        name = reader["First_Name"].ToString();

                        labelShowUserID.Text = UserID;
                        labelShowName.Text = name;
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong\n\t" + ex.Message);
            }
        }

        private void CounterHome_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelShowTime.Text=DateTime.Now.ToLongTimeString();
            labelShowDate.Text=DateTime.Now.ToLongDateString();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelShowTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CounterLoginForm CounterLogin = new CounterLoginForm();
            CounterLogin.Show();
            this.Hide();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file:///E:/NIBM/GUI/.GUI%20CW/GUI%20CW/Help.html");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
             openChildForm(new DashBoard(), sender);
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCars(), sender);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            openChildForm(new Booking(), sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new Customer(), sender);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            openChildForm(new Payment(), sender);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new Help(), sender);
        }

        
    }
}
