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

        // Water used by business
        public int WaterUsed { get; set; }

        // Water Recycled by business
        public int WaterRecycled { get; set; }

        // Navigation: collection of businesses that reference this meter (keeps existing shape)
        public List<Businesses> Businesses { get; set; }
    }
}
