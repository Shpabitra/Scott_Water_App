using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using Scott_Water_App.Models;

namespace Scott_Water_App
{
    public partial class frmInvoicesHistory : Form
    {
        private int _businessId;
        public frmInvoicesHistory()
        {
            InitializeComponent();
        }
        public frmInvoicesHistory(int businessId)
        {
            InitializeComponent();
            _businessId = businessId;
        }
        private void frmInvoicesHistory_Load(object sender, EventArgs e)
        {
            LoadInvoices();
            if (_businessId > 0)
            {
                cmbBusinessName.SelectedValue = _businessId;
                LoadInvoices(_businessId);
            }
        }
        private void LoadInvoices()
        {
            using (var context = new ScotWaterContext())
            {
                var businesses = context.Invoices
                    .OrderBy(b => b.BusinessName)
                    .ToList();

                cmbBusinessName.DataSource = businesses;
                cmbBusinessName.DisplayMember = "BusinessName";
                cmbBusinessName.ValueMember = "BusinessID";
                cmbBusinessName.SelectedValue = _businessId;
            }
        }
        private void LoadInvoices(int businessId)
        {
            using (var context = new ScotWaterContext())
            {
                var invoices = context.Invoices
                    .Where(i => i.BusinessID == _businessId)
                    .Select(i => new
                    {
                        Invoice_Number = i.InvoiceNumber,
                        Invoice_Date = i.InvoiceDate,
                        Business_Name = i.BusinessName, 
                        Business_Address = i.BusinessAddress,
                        Date_Range = i.DateRange,
                        Usage_Units = i.TotalUsageUnits,
                        Recycled_Units = i.RecycledUnits,
                        Total_Before_VAT = i.TotalBeforeVAT,
                        Vat = i.VAT,
                        Total = i.Total,
                        Tier1_Cost = i.Tier1Cost,
                        Tier2_Cost = i.Tier2Cost,
                        Tier3_Cost = i.Tier3Cost,

                    })
                    .ToList();
                dgvInvoiceHistory.DataSource = invoices;
            }

        }
        private void btnMainmenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog();
            this.Close();
        }

        private void cmbBusinessName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbBusinessName.SelectedValue is int SelectedBusinessId)
            {
                _businessId = SelectedBusinessId;
                LoadInvoices(_businessId);
            }
        }
    }
}
    
