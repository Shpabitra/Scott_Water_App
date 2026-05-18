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
    //Nathan ALlan 06/05/2026
    public partial class Add_New_Login : Form 
    {
        public Add_New_Login()
        {
            InitializeComponent();

            txtNewPass.UseSystemPasswordChar = true; //hides both passwords 
            txtPassRepeat.UseSystemPasswordChar = true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            //Nathan Allan
            StaffForm staffForm = new StaffForm();
            staffForm.Show();

            this.Hide();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Nathan Allan 22/04/2026
            string email = TxtNewEmail.Text.Trim();
            string password = txtNewPass.Text.Trim();
            string repeatPassword = txtPassRepeat.Text.Trim();
            string role;


            //06/05/26 NA
            if (chkAdmin.Checked)
            {
                role = "Admin";
            }
            else
            {
                role = "Staff";
            }

            if (email == "" || password == "" || repeatPassword == "")
            {
                //Nathan Allan 22/04/2026
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!email.Contains("@") || !email.Contains(".")) //makes sure the email has @ and . 
            {
                //Nathan Allan 22/04/2026
                MessageBox.Show("Enter a valid email address.");
                return;
            }
            //tells user their passwords arent the same 
            if (password != repeatPassword)
            {
                //Nathan Allan 22/04/2026
                MessageBox.Show("Passwords Arent The Same.");
                return;
            }
            using (ScotWaterContext db = new ScotWaterContext())
            {
                //Nathan Allan 22/04/2026
                // checks if email already exists
                var existingUser = db.Users.FirstOrDefault(x => x.Email == email);

                if (existingUser != null)
                {
                    MessageBox.Show("Email already exists.");
                    return;
                }

                // creates new users
                User newUser = new User
                {
                    Email = email,
                    Password = password,
                    Role = role
                };

                db.Users.Add(newUser);
                db.SaveChanges();
            }
            //tells user they have registered 
            MessageBox.Show("User registered successfully as: " + role);

            //hides form and takes user back to staff form
            
            StaffForm staffForm = new StaffForm();
            staffForm.Show();

            this.Hide();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Nathan Allan 22/04/2026
            TxtNewEmail.Clear();
            txtNewPass.Clear();
            txtPassRepeat.Clear();
            chkAdmin.Checked = false; //unticks boxes 
            checkShowPass.Checked = false;

            TxtNewEmail.Focus(); // highligjhts the email txt box 
        }
        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            //nathan allan 22 04 2026
            bool show = checkShowPass.Checked; //shows the hidden password when check box is selected 

            txtNewPass.UseSystemPasswordChar = !show;
            txtPassRepeat.UseSystemPasswordChar = !show;
        }
        private void Add_New_Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TxtNewEmail; //Highlights the txt box 
        }

        private void s_Click(object sender, EventArgs e)
        {
            StaffForm adminForm = new StaffForm();
            adminForm.Show();

            this.Hide();
        }
    }
}