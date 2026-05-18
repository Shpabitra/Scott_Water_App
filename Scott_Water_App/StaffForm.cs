using Scott_Water_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Water_App
{
    //Nathan ALlan 06/04/2026
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();

            txtConfirm.UseSystemPasswordChar = true; //hides both passwords 
            txtNewPassword.UseSystemPasswordChar = true;
        }

        //Nathan ALlan 29/04/2026
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string email = txtResetEmail.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirm.Text.Trim();

            if (email == "" || newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check passwords match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            using (var db = new ScotWaterContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == email);

                if (user == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                user.Password = newPassword;

                db.SaveChanges();

                MessageBox.Show("Password reset successfully.");
            }

            txtResetEmail.Clear();    //clears all when password is reset 
            txtNewPassword.Clear();
            txtConfirm.Clear();
            checkShowPass.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu menuForm = new frmMenu("Admin");
            menuForm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_New_Login registerForm = new Add_New_Login();
            registerForm.Show();
            this.Hide();
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkShowPass.Checked; //shows the hidden password when check box is selected 

            txtConfirm.UseSystemPasswordChar = !show;
            txtNewPassword.UseSystemPasswordChar = !show;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Nathan ALlan 06/05/2026
            txtResetEmail.Clear();
            txtNewPassword.Clear();
            txtConfirm.Clear();
            checkShowPass.Checked = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Add_New_Login registerForm = new Add_New_Login();
            registerForm.Show();

            this.Hide();
        }

        //nathan Allan 11/5/26
        private void button2_Click(object sender, EventArgs e)
        {
            string email = txtEmailUnlock.Text.Trim();

            using (var db = new ScotWaterContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == email);

                if (user == null)
                {
                    MessageBox.Show("User not found."); //if user email not in db this message says not found 
                    return;
                }

                user.IsLocked = false;
                user.FailedLoginAttempts = 0;

                db.SaveChanges();

                MessageBox.Show("User account unlocked."); //tells user there account is unlocked 
            }
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //clear old locked accounts
            lstLockedUsers.Items.Clear();

            using (var db = new ScotWaterContext())
            {
                //get locked users
                var lockedUsers = db.Users
                    .Where(u => u.IsLocked == true)
                    .ToList();

                //add users to listbox
                foreach (var user in lockedUsers)
                {
                    lstLockedUsers.Items.Add(user.Email + " - Locked");
                }
            }

            //update label count
            lblLockedCount.Text = "Locked Accounts: " + lstLockedUsers.Items.Count;

            //check if empty
            if (lstLockedUsers.Items.Count == 0)
            {
                MessageBox.Show("No locked accounts found.");
            }
        }
            
        

        private void lstLockedUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
       
        private void btnRefreshLocked_Click(object sender, EventArgs e)
        {

        }


        private void btnViewALL_Click(object sender, EventArgs e)
        {
            //Nathan Allan 11/05/2026
            //clear old items
            lstAllUsers.Items.Clear();

            using (var db = new ScotWaterContext())
            {
                //get all users
                var users = db.Users.ToList();

                //check if no users found
                if (users.Count == 0)
                {
                    MessageBox.Show("No accounts found.");
                    return;
                }

                //display users in listbox
                foreach (var user in users)
                {
                    lstAllUsers.Items.Add(
                        "Email: " + user.Email +
                        " | Role: " + user.Role);
                }

                lblAllAccountsCount.Text = "Total Accounts: " + lstAllUsers.Items.Count;

                //check if no accounts found
                if (lstAllUsers.Items.Count == 0)
                {
                    MessageBox.Show("No accounts found.");
                }
            }
        }
        

        private void RefreshLocked_Click(object sender, EventArgs e)
        {

        }
    }
    }



