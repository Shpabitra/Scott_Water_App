using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scott_Water_App.Models;
using System.Data.Entity;//data entyty framework
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace Scott_Water_App
{
    public partial class frmInvoice : Form
    {
        // create a variable to hold the data inside this
        private InvoiceCalculation _bill;
        private Bitmap memoryImage;
        private Invoices invoices;

        // Update the constructor to accept the invoice data


        public frmInvoice(InvoiceCalculation invoice)
        {
            InitializeComponent();
            _bill = invoice; // save the passed invoice data to the class variable
                                // Display the invoice details in the list view

            DisplayBill(); 
        }

        public void DisplayBill()
        {
            //use the total usage passed from the first form
            lblTier1.Text = _bill.Tier1Cost.ToString("C");
           

            //Tier 2 (1001-5000)--
          
            lblTier2.Text = _bill.Tier2Cost.ToString("C");
           // remaining -= t2; //substract 4000 units from the remaining usage for the next tier calculation

            //Tier 3 (5001+)--
            
            lblTier3.Text = _bill.Tier3Cost.ToString("C");

            //Assign the units
            lblTotalUsageUnit.Text = _bill.UsageUnits.ToString("N0");
            lblRecycleUnit.Text = _bill.RecycledUnits.ToString("N0");
            //map the properties to the label 
            lblBusinessName.Text = _bill.BusinessName;
            lblBusinessAddress.Text = _bill.BusinessAddress;
            lblDateRange.Text = _bill.DateRange;
            lblInvoiceNumber.Text = _bill.InvoiceNumber;
            lblInvoiceIssuedDate.Text = _bill.IssueDate;
            lblReserveLevel.Text = _bill.ReserveLevel.ToString("N0") + "%";
            lblRateType.Text = _bill.RateType;
            //Assign the values to the list view items
            //use "C" to format numbers as currency
            lblTier1Unit.Text = _bill.Tier1UnitsUsed.ToString("N0");
            lblTier2Unit.Text = _bill.Tier2UnitsUsed.ToString("N0");
            lblTier3Unit.Text = _bill.Tier3UnitsUsed.ToString("N0");
            lblCpu1.Text = _bill.Tier1Rate.ToString("C");
            lblCpu2.Text = _bill.Tier2Rate.ToString("C");
            lblCpu3.Text = _bill.Tier3Rate.ToString("C");
            
            //lblTier2.Text = _bill.Tier2Cost.ToString("C");
            //lblTier3.Text = _bill.Tier3Cost.ToString("C");
            lblTotalBeforeRecycle.Text = _bill.TotalBeforeRecycle.ToString("C");
            lblRecyclePerUnit.Text = _bill.RecyclePerUnit.ToString("C");

            lblRecycleTotal.Text = _bill.RecycleTotal.ToString("C");
            lblTotalBeforeVAT.Text = _bill.TotalBeforeVAT.ToString("C");
            lblVAT.Text = _bill.VAT.ToString("C");
            lblTotal.Text = _bill.Total.ToString("C");


        }

        private void btnBacktoMeterReading_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back? Your current invoice will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                frmMeterReading meterReadingForm = new frmMeterReading();
                meterReadingForm.Show(); // Show the Meter Reading form
                this.Close(); // Close the current Invoice form
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if(memoryImage != null)
            {
                Rectangle pageArea = e.MarginBounds;
                e.Graphics.DrawImage(memoryImage, pageArea); //
            }
            if(memoryImage == null)
            {
                MessageBox.Show("Image is null");
            }
        }
        private void CaptureInvoicePanel()
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

            memoryImage = bmp.Clone(panelPrintInvoice.Bounds, bmp.PixelFormat);
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {


                panelPrintInvoice.Refresh(); // Refresh the panel to ensure all controls are up to date
                panelPrintInvoice.Update(); // Update the panel to ensure all controls are up to date

                CaptureInvoicePanel();
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Print error:" + ex.Message);
            }
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {

        }

     

      

        private void btnSaveToDataBase_Click(object sender, EventArgs e)
        {
            try
            {
                using(var db = new ScotWaterContext())
                {
                    var business = db.Businesses.FirstOrDefault(b => b.BusinessName == _bill.BusinessName);
                    // Create a new invoice entity and populate it with the data from the form
                    if (business == null)
                    {
                        MessageBox.Show("Business not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the business is not found
                    }

                    var invoice = new Invoices();

                    invoice.BusinessID = business.BusinessID;
                    invoice.InvoiceNumber = _bill.InvoiceNumber;
                    invoice.BusinessName = _bill.BusinessName;
                    invoice.BusinessAddress = _bill.BusinessAddress;
                    invoice.DateRange = _bill.DateRange;
                    invoice.InvoiceDate = _bill.InvoiceDate;
                    invoice.RateType = _bill.RateType;
                    invoice.ReserveLevel = _bill.ReserveLevel.ToString("NO");
                    invoice.TotalUsageUnits = _bill.UsageUnits;
                    invoice.RecycledUnits = _bill.RecycledUnits;
                    invoice.Tier1Unitsused = _bill.Tier1UnitsUsed.ToString("NO");
                    invoice.Tier2Unitsused = _bill.Tier2UnitsUsed.ToString("NO");
                    invoice.Tier3Unitsused = _bill.Tier3UnitsUsed.ToString("NO");
                    invoice.Tier1Rate = _bill.Tier1Rate.ToString("NO");
                    invoice.Tier2Rate = _bill.Tier2Rate.ToString("NO");
                    invoice.Tier3Rate = _bill.Tier3Rate.ToString("NO");
                    invoice.Tier1Cost = _bill.Tier1Cost.ToString("NO");
                    invoice.Tier2Cost = _bill.Tier2Cost.ToString("NO");
                    invoice.Tier3Cost = _bill.Tier3Cost.ToString("NO");
                    invoice.TotalBeforeRecycle = _bill.TotalBeforeRecycle.ToString("NO");
                    invoice.RecyclePerUnit = _bill.RecyclePerUnit.ToString("NO");
                    invoice.RecycleTotal = _bill.RecycleTotal.ToString("NO");
                    invoice.TotalBeforeVAT = _bill.TotalBeforeVAT.ToString("NO");
                    invoice.VAT = _bill.VAT.ToString("NO");
                    invoice.Total = _bill.Total.ToString("NO");

                    if(invoice== null)
                    {
                        MessageBox.Show("Invoice data is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the invoice data is null
                    }

                    // Add the new invoice entity to the database context and save changes
                    db.Invoices.Add(invoice);
                    db.SaveChanges();
                    MessageBox.Show("Invoice saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;

                if(ex.InnerException != null)
                {
                    errorMessage += "\n\n Inner Exception: " + ex.InnerException.Message;
                }

                if(ex.InnerException?.InnerException != null)
                {
                    errorMessage += "\n\n Inner Exception 2: " + ex.InnerException.InnerException.Message;
                }
                MessageBox.Show("Error saving invoice to database:\n\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       

    }
}
