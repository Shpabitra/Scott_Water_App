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
        private ScotWaterContext db;
        const bool testMode = true;


        public frmRegisterBusiness()
        {
            //const bool testMode = true;

            InitializeComponent();
            this.Load += frmRegisterBusiness_Load;
            this.FormClosed += frmRegisterBusiness_FormClosed;
            this.cmbBizID.SelectedIndexChanged += cmbBizID_SelectedIndexChanged;

        }

        private void frmRegisterBusiness_Load(object sender, EventArgs e)

        {
            try
            {
                db = new ScotWaterContext();
                var businessCount = newRegBizFuncs.GetBusinessCount(db);
                cmbBizID.DataSource = newRegBizFuncs.GetBusinessIds(db);

                MessageBox.Show("Number of businesses loaded: " + businessCount, "Business Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load business data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBizID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (db == null || cmbBizID.SelectedItem == null)
                return;

            int selectedBusinessId;
            if (!int.TryParse(cmbBizID.SelectedItem.ToString(), out selectedBusinessId))
                return;

            var selectedBusiness = db.Businesses.FirstOrDefault(b => b.BusinessID == selectedBusinessId);
            if (selectedBusiness == null)
                return;

            fillBusinessInfo(selectedBusiness);

            var meterId = db.Readings
                .Where(r => r.BusinessID == selectedBusinessId)
                .Select(r => r.MeterID)
                .FirstOrDefault();
            textBox1.Text = meterId == 0 ? string.Empty : meterId.ToString();


        }

        private void fillBusinessInfo(Businesses business)
        {
            if (business == null)
                return;

            txtBusinessID.Text = business.BusinessID.ToString();
            txtBusinessName.Text = business.BusinessName;
            txtAddress.Text = business.BusinessCity;
            txtPostCode.Text = business.BusinessPostcode;
            txtTelephone.Text = business.BusinessContactNumber;
            TxtEmail.Text = business.BusinessEmail;
            txtContactPerson.Text = business.ContactPerson;
            txtRegistrationDate.Text = business.RegistrationDate;
            txtStatus.Text = business.Status;
        }

        private void frmRegisterBusiness_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (db != null)
            {
                db.Dispose();
                db = null;
            }
        }



        private void FillFakeBusinessData()
        {
            Businesses data = newRegBizFuncs.GenerateFakeBusinessData();

            fillBusinessInfo(data); 
            //txtBusinessID.Text = data.BusinessId;
            //txtBusinessName.Text = data.BusinessName;
            //txtAddress.Text = data.Address;
            //txtPostCode.Text = data.PostCode;
            //txtTelephone.Text = data.Telephone;
            //TxtEmail.Text = data.Email;
            //txtContactPerson.Text = data.ContactPerson;
            //textBox1.Text = data.MeterId;
            //txtRegistrationDate.Text = data.RegistrationDate;
            //txtStatus.Text = data.Status;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Database is not initialized.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

                    cmbBizID.DataSource = newRegBizFuncs.GetBusinessIds(db);

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Database is not initialized.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Businesses updatedInput = newRegBizFuncs.GetBusinessFromInputFields(
                txtBusinessID.Text.Trim(),
                txtBusinessName.Text.Trim(),
                txtAddress.Text.Trim(),
                txtPostCode.Text.Trim(),
                txtTelephone.Text.Trim(),
                TxtEmail.Text.Trim(),
                txtContactPerson.Text.Trim(),
                txtRegistrationDate.Text.Trim(),
                txtStatus.Text.Trim());

            if (!newRegBizFuncs.inputvalidation(updatedInput))
                return;

            int businessId;
            if (!int.TryParse(txtBusinessID.Text.Trim(), out businessId))
            {
                MessageBox.Show("Please select a valid Business ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBusinessID.Focus();
                return;
            }

            try
            {
                var existingBusiness = db.Businesses.FirstOrDefault(b => b.BusinessID == businessId);
                if (existingBusiness == null)
                {
                    MessageBox.Show($"Business with ID {businessId} was not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(!newRegBizFuncs.checkIfAnyBusiessInfoChanged(existingBusiness, updatedInput))
                {
                    MessageBox.Show("Nothing changed.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    existingBusiness.BusinessName = updatedInput.BusinessName;
                    existingBusiness.BusinessCity = updatedInput.BusinessCity;
                    existingBusiness.BusinessPostcode = updatedInput.BusinessPostcode;
                    existingBusiness.BusinessContactNumber = updatedInput.BusinessContactNumber;
                    existingBusiness.BusinessEmail = updatedInput.BusinessEmail;
                    existingBusiness.ContactPerson = updatedInput.ContactPerson;
                    existingBusiness.RegistrationDate = updatedInput.RegistrationDate;
                    existingBusiness.Status = updatedInput.Status;

                    db.SaveChanges();
                    MessageBox.Show($"Business {existingBusiness.BusinessName} updated successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save business changes: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);

            if (testMode)
                FillFakeBusinessData();
        }

        private void ClearAllTextBoxes(Control parent)
        {
            for (int i = 0; i < parent.Controls.Count; i++)
            {
                Control control = parent.Controls[i];

                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }

                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }

    }
}
