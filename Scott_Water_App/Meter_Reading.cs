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
            using(var db = new ScotWaterContext())
            {
                // Load business names from the database and bind to the dropdown
                var businessNames = db.Businesses.Select(b => b.BusinessName).ToList();
                dudBusinessName.Items.Clear();
                dudBusinessName.Items.AddRange(businessNames);
            }

        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {

            //Create the object
            InvoiceCalculation invoice = new InvoiceCalculation();

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
                    invoice.DateRange = $"{dtpStartDate.Value.ToShortDateString()} - {dtpEndDate.Value.ToShortDateString()}";

                    //Assign values from the textboxes inputs
                    invoice.UsageUnits = (double)nudWaterUsage.Value;
                    invoice.RecycledUnits = (double)nudRecycle.Value;

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
}
