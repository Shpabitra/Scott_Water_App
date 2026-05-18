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
using System.Runtime.CompilerServices;

namespace Scott_Water_App
{
    public partial class frmGenerateBill : Form
    {
        private ScotWaterContext db = new ScotWaterContext();
        public frmGenerateBill()
        {
            InitializeComponent();
            LoadBusinesses();
        }
        private void LoadBusinesses()
        {
            var businesses = db.Businesses.ToList();
            cmbBusinessName.DataSource = businesses;
            cmbBusinessName.DisplayMember = "BusinessName";
            cmbBusinessName.ValueMember = "BusinessID";
            cmbBusinessName.SelectedIndex = -1;
        }
        private double GetReserveLevel(int businessId)
        {
            var waterLevel = db.WaterLevels.
                Where(w => w.BusinessID == businessId)
                .OrderByDescending(w => w.DateSet)
                .FirstOrDefault();
            return waterLevel != null ? waterLevel.ReservePercentage : 0;
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            using (var db = new ScotWaterContext())
            {
                //Create the object

                if (cmbBusinessName.SelectedValue == null)
                {
                    MessageBox.Show("Please select a business.");
                    return;
                }
                int budinessId = Convert.ToInt32(cmbBusinessName.SelectedValue);
                DateTime readingDate = dtpReadingDate.Value.Date;
                //DateTime nextDate = readingDate.AddDays(1);

                var business = db.Businesses.
                    FirstOrDefault(b => b.BusinessID == budinessId);

                //MessageBox.Show("Selected BusinessID:" + businessId +
                //    "\nSelected Date:" + readingDate.ToString("dd/MM/yyyy"));

                //date and time select from the data


                var reading = db.Readings
                .FirstOrDefault(r =>
                r.BusinessID == budinessId &&
                DbFunctions.TruncateTime(r.ReadingDate) == readingDate);

                var price = db.Prices
                 .Where(p => DbFunctions.TruncateTime(p.EffectiveDate) <= readingDate)
                 .OrderByDescending(p => p.EffectiveDate)
                 .FirstOrDefault();

                var waterLevel = db.WaterLevels
                    .Where(w => w.BusinessID == budinessId &&
                   DbFunctions.TruncateTime(w.DateSet) <= readingDate)
                    .OrderByDescending(w => w.DateSet)
                    .FirstOrDefault();

                if (business == null)
                {
                    MessageBox.Show("Please select a valid business");
                    return;
                }
                if (reading == null)
                {
                    MessageBox.Show("No readings found for the selected business and date, Invoice cannot be generated.");
                    return;
                }
                if (price == null)
                {
                    MessageBox.Show("No prices found for this date");
                    return;
                }
                if (waterLevel == null)
                {
                    MessageBox.Show("Invalid Water Level");

                }
                MessageBox.Show(
                        "\nPrice Effective Date: " + price.EffectiveDate.ToShortDateString() +
                        "\nCurrent Rates" +
                        "" +
                        "\nDrought Tier1: £" + price.DroughtTier1Rate +
                        "\nDrought Tier 2: £" + price.DroughtTier2Rate +
                        "\nDrought Tier 3: £" + price.DroughtTier3Rate +
                        "\nNo Drought Tier 1: £" + price.NoDroughtTier1Rate +
                        "\nNo Drought Tier 2: £" + price.NoDroughtTier2Rate +
                        "\nNo Drought Tier 3: £" + price.NoDroughtTier3Rate +
                        "\nRecycle Rate Tier 1: £" + price.RecycleRate1 +
                        "\nRecycle Rate Tier 2: £" + price.RecycleRate2 +
                        "\nRecycle Rate Tier 3: £" + price.RecycleRate3 
                        );
                InvoiceCalculation invoice = new InvoiceCalculation(business, reading, price, waterLevel);


                //fill the invoice object with the business data and date range
                invoice.BusinessName = business.BusinessName;
                invoice.BusinessAddress = $"{business.BusinessLocation}, {business.BusinessPostcode}";
                invoice.DateRange = dtpReadingDate.Value.ToString("dd MM yy");
                //Get the reserve level for the selected business and assign to the invoice object
                //invoice.ReserveLevel = waterLevel.ReservePercentage;
                 invoice.RateType = invoice.ReserveLevel < 25 ? "Drought" : "No Drought";
                //invoice.UsageUnits = reading.UsageUnits;
                // invoice.RecycledUnits = reading.RecycledUnits;

                //run the calculation
                //InvoiceCalculation invoice = new InvoiceCalculation(business, reading, Price, WaterLevel);


                //open the invoice form and pass my invoice object to it
                frmInvoice invoiceForm = new frmInvoice(invoice);
                invoiceForm.Show();
                this.Hide();
            }
        }

        //Navigating to Menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog();
            this.Hide();
        }
        private void btnBacktoMeterReading_Click(object sender, EventArgs e)
        {
            frmMeterReading frmMeterReading = new frmMeterReading();
            frmMeterReading.ShowDialog();
            this.Hide();
        }

        private void frmGenerateBill_Load(object sender, EventArgs e)
        {
            dtpReadingDate.MaxDate = DateTime.Today;
        }
    }
}