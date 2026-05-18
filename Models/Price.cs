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
    public class Price
    {
        [Key]
        public int PriceID { get; set; } // Primary Key
        public DateTime EffectiveDate { get; set; } 
        // Date when the price becomes effective
        public double NoDroughtTier1Rate { get; set; } // Standard Tier 1 Rate
        public double NoDroughtTier2Rate { get; set; } // Standard Tier 2 Rate
        public double NoDroughtTier3Rate { get; set; }// Standard Tier 3 Rate
        public double DroughtTier1Rate { get; set; } // Low Reserve Tier 1 Rate
        public double DroughtTier2Rate { get; set; } // Low Reserve Tier 2 Rate
        public double DroughtTier3Rate { get; set; }// Low Reserve Tier 3 Rate
        
        
        public double RecycleRate1 { get; set; } // Recycle Credit Rate for Tier 1
        public double RecycleRate2 { get; set; } // Recycle Credit Rate for Tier 2
        public double RecycleRate3 { get; set; } // Recycle Credit Rate for Tier 3
        
      //  private static Price _current;
       // public static Price Current
       // {
        //    get
          //  {
           //     if (_current == null)
            //    {
             //       using (var context = new ScotWaterContext())
             //       {
             //           _current = context.Prices.FirstOrDefault();
             // //      }
             //   }
           //   //  return _current;
          // }
       // }
    }
}
