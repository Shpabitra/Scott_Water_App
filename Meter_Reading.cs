using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scott_Water_App.Models;
using System.Data.Entity;//data entuity framework
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace Scott_Water_App
{
    public partial class frmMeterReading : Form
    {
        public frmMeterReading()
        {
            InitializeComponent();
        }
        //find the reserve level from the database and set the reserve
        //level numeric up down control to that value
        private double GetReserveLevel(int businessId)
        {
            
            
                using (var db = new ScotWaterContext())
                {
                //entity framework query to find the most recent water level for the selected business
                var waterLevel = db.WaterLevels
                       .Where(W=> W.BusinessID == businessId)
                       .OrderByDescending(r => r.DateSet)
                          .FirstOrDefault();

                //return the reserve percentage if a water level is found, otherwise return 0
                if (waterLevel != null)
                    {
                        return waterLevel.ReservePercentage;
                    }
                return 0;
                }
            
        }
        //when the business name selected the water reserve level
        //for that business is pulled from the database
        //and set to the reserve level
        private void dudBusinessName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if a business is selected
            if (dudBusinessName.SelectedItem == null)
                return;
           int businessId;
            using (var db = new ScotWaterContext())
                //convert the selected business name to the business id
                if (!int.TryParse(dudBusinessName.SelectedItem.ToString(), out businessId))
            return;

            //show the reserve level for the selected business
            double reserveLevel = GetReserveLevel(businessId);
               txtReserveLevel.Text = reserveLevel.ToString("0.##");
            
        }

        private void frmMeterReading_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new ScotWaterContext())
                {
                    // Load business names from the database and bind to the dropdown
                    var businessNames = db.Businesses.Select(b => b.BusinessName).ToList();
                    dudBusinessName.Items.Clear();
                    //dudBusinessName.Items.AddRange(businessNames);

                    //add the business names to the dropdown
                    foreach (var name in businessNames)
                    {
                        dudBusinessName.Items.Add(name);
                    }

                    // set the first item as default if the list is not empty
                    if (dudBusinessName.Items.Count > 0)
                    {
                        dudBusinessName.SelectedIndex = 0;
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading business names: {ex.Message}");
            }
        }

        private void btnSaveReading_Click(object sender, EventArgs e)
        {
            try
            {
                if (dudBusinessName.SelectedItem == null)
                {
                    MessageBox.Show("Please select the busiiness");
                    return;
                }
                using (var db = new ScotWaterContext())
                {
                    string selectedBusiness = dudBusinessName.Text.Trim();
                    var biz = db.Businesses.FirstOrDefault(b => b.BusinessName == selectedBusiness);
                    if (biz == null)
                    {
                        // Save the reading for the selected business
                        MessageBox.Show("Business not found. Please select a valid business.");
                        return;
                    }
                    //check if a reading already exists for the selected business and date
                    DateTime selectedDate = dtpReadingDate.Value.Date;
                    var existingReading = db.Readings.FirstOrDefault(r =>
                    r.BusinessID == biz.BusinessID &&
                    DbFunctions.TruncateTime(r.ReadingDate) == selectedDate);
                    if (existingReading != null)
                    {
                        MessageBox.Show("A reading for the selected business and date.");
                        return;
                    }
                    Readings reading = new Readings
                    {
                        BusinessID = biz.BusinessID,
                        ReadingDate = dtpReadingDate.Value.Date,
                        UsageUnits = (double)nudUsageUnits.Value,
                        RecycledUnits = (double)nudRecycleUnits.Value,
                        ReserveLevel = decimal.Parse(txtReserveLevel.Text)
                    };
                    db.Readings.Add(reading);
                    db.SaveChanges();
                    // Save the reserve level as well
                    WaterLevel wl = new WaterLevel
                    {
                        BusinessID = biz.BusinessID,
                        ReservePercentage = double.Parse(txtReserveLevel.Text),
                        DateSet = dtpReadingDate.Value.Date
                    };
                    db.WaterLevels.Add(wl);
                    db.SaveChanges();
                    //MessageBox.Show("Reading saved successfully.");
                    MessageBox.Show("Reading save successfully." +
                        "\nBusiness Id:" + reading.BusinessID +
                        "\nReading Date:" + reading.ReadingDate.ToShortDateString() +
                        "\nUsage Units:" + reading.UsageUnits +
                        "\nRecycle Units" + reading.RecycledUnits
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving reading: {ex.Message}");
            }
        }
        private void SaveReserveLevel(double reserveLevel)
        {
            try
            {
                using (var db = new ScotWaterContext())
                {
                    WaterLevel wl = new WaterLevel
                    {
                        ReservePercentage = reserveLevel,
                        DateSet = DateTime.Now
                    };
                    db.WaterLevels.Add(wl);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving reserve level: {ex.Message}");
            }
        }

        private void dudBusinessName_SelectedItemChanged(object sender, EventArgs e)
        {
            using(var db = new ScotWaterContext())
            {
                var biz = db.Businesses.FirstOrDefault(b => b.BusinessName == dudBusinessName.Text);

                if (biz != null)
                {
                    double reserveLevel = GetReserveLevel(biz.BusinessID);
                    txtReserveLevel.Text = reserveLevel.ToString();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dudBusinessName = null;
            dtpReadingDate = null;
            nudUsageUnits.Value = 0;
            nudRecycleUnits.Value = 0;
        }

        private void dtpReadingDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
