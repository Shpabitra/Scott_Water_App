using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Scott_Water_App.Models
{
    public class Invoices
    {
        [Key]
        public string InvoiceNumber { get; set; } //Primary Key
        public double BusinessID { get; set; } //Foreign Key to Businesses  
        public DateTime InvoiceDate { get; set; } //Date of Invoice
        public string BusinessName { get; set; } //Name of Business
        public string BusinessAddress { get; set; } //Address of Business
        public string ContactPerson { get; set; } //Contact Person for Business
        public double UsageUnits { get; set; } //Water Usage Units
        public double RecycledUnits { get; set; } //Water Recycled Units
        public double TotalAmount { get; set; } //Total Amount for Invoice
        public string DateRange { get; set; } //Date Range for the Invoice
        public string MeterID { get; set; } //Meter ID associated with the invoice
        public string ReadingDate { get; set; }
        public string ReserveLevel { get; set; }
        public string RateType { get; set; }
        public string WaterUsage { get; set; }
        public string Tier1UnitsUsed { get; set; }
        public string Tier2UnitsUsed { get; set; }
        public string Tier3UnitsUsed { get; set; }
        public string Tier1Rate { get; set; }
        public string Tier2Rate { get; set; }
        public string Tier3Rate { get; set; }
        public string Tier1Cost { get; set; }
        public string Tier2Cost { get; set; }
        public string Tier3Cost { get; set; }
        public string TotalBeforeRecycle { get; set; }
        public string RecyclePerUnit { get; set; }
        public string RecycleTotal { get; set; }
        public string TotalBeforeVAT { get; set; }
        public string VAT { get; set; }
        public string Total { get; set; }

        [ForeignKey("BusinessID")]
        public virtual Businesses Businesses { get; set; } // Navigation property to Businesses

    }
}
