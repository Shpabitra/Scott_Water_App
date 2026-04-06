using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public double Subtotal { get; set; }
        public double Recycled { get; set; } // 0.10 credit per recycled unit
        public double TotalBeforeVAT{ get; set; }
        public double VAT{ get; set; } // 20% VAT
        public double FinalTotal { get; set; }

        //logic to calculate everything automatically
        public void CalculateInvoice()
        {
            // Calculate tiered costs based on usage
          double remaining = UsageUnits;

            //tier 1
            double t1 = Math.Min(remaining, 1000);
            Tier1Cost = t1 * 0.32;
            remaining -= t1;

            //tier 2
            double t2 = Math.Min(remaining, 5000); // 1001-5000 means max 4000 units in tier 2
            Tier2Cost = t2 * 0.72;
            remaining -= t2;

            //tier 3
            Tier3Cost = remaining > 0 ? remaining * 1.16 : 0;

            Subtotal = Tier1Cost + Tier2Cost + Tier3Cost;
            Recycled = RecycledUnits * 0.10; // credit for recycled units

            TotalBeforeVAT = Subtotal - Recycled; // apply recycled credit before VAT
            VAT = TotalBeforeVAT * 0.20; // 20% VAT
            FinalTotal = TotalBeforeVAT + VAT; // add VAT to get final total
        }

    }
}
