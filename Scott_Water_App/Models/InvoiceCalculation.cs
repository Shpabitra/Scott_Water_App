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
        public double Tier1Cost { get; set; } // 1-1000 units @ 0.32
        public double Tier2Cost { get; set; } // 1001-5000 units @ 0.72
        public double Tier3Cost { get; set; } // 5001+ units @ 1.16
        public double TotalBeforeRecycle { get; set; }
        public double Recycled { get; set; } // 0.10 credit per recycled unit
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
          double remaining = UsageUnits;

            //tier 1: 0-1000
            double t1 = Math.Min(remaining, 1000);
            Tier1Cost = t1 * 0.32;
            remaining -= t1;

            //tier 2: 1001 - 5000
            if (remaining > 0)
            {
                double t2 = Math.Min(remaining, 4000); // 1001-5000 means max 4000 units in tier 2
                Tier2Cost = t2 * 0.72;
                remaining -= t2;
            }


            //tier 3: 5001+
            if (remaining > 0)


            {
                Tier3Cost = remaining * 1.16;
            }
           

            TotalBeforeRecycle = Tier1Cost + Tier2Cost + Tier3Cost;
            Recycled = RecycledUnits * 0.10; // credit for recycled units

            TotalBeforeVAT = TotalBeforeRecycle - Recycled; // apply recycled credit before VAT
            VAT = TotalBeforeVAT * 0.20; // 20% VAT
            Total = TotalBeforeVAT + VAT; // add VAT to get final total

            //Generate Unique Invoice Number
            Random rnd = new Random();
            this.InvoiceNumber = "INV-" + rnd.Next(100000, 999999).ToString(); // Example: INV-123456
            this.IssueDate = DateTime.Now.ToShortDateString(); // Set issue date to current date
        }

    }
}
