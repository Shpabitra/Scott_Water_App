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
    public partial class frmWaterQuality : Form
    {
        public frmWaterQuality()
        {
            InitializeComponent();
        }
        private void frmWaterQuality_Load(object sender, EventArgs e)
        {
            LoadBusinesses();
            lblReservePercentage.Text = "";
            lblStatus.Text = "";

        }
        // Load businesses into the combo box
        private void LoadBusinesses()
        {
            try
            {
                using (var db = new Models.ScotWaterContext())
                {
                    var businesses = db.Businesses
                        .OrderBy(b => b.BusinessName)
                        .ToList();
                    cmbLocation.DataSource = businesses;
                    cmbLocation.DisplayMember = "BusinessCity";
                    cmbLocation.ValueMember = "BusinessId";
                    cmbLocation.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading businesses: {ex.Message}");
            }
        }
        //get te reserve level for the selected business
        private double GetReserveLevel(int businessId)
        {
            try
            {
                using (var db = new Models.ScotWaterContext())
                {
                    var waterLevel = db.WaterLevels
                        .Where(w => w.BusinessID == businessId)
                        .OrderByDescending(w => w.DateSet)
                        .FirstOrDefault();

                    if (waterLevel != null)
                    {
                        return waterLevel.ReservePercentage;
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving reserve level: {ex.Message}");
                return 0;
            }
        }
        //gets the selected business and
        //shows the reserve level and status for that business
        private void ShowReserveLevel()
        {
            try
            {
                if (cmbLocation.SelectedValue == null)
                {
                    lblReservePercentage.Text = "";
                    lblStatus.Text = "";
                    return;
                }
                int businessId;
                if (!int.TryParse(cmbLocation.SelectedValue.ToString(),
                    out businessId))
                    return;
                double reserveLevel = GetReserveLevel(businessId);

                lblReservePercentage.Text = reserveLevel.ToString("0.##");
                lblStatus.Text = reserveLevel < 25 ? "Drought" : "No Drought";

                if (reserveLevel >= 25)
                {
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying reserve level: {ex.Message}");
            }
        }

        //opens the water level form to change
        //the water level for the selected business
        private void btnChangeWaterLevel_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbLocation.SelectedValue == null)
                {
                    MessageBox.Show("Please select a business first.");
                    return;
                }

                int businessId = Convert.ToInt32(cmbLocation.SelectedValue);

                frmWaterLevel frmWaterLevel = new frmWaterLevel(businessId);
                frmWaterLevel.ShowDialog();
                this.Close();
                ShowReserveLevel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening water level form: {ex.Message}");
            }
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowReserveLevel();
        }
    }
}
