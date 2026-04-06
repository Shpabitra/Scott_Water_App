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

        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            //Create the object
            InvoiceCalculation invoice = new InvoiceCalculation();

            //Assign values from the textboxes inputs
            invoice.UsageUnits = double.Parse(nudWaterUsage.Text);
            invoice.RecycledUnits = double.Parse(nudRecycle.Text);

            //run the math
            invoice.CalculateInvoice();

            //open the invoice form and pass my invoice object to it
            frmInvoice frm = new frmInvoice(invoice);
            frm.ShowDialog();
            this.Hide();
        }
    }
}
