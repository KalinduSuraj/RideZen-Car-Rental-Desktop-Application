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
    public partial class ViewLogin : Form
    {
        Counter counter = new Counter();
        public ViewLogin()
        {
            InitializeComponent();
            LoadData();


        }

        private void LoadData()
        {
            DataTable dataTable = counter.ViewLogins();
            DataGridViewLogins.DataSource = dataTable;
        }

        private void GenarateUserID()
        {
            Counter counter = new Counter();
            int rowCount = counter.GenarateID();
            rowCount++;
            textBoxUserID.Text = "U0" + (rowCount.ToString());
        }

        private void clear()
        {
            textBoxUserID.Text = string.Empty;
            textBoxFName.Text = string.Empty;
            textBoxLName.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            GenarateUserID();
        }
        private void btnCreateLogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(textBoxFName.Text))
                {
                    errorProviderUserID.SetError(textBoxFName, "First Name is Required");
                    return;
                }
                else
                {
                    errorProviderUserID.SetError(textBoxFName, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxLName.Text))
                {
                    errorProviderFName.SetError(textBoxLName, "Last Name is Required");
                    return;
                }
                else
                {
                    errorProviderFName.SetError(textBoxLName, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxUserID.Text))
                {
                    errorProviderLName.SetError(textBoxUserID, "NIC is Required");
                    return;
                }
                else
                {
                    errorProviderLName.SetError(textBoxUserID, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxPassword.Text))
                {
                    errorProviderPassword.SetError(textBoxPassword, "Password is Required");
                    return;
                }
                else
                {
                    errorProviderPassword.SetError(textBoxPassword, String.Empty);
                }

                String UserID = textBoxUserID.Text;
                String First_Name = textBoxFName.Text;
                String Last_Name = textBoxLName.Text;
                String Password = textBoxPassword.Text;

                Counter counter = new Counter();
                counter.CreateLogin(UserID, First_Name, Last_Name, Password);
                clear();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Something went wrong ....... !!!\n" + Ex.Message);
            }
            finally
            {
                LoadData();
            }
        }

        private void DataGridViewLogins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.DataGridViewLogins.Rows[e.RowIndex]; 

                    textBoxUserID.Text = row.Cells["UserID"].Value.ToString();
                    textBoxFName.Text = row.Cells["First_Name"].Value.ToString();
                    textBoxLName.Text = row.Cells["Last_Name"].Value.ToString();
                    textBoxPassword.Text = row.Cells["Password"].Value.ToString();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Somthing Went Wrong\n\n\t" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool valid = true;

                if (String.IsNullOrEmpty(textBoxFName.Text))
                {
                    errorProviderFName.SetError(textBoxFName, "First Name is Required");
                    valid = false;
                }
                else
                {
                    errorProviderFName.SetError(textBoxFName, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxLName.Text))
                {
                    errorProviderLName.SetError(textBoxLName, "Last Name is Required");
                    valid = false;
                }
                else
                {
                    errorProviderLName.SetError(textBoxLName, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxUserID.Text))
                {
                    errorProviderUserID.SetError(textBoxUserID, "NIC is Required");
                    valid = false;
                }
                else
                {
                    errorProviderUserID.SetError(textBoxUserID, String.Empty);
                }

                if (String.IsNullOrEmpty(textBoxPassword.Text))
                {
                    errorProviderPassword.SetError(textBoxPassword, "Password is Required");
                    valid = false;
                }
                else
                {
                    errorProviderPassword.SetError(textBoxPassword, String.Empty);
                }

                if (!valid)
                {
                    return;
                }

                String UserID = textBoxUserID.Text;
                String First_Name = textBoxFName.Text;
                String Last_Name = textBoxLName.Text;
                String Password = textBoxPassword.Text;

                int Result = counter.UpdateLogin(UserID, First_Name, Last_Name, Password);

                if (Result > 0)
                {
                    clear();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Something went wrong ....... !!!\n\t" + Ex.Message);
            }
            finally
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(textBoxFName.Text))
                {
                    errorProviderUserID.SetError(textBoxUserID, "First Name is Required");
                    return;
                }
                else
                {
                    errorProviderUserID.SetError(textBoxUserID, String.Empty);
                }

                String UserID = textBoxUserID.Text;
                int result =  counter.DeleteLogin(UserID);
                if (result > 0)
                {
                    clear();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Something went wrong ....... !!!\n" + Ex.Message);
            }
            finally
            {
                LoadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = textBoxSearchUserID.Text;

                if (string.IsNullOrEmpty(searchValue))
                {
                    MessageBox.Show("Please enter a search value.");
                    return;
                }

                Counter counter = new Counter();
                DataTable dt = counter.SearchUserID(searchValue);

                if (dt.Rows.Count > 0)
                {
                    DataGridViewLogins.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Users found matching the search criteria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to search Users.\n\n\t" + ex.Message);
            }
            finally
            {
                textBoxSearchUserID.Text = "";
            }



        }

        private void textBoxSearchUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreateLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void ViewLogin_Load(object sender, EventArgs e)
        {
            GenarateUserID();
        }
        
    }
}

