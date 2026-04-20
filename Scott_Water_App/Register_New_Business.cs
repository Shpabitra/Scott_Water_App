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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string errorMessage;
            var isValid = newRegBizFuncs.inputValidation(
                txtBusinessID.Text.Trim(),
                txtBusinessName.Text.Trim(),
                txtAddress.Text.Trim(),
                txtPostCode.Text.Trim(),
                txtTelephone.Text.Trim(),
                TxtEmail.Text.Trim(),
                txtContactPerson.Text.Trim(),
                textBox1.Text.Trim(),
                textBox2.Text.Trim(),
                textBox3.Text.Trim(),
                out errorMessage);

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var db = new ScotWaterContext())
                {
                    var inputEmail = TxtEmail.Text.Trim();
                    int currentBusinessId;
                    var hasCurrentBusinessId = int.TryParse(txtBusinessID.Text.Trim(), out currentBusinessId);

                    var emailExists = db.Businesses.Any(b =>
                        b.BusinessEmail.ToLower() == inputEmail.ToLower() &&
                        (!hasCurrentBusinessId || b.BusinessID != currentBusinessId));

                    if (emailExists)
                    {
                        MessageBox.Show("This email address already exists in the database.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
