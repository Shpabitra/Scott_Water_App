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
    public class InvoiceCalculation
    {
        //to hold the invoice calculation details for a given meter reading
        public double UsageUnits { get; set; }
        public double RecycledUnits { get; set; }
        
        public double Tier1UnitsUsed { get; set; } 
        public double Tier2UnitsUsed { get; set; }
        public double Tier3UnitsUsed { get; set; }
        public double Tier1Rate { get; set; } = 0.32;
        public double Tier2Rate { get; set; } = 0.72;
        public double Tier3Rate { get; set; } = 1.16;
        public double Tier1Cost { get; set; } // 1-1000 units @ 0.32
        public double Tier2Cost { get; set; } // 1001-5000 units @ 0.72
        public double Tier3Cost { get; set; } // 5001+ units @ 1.16
        public double TotalBeforeRecycle { get; set; }
        public double RecycleUnit { get; set; }
        public double RecyclePerUnit { get; set; }
        public double RecycleTotal { get; set; } // 0.10 credit per recycled unit
        public double TotalBeforeVAT{ get; set; }
        public double VAT{ get; set; } // 20% VAT
        
        public double Total { get; set; }
        //The labels for the business
        public string BusinessName { get; set; }
        public string BusinessAddress { get; set; }
        public string DateRange { get; set; }
        public string InvoiceNumber { get; set; }
        public string IssueDate { get; set; }

        //logic to calculate everything automatically
        public void CalculateInvoice()
        {

            // Calculate tiered costs based on usage
          double remaining = this.UsageUnits;

            //tier 1: 0-1000
           this.Tier1UnitsUsed = Math.Min(remaining, 1000);
            this.Tier1Cost = this.Tier1UnitsUsed * this.Tier1Rate;
            remaining -= this.Tier1UnitsUsed;

            //tier 2: 1001 - 5000
            this.Tier2UnitsUsed = 0;
            if (remaining > 0)
            {
                this.Tier2UnitsUsed = Math.Min(remaining, 4000); // 1001-5000 means max 4000 units in tier 2
                this.Tier2Cost = this.Tier2UnitsUsed * this.Tier2Rate;
                remaining -= this.Tier2UnitsUsed;
            }
            else
            {
                this.Tier2Cost = 0;
            }


            //tier 3: 5001+
                this.Tier3UnitsUsed = 0;
            if (remaining > 0)
            {
                this.Tier3UnitsUsed = remaining;
                this.Tier3Cost = this.Tier3UnitsUsed * this.Tier3Rate;
            }
           else
            {
                this.Tier3Cost = 0;
            }

                this.TotalBeforeRecycle = this.Tier1Cost + this.Tier2Cost + this.Tier3Cost;
            this.RecyclePerUnit = 0.10; // credit per recycled unit
            this.RecycleTotal= this.RecycledUnits * this.RecyclePerUnit; // credit for recycled units

            this.TotalBeforeVAT = Math.Max(0, this.TotalBeforeRecycle - RecycleTotal); // apply recycled credit before VAT
           this.VAT = TotalBeforeVAT * 0.20; // 20% VAT
            this.Total = this.TotalBeforeVAT + this.VAT; // add VAT to get final total

            //Generate Unique Invoice Number
            Random rnd = new Random();
            this.InvoiceNumber = "INV-" + DateTime.Now.Ticks.ToString().Substring(10); // Example: INV-123456
            this.IssueDate = DateTime.Now.ToShortDateString(); // Set issue date to current date
        }

    }
}
