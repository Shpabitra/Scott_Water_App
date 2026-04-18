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
    public class Readings
    {
        [Key]
        public int MeterID { get; set; }   // changed to int to match FK types
        public int BusinessID { get; set; } // added to link to Businesses table

        [ForeignKey("BusinessID")]
        public virtual Businesses Businesses { get; set; } // navigation property to Businesses
        
        public DateTime ReadingDate { get; set; }


        // Water Recycled by business
       // public int WaterRecycled { get; set; }
       public double UsageUnits { get; internal set; }
        public double RecycledUnits { get; internal set; }
    }
}
