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
        private int addNew;

        public frmRegisterBusiness(int addNewBusiness = 99)
        {
            //const bool testMode = true;

            InitializeComponent();
            this.Load += frmRegisterBusiness_Load;
            this.FormClosed += frmRegisterBusiness_FormClosed;
            this.cmbSelectBusiness.SelectedIndexChanged += cmbBizID_SelectedIndexChanged;
            addNew = addNewBusiness;
        }

        private void frmRegisterBusiness_Load(object sender, EventArgs e)
        {
            try
            {
                db = new ScotWaterContext();
                
                // Call the helper functions
                ToggleBusinessSelection(addNew);
                ToggleButtons(addNew);  // Add this line
                
                MessageBox.Show($"AddNew value: {addNew}", "AddNew Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var businessCount = newRegBizFuncs.GetBusinessCount(db);

                if (addNew == 2 || addNew ==0)
                {
                    cmbSelectBusiness.DataSource = newRegBizFuncs.GetBusinessNames(db, addNew);
                }
                else if (addNew == 1)
                {
                    AddNewBusiness();
                }


                MessageBox.Show("Number of businesses loaded: " + businessCount, "Business Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load business data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRegisterBusiness_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (db != null)
            {
                db.Dispose();
                db = null;
            }
        }

        // When a business is selected from the combo box, load its details into the textboxes. If "Add New Business" is selected, clear the textboxes for new input and generate a new business ID and meter ID.
        private void cmbBizID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (db == null || cmbSelectBusiness.SelectedItem == null)
                return;

            string selectedBusinessIdStr = cmbSelectBusiness.SelectedItem.ToString();

            // If "Add New Business" is selected, clear the textboxes and generate new IDs
            if (selectedBusinessIdStr == "Add New Business")
            {
                AddNewBusiness();  // Call the helper function instead
                return;
            }

            // For existing business selection, load the business info into textboxes
            // Get the business ID from the selected value in the combo box
            int? selectedBusinessId = newRegBizFuncs.GetBusinessIdFromSelectedValue(selectedBusinessIdStr, db);
            if (!selectedBusinessId.HasValue)
                return;

            // Find the selected business in the database using the business ID
            var selectedBusiness = db.Businesses.FirstOrDefault(b => b.BusinessID == selectedBusinessId.Value);
            if (selectedBusiness == null)
                return;

            // Fill the textboxes with the selected business info
            fillBusinessInfo(selectedBusiness);

            // Get the Meter ID associated with the selected business and fill it in the textbox
            var meterId = db.Readings
                .Where(r => r.BusinessID == selectedBusinessId.Value)
                .Select(r => r.MeterID)
                .FirstOrDefault();

            txtMeterID.Text = meterId == 0 ? string.Empty : meterId.ToString();
        }



        // ====================================================================================================
        // ======================================= CLICK EVENTS ===============================================
        // ====================================================================================================

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Database is not initialized.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get input from textboxes and create business object
            Businesses business = newRegBizFuncs.CreateBusinessObjectFromInputFields(
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

                    int meterId;
                    if (!int.TryParse(txtMeterID.Text.Trim(), out meterId))
                    {
                        MessageBox.Show("Invalid Meter ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var reading = new Readings
                    {
                        MeterID = meterId,
                        BusinessID = business.BusinessID,
                        ReadingDate = DateTime.Now,
                        UsageUnits = 0,
                        RecycledUnits = 0
                    };

                    db.Readings.Add(reading);
                    db.SaveChanges();

                    MessageBox.Show($"Business {business.BusinessName} registered successfully!", $"Number of businesses after added: {db.Businesses.Count()}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Number of businesses after added: " + db.Businesses.Count(), "Business Count1", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //cmbSelectBusiness.DataSource = newRegBizFuncs.GetBusinessIds(db);
                    cmbSelectBusiness.DataSource = newRegBizFuncs.GetBusinessNames(db, addNew);



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

            Businesses updatedInput = newRegBizFuncs.CreateBusinessObjectFromInputFields(
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
                    newRegBizFuncs.updateExistingBusinessInfo(existingBusiness, updatedInput);
                    db.SaveChanges();
                    MessageBox.Show($"Business {existingBusiness.BusinessName} updated successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save business changes: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // ====================================================================================================
        // ======================================= HELPER FUNCTIONS ===========================================
        // ====================================================================================================

        // Recursively clear all textboxes in the form
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

        // Fill the textboxes with business info from a given business object
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

        // Generate fake business data and fill the textboxes with it (for testing purposes)
        private void FillFakeBusinessData()
        {
            Businesses data = newRegBizFuncs.GenerateFakeBusinessData();
            fillBusinessInfo(data);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        // Helper function to toggle visibility of business selection controls
        private void ToggleBusinessSelection(int addNew)
        {
            // Show the value of hide parameter
            MessageBox.Show($"addNew value: {addNew}", "Toggle Business Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (addNew == 2) // for updating business, hide the selection controls
            {
                lblSelectBusiness.Visible = true;
                cmbSelectBusiness.Visible = true;

                lblSelectBusiness.Text = "Select Business:";

            }
            else if (addNew == 1) // for adding new business, show the selection controls
            {
                lblSelectBusiness.Visible = false;
                cmbSelectBusiness.Visible = false;

            } 
            else if (addNew == 0) // for both udpating exiting & adding new business, show the selection controls
            {
                lblSelectBusiness.Visible = true;
                cmbSelectBusiness.Visible = true;

                lblSelectBusiness.Text = "Update/New Biz:";
            }
        }

        // Helper function to toggle button visibility based on addNew value
        private void ToggleButtons(int addNew)
        {
            MessageBox.Show($"ToggleButtons called with addNew value: {addNew}", "Toggle Buttons", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (addNew == 2)
            {
                // For updating business: show save button, hide register button
                btnSave.Visible = true;
                btnRegister.Visible = false;
                btnSave.Enabled = false;
            }
            else if (addNew == 1)
            {
                // For adding new business: hide save button, show register button
                btnSave.Visible = false;
                btnRegister.Visible = true;
                btnRegister.Enabled = false;
            }
            else if (addNew == 0)
            {
                // For both updating and adding: show both buttons
                btnSave.Visible = true;
                btnRegister.Visible = true;
                btnSave.Enabled = false;
                btnRegister.Enabled = false;
            }
        }

        // Helper function to handle adding a new business
        private void AddNewBusiness()
        {
            ClearAllTextBoxes(this);

            if (testMode)
                FillFakeBusinessData();

            // Generate new Business ID by taking the max existing Business ID and adding 1
            int businessCount = newRegBizFuncs.GetBusinessCount(db) + 1;
            txtBusinessID.Text = businessCount.ToString();

            // Generate new Meter ID by taking the max existing Meter ID and adding 1, or start at 1 if there are no readings
            var newMeterId = db.Readings.Any()
                ? db.Readings.Max(r => r.MeterID) + 1
                : 1;

            txtMeterID.Text = newMeterId.ToString();
        }
    }
}
