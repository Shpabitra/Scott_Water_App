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
    public class WaterLevel
    {
        [Key]
        public int WaterLevelID { get; set; }
        [Required]

        public int BusinessID { get; set; }
        [ForeignKey("BusinessID")]
        public virtual Businesses Business { get; set; }

        [Required]
        public double ReservePercentage { get; set; }

        [Required]
        public DateTime DateSet { get; set; }
    }
}
