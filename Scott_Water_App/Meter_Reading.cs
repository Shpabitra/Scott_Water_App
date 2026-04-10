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

       


        private void btnGenerateBill_Click(object sender, EventArgs e)
        {

            //Create the object
            InvoiceCalculation invoice = new InvoiceCalculation();

            //   //pull from the numeric up down controls and assign to the invoice object
            //info.UsageUnits = (double)nudWaterUsage.Value;
            //   info.RecycleUnits = (double)nudRecycle.Value;

            using (var db = new ScotWaterContext())
            {
                // Find the selected business in the database
                //string selectedBusiness = dudBusinessName.SelectedItem.ToString();
                var biz = db.Businesses.FirstOrDefault(b => b.BusinessName == dudBusinessName.Text);
                if (biz != null)
                {
                    //fill the invoice object with the business data and date range
                    invoice.BusinessName = biz.BusinessName;
                    invoice.BusinessAddress = $"{biz.BusinessCity}, {biz.BusinessPostcode}";
                    invoice.DateRange = dtpReadingDate.Value.ToString("DD MM yy");
                    //Assign values from the textboxes inputs
                    invoice.ReserveLevel = (double)nudReserveLevel.Value;
                    invoice.RateType = invoice.ReserveLevel < 25 ? "Low" : "Standard";
                    invoice.UsageUnits = (double)nudUsageUnits.Value;
                    invoice.RecycledUnits = (double)nudRecycleUnits.Value;

                    //run the calculation
                    invoice.CalculateInvoice();

                    //open the invoice form and pass my invoice object to it
                    frmInvoice frm = new frmInvoice(invoice);
                    frm.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Please select a valid business");
                }





            }
        }

        //private double GetReserveLevel()
        //{
        //    using (var db = new ScotWaterContext())
        //    {
        //        var reserve = db.WaterLevels

        //            .OrderByDescending(r => r.Id)
        //            .FirstOrDefault();

        //        if (reserve != null)
        //        {
        //            return reserve.ReservePercentage;


        //        }
        //        return 100;

        //    }
        //}

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
                    var existingReading = db.Readings.FirstOrDefault(r =>
                    r.BusinessID == biz.BusinessID &&
                    r.ReadingDate == dtpReadingDate.Value.Date);
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
                        RecycledUnits = (double)nudRecycleUnits.Value
                    };
                    db.Readings.Add(reading);
                    // Save the reserve level as well
                    WaterLevel wl = new WaterLevel
                    {
                        ReservePercentage = (double)nudReserveLevel.Value,
                        DateSet = DateTime.Now
                    };
                    db.WaterLevels.Add(wl);
                    db.SaveChanges();
                    MessageBox.Show("Reading saved successfully.");
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
    }
}
