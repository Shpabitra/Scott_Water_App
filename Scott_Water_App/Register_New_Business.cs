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
            const bool testMode = true;

            InitializeComponent();

            if (testMode)
             FillFakeBusinessData();
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

            var inputEmail = TxtEmail.Text.Trim();

            try
            {
                using (var db = new ScotWaterContext())
                {
                    var businessCount = db.Businesses.Count();
                    MessageBox.Show("Number of businesses loaded: " + businessCount, "Business Count", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    var emailExists = db.Businesses.Any(b => b.BusinessEmail.ToLower() == inputEmail.ToLower());

                    if (emailExists)
                    {
                        MessageBox.Show($"Business already exist.Duplicate Business w/ email {inputEmail}", "123", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            var business = newRegBizFuncs.GetBusinessFromInputFields(
                txtBusinessID.Text.Trim(),
                txtBusinessName.Text.Trim(),
                txtAddress.Text.Trim(),
                txtPostCode.Text.Trim(),
                txtTelephone.Text.Trim(),
                TxtEmail.Text.Trim(),
                txtContactPerson.Text.Trim(),
                textBox2.Text.Trim(),
                textBox3.Text.Trim());

            MessageBox.Show($"All inputs are valid and email is available {inputEmail}. Business object created for: {business.BusinessName}", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //write into database


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
