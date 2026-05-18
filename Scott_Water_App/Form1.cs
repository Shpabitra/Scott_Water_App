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
        private int failedLoginAttempts = 0; // to track failed login attempts
        public frmLogin()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += frmLogin_KeyDown;
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
            //stop if already locked
            if (failedLoginAttempts >= 3)
            {
                MessageBox.Show("Incorrect login attempts 3 times. Please Contact Administration.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //06/05/26 Nathan ALlan
            using (var db = new ScotWaterContext())
            {
                string email = txtUserEmail.Text.Trim();
                string pass = txtPassword.Text.Trim();

                var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == pass);

                if (user != null)
                {
                    failedLoginAttempts = 0;

                    if (user.Role == "Admin")
                    {
                        MessageBox.Show("Logging in as Admin", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //tells user they logged in as admin 
                    }
                    else
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    frmMenu menuForm = new frmMenu(user.Role);
                    menuForm.Show();

                    this.Hide();
                }
                else
                {
                    failedLoginAttempts++;

                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}