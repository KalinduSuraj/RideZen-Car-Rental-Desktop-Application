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
    public partial class AdminHomeForm : Form
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
            this.panelAdminHome.Controls.Add(childForm);
            this.panelAdminHome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public AdminHomeForm()
        {
            InitializeComponent();
            object sender = null;
            openChildForm(new AdminDefultHome(), sender);

        }

        private void AdminHome_Load(object sender, EventArgs e)
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

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file:///E:/NIBM/GUI/.GUI%20CW/GUI%20CW/Help.html");
        }

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminDefultHome(), sender);

        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnCars_Click_1(object sender, EventArgs e)
        {
            openChildForm(new AdminCars(), sender);

        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {

            this.Hide();

            AdminLoginForm AdminLogin = new AdminLoginForm();
            AdminLogin.Show();
            

        }

        private void btnViewLogin_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewLogin(), sender);
        }

        
    }
}
