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
        public int MeterID { get; set; }
        public int BusinessID { get; set; }
        public DateTime ReadingDate { get; set; }
        public double UsageUnits { get; internal set; }
        public double RecycledUnits { get; internal set; }
        public decimal ReserveLevel { get; set; }
    }
}
