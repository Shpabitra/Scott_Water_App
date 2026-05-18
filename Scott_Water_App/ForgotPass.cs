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
    public partial class frmPasswordReset : Form
    {
        public frmPasswordReset()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = txtUserName1.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword1.Text.Trim();

            if(email == "" || newPassword == "" ||  confirmPassword == "")
            {
                MessageBox.Show("please complete all fields.");
                return;
            }

            if(newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match." );
                return;
            }

            using(var db = new ScotWaterContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == email);

                if (user == null)
                {
                    MessageBox.Show("User not found-");
                    return;
                }
                user.Password = newPassword;
                user.ConfirmPassword = confirmPassword;
                db.SaveChanges();

                MessageBox.Show("Password reset successful");
                
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }

        }
    }
}
