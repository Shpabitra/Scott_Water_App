using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scott_Water_App.Functions;
using Scott_Water_App.Models;

namespace Scott_Water_App
{
    public partial class frmRegisterBusiness : Form
    {


        public frmRegisterBusiness()
        {

            InitializeComponent();
            LoadBusinessFromDatabase();
            FillFakeBusinessData();
        }

        private void LoadBusinessFromDatabase()
        {
            try
            {
                using (var db = new ScotWaterContext())
                {
                    var businessCount = db.Businesses.Count();
                    MessageBox.Show("Number of businesses loaded: " + businessCount, "Business Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load business data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillFakeBusinessData()
        {
            var data = newRegBizFuncs.GenerateFakeBusinessData();

            txtBusinessID.Text = data.BusinessId;
            txtBusinessName.Text = data.BusinessName;
            txtAddress.Text = data.Address;
            txtPostCode.Text = data.PostCode;
            txtTelephone.Text = data.Telephone;
            TxtEmail.Text = data.Email;
            txtContactPerson.Text = data.ContactPerson;
            textBox1.Text = data.MeterId;
            textBox2.Text = data.RegistrationDate;
            textBox3.Text = data.Status;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string errorMessage;

            try
            {
                using (var db = new ScotWaterContext())
                {
                    var inputEmail = TxtEmail.Text.Trim();

                    var emailExists = db.Businesses.Any(b => b.BusinessEmail.ToLower() == inputEmail.ToLower());

                    if (emailExists)
                    {
                        MessageBox.Show("Business already exist.", $"Duplicate Business w/ email {inputEmail}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtEmail.Focus();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to validate email in database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("All inputs are valid and email is available.", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
