using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            txtRegistrationDate.Text = data.RegistrationDate;
            txtStatus.Text = data.Status;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // get input from textboxes and create business object
            Businesses business = newRegBizFuncs.GetBusinessFromInputFields(
                            txtBusinessID.Text.Trim(),
                            txtBusinessName.Text.Trim(),
                            txtAddress.Text.Trim(),
                            txtPostCode.Text.Trim(),
                            txtTelephone.Text.Trim(),
                            TxtEmail.Text.Trim(),
                            txtContactPerson.Text.Trim(),
                            txtRegistrationDate.Text.Trim(),
                            txtStatus.Text.Trim());


            if (!newRegBizFuncs.inputvalidation(business))
                return;

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
                    else
                    {
                        //write new business into database
                        db.Businesses.Add(business);
                        db.SaveChanges();
                        MessageBox.Show($"Business {business.BusinessName} registered successfully!", $"Number of businesses after added: {db.Businesses.Count()}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Number of businesses after added: " + db.Businesses.Count(), "Business Count1", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to validate email in database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
