using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scott_Water_App.Models;

namespace Scott_Water_App
{
    public partial class frmWaterLevel : Form
    {
        private const int PBM_SETSTATE = 0x0410;
        private const int PBST_NORMAL = 1;
        private const int PBST_ERROR = 2;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private int _businessId =0; // Store the selected business ID
        public frmWaterLevel()
        {
            InitializeComponent();
        }

        public frmWaterLevel(int businessId)
        {
            InitializeComponent();
            this._businessId = businessId;
        }

        private void frmWaterLevel_Load(object sender, EventArgs e)
        {
            LoadBusinesses();
            nudReservePercentage.Minimum = 0;
            nudReservePercentage.Maximum = 100;

            tkblevel.Minimum = 0;
            tkblevel.Maximum = 100;

            prbWater.Minimum = 0;
            prbWater.Maximum = 100;

            lblStatus.Text = "";
            if (_businessId != 0)
            {
                setSelectedBusiness();
                LoadCurrentWaterLevel();
            }
        }
        private void LoadBusinesses()
        {
            try
            {
                using (var db = new ScotWaterContext())
                {
                    var businesses = db.Businesses
                        .OrderBy(b => b.BusinessName)
                        .ToList();


                    cmbBusinessName.DataSource = businesses;
                    cmbBusinessName.DisplayMember = "BusinessCity";
                    cmbBusinessName.ValueMember = "BusinessId";
                    cmbBusinessName.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading businesses: {ex.Message}");
            }
        }
        private void setSelectedBusiness()
        {
           cmbBusinessName.SelectedValue = _businessId;
            cmbBusinessName.Enabled = false; // Disable the combo box to prevent changing the business
        }

        private void LoadCurrentWaterLevel()
        {
            double reserveLevel = GetReserveLevel(_businessId);
            UpdateReserveDisplay(reserveLevel);
        }

        private void UpdateReserveDisplay(double reserveLevel)
        {
            int value = (int)Math.Max(0, Math.Min(100, reserveLevel)); // Ensure value is between 0 and 100
            tkblevel.Value = value;
            prbWater.Value = value;
            nudReservePercentage.Value = (decimal)value;
            lblStatus.Text = value < 25 ? "Drought" : "No Drought";
        }
        //get the recent water level for the selected business
        private double GetReserveLevel(int businessId)
        {

            //connect to the database and get the most
            //recent water level for the selected business
            using (var db = new ScotWaterContext())
            {
                var waterLevel = db.WaterLevels
                    //only to get the selected business water level
                    .Where(w => w.BusinessID == businessId)
                    //newest water level first
                    .OrderByDescending(r => r.DateSet)
                    //get the most recent water level
                    .FirstOrDefault();
                if (waterLevel != null)
                {
                    return waterLevel.ReservePercentage;
                }
                return 0;
            }
        }

        private void btnSaveWaterLevel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Models.ScotWaterContext())
                {
                    // Create a new WaterLevel object and set its properties
                    WaterLevel wL = new WaterLevel
                    {
                        ReservePercentage = (double)nudReservePercentage.Value,
                        DateSet = DateTime.Now,
                        BusinessID = Convert.ToInt32(cmbBusinessName.SelectedValue)
                    };
                    // Add the new water level to the database and save changes
                    db.WaterLevels.Add(wL);
                    db.SaveChanges();
                    MessageBox.Show("Water level saved successfully!");
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;

                if (ex.InnerException != null)
                {
                    errorMessage += "\n\nInner Exception: " + ex.InnerException.Message;
                }

                if (ex.InnerException?.InnerException != null)
                {
                    errorMessage += "\n\nSQL Error: " + ex.InnerException.InnerException.Message;
                }

                MessageBox.Show(errorMessage);
            }
        }
        private void tkblevel_Scroll(object sender, EventArgs e)
        {
            int value = tkblevel.Value;

            if (nudReservePercentage.Value != value)
                nudReservePercentage.Value = value;
            if(prbWater.Value != value)
                prbWater.Value = value;
            //Set Label Text based on value
                lblStatus.Text = value < 25 ? "Drought" : "No Drought";
            // Set font size to 12
            lblStatus.Font = new Font(lblStatus.Font.FontFamily, 12);

            // Change text color
            if (value > 25)
            {
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
            }
        }
        private void nudReserve_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)nudReservePercentage.Value;
            if (value < 25)
            {
                SendMessage(prbWater.Handle, PBM_SETSTATE, (IntPtr)PBST_ERROR, IntPtr.Zero); // red
            }
            else
            {
                SendMessage(prbWater.Handle, PBM_SETSTATE, (IntPtr)PBST_NORMAL, IntPtr.Zero); // green
            }

            if (tkblevel.Value != value)
                tkblevel.Value = value;

            if(prbWater.Value != value)
                prbWater.Value = value;

            lblStatus.Text = value < 25 ? "Drought" : "No Drought";
            //Set Label Text based on value
            lblStatus.Text = value < 25 ? "Drought" : "No Drought";
            // Set font size to 12
            lblStatus.Font = new Font(lblStatus.Font.FontFamily, 12);

            // Change text color
            if (value >= 25)
            {
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMenu mainForm = new frmMenu();
            mainForm.Show();
            this.Hide();
        }

        private void cmbBusinessName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
