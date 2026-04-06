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
           lblBasic.Text = _bill.Tier1Cost.ToString("C") + " units";
            lblMidrange.Text = _bill.Tier2Cost.ToString("C") + " units";
            lblPremium.Text = _bill.Tier3Cost.ToString("C") + " units";
           
            lblRecycle.Text = _bill.Recycled.ToString("C");
            
           
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}
