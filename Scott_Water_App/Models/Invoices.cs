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
        public int BusinessID { get; set; } //Foreign Key to Businesses
        public DateTime? InvoiceDate { get; set; } //Date of Invoice
        public string BusinessName { get; set; } //Name of Business
        public string BusinessAddress { get; set; } //Address of Business
        public double ReserveLevel { get; set; } //Reserve Level at the time of the invoice
        public string RateType { get; set; } //Rate Type for the invoice
        public double TotalUsageUnits { get; set; } //Water Usage Units
        public double RecycledUnits { get; set; } //Water Recycled Units
        public string DateRange { get; set; } //Date Range for the Invoice
        //public string ReadingDate { get; set; }
        //public string WaterUsage { get; set; }
        public double Tier1Unitsused { get; set; }
        public double Tier2Unitsused { get; set; }
        public double Tier3Unitsused { get; set; }
        public double Tier1Rate { get; set; }
        public double Tier2Rate { get; set; }
        public double Tier3Rate { get; set; }
        public double Tier1Cost { get; set; }
        public double Tier2Cost { get; set; }
        public double Tier3Cost { get; set; }
        public double TotalBeforeRecycle { get; set; }
        public double RecyclePerUnit { get; set; }
        public double RecycleTotal { get; set; }
        public decimal TotalBeforeVAT { get; set; }
        public decimal VAT { get; set; }
        public decimal Total { get; set; }
        [ForeignKey("BusinessID")]
        public virtual Businesses Businesses { get; set; } // Navigation property to Businesses


    }
}