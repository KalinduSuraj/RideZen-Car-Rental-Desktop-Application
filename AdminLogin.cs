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
    public partial class AdminLoginForm : Form
    {
        
        public AdminLoginForm()
        {
            InitializeComponent();
            

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            btnPasswordTextBox.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, btnPasswordTextBox.Width, btnPasswordTextBox.Height, 8, 8));
            btnAdminLogin.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, btnAdminLogin.Width, btnAdminLogin.Height, 8, 8));

        }
        
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxPassword.Text))
                {
                    errorProviderAdminPassword.SetError(textBoxPassword, "Password is Requred");
                    return;
                }
                else
                {
                    errorProviderAdminPassword.SetError(textBoxPassword, String.Empty);
                }

                String Admin_Password = textBoxPassword.Text;
                String Admin_UserName = "admin";

                this.Hide();
                Admin admin = new Admin();
                admin.AdminLogin(Admin_UserName,Admin_Password);
                textBoxPassword.Text = "";


            }
            catch(Exception Ex)
            {
                MessageBox.Show("Something went wrong ....... !!!\n" +Ex.Message);
            }
            
            
        }

        private void btnCounterLogin_Click(object sender, EventArgs e)
        {
            CounterLoginForm counterLogin = new CounterLoginForm();
            counterLogin.Show();

            this.Hide();



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdminLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
