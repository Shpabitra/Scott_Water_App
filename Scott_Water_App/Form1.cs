using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scott_Water_App.Models;
using System.Data.Entity;//data entyty framework

namespace Scott_Water_App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // get the values from the text boxes
            string useremail = txtUserEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // validate the input (basic validation)
            if (string.IsNullOrEmpty(useremail) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new ScotWaterContext())
            {
                try
                {
                    // check if the user exists in the database
                    var user = db.Users.FirstOrDefault(u => u.Email == useremail && u.Password == password);
                    if (user != null)
                    {
                        // login successful, open the main form
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMenu mainForm = new frmMenu();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // login failed, show error message
                        MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // handle any exceptions that may occur during database access
                    MessageBox.Show("An error occurred while trying to log in: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            

        }
    }
}
