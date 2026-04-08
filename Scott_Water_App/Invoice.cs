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
using System.Data.Entity;//data entyty framework
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scott_Water_App
{
    public partial class frmInvoice : Form
    {
        // create a variable to hold the data inside this
        private InvoiceCalculation _bill;

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
            //Assign the values to the list view items
            //use "C" to format numbers as currency
           lblTier1.Text = _bill.Tier1Cost.ToString("C");
            lblTier2.Text = _bill.Tier2Cost.ToString("C");
            lblTier3.Text = _bill.Tier3Cost.ToString("C");
            lblTotalBeforeRecycle.Text = _bill.TotalBeforeRecycle.ToString("C");

            lblRecycle.Text = _bill.Recycled.ToString("C");
            lblTotalBeforeVAT.Text = _bill.TotalBeforeVAT.ToString("C");
            lblVAT.Text = _bill.VAT.ToString("C");
            lblTotal.Text = _bill.Total.ToString("C");


        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            //map the properties to the label 
            lblBusinessName.Text = _bill.BusinessName;
            lblBusinessAddress.Text = _bill.BusinessAddress;
            lblDateRange.Text = _bill.DateRange;
            lblInvoiceNo.Text = _bill.InvoiceNumber;
            lblInvoiceIssuedDate.Text = _bill.IssueDate;

            //Financials 
            lblTier1.Text = _bill.Tier1Cost.ToString("C");
            lblTier2.Text = _bill.Tier2Cost.ToString("C");
            lblTier3.Text = _bill.Tier3Cost.ToString("C");
            lblTotalBeforeRecycle.Text = _bill.TotalBeforeRecycle.ToString("C");
            lblRecycle.Text = _bill.Recycled.ToString("C");
            lblTotalBeforeVAT.Text = _bill.TotalBeforeVAT.ToString("C");
            lblVAT.Text = _bill.VAT.ToString("C");
            lblTotal.Text = _bill.Total.ToString("C");
        }
    }
}
