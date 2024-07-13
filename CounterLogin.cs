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
    public partial class CounterLoginForm : Form
    {   
        public CounterLoginForm()
        {
            InitializeComponent();
            textBoxUserID.Focus();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            btnUserIDTextBox.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, btnUserIDTextBox.Width, btnUserIDTextBox.Height, 8, 8));
            btnPasswordTextBox.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, btnPasswordTextBox.Width, btnPasswordTextBox.Height, 8, 8));
            btnCounterLogin.Region = Region.FromHrgn(Styles.CreateRoundRectRgn(0, 0, btnCounterLogin.Width, btnCounterLogin.Height, 8, 8));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCounterLogin_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (String.IsNullOrEmpty(textBoxUserID.Text))
                {
                    errorProviderUserID.SetError(textBoxUserID, "User ID is Required");
                    return;
                }
                else
                {
                    errorProviderUserID.SetError(textBoxUserID, String.Empty);
                }

                //Password Error provider
                if (String.IsNullOrEmpty(textBoxPassword.Text))
                {
                    errorProviderPassword.SetError(textBoxPassword, "Password is Required");
                    return;
                }
                else
                {
                    errorProviderPassword.SetError(textBoxPassword, String.Empty);
                }

                String Counter_UserID = textBoxUserID.Text;
                String Counter_Password = textBoxPassword.Text;

                this.Hide();

                Counter counter = new Counter();
                counter.CounterLogin(Counter_UserID, Counter_Password);

               
                textBoxUserID.Text = "";
                textBoxPassword.Text = "";

            }
            catch(Exception Ex)
            {
                MessageBox.Show("Something went wrong ....... !!!\n" + Ex.Message);
            }

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLogin = new AdminLoginForm();
            adminLogin.Show();

            this.Hide();


        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCounterLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
