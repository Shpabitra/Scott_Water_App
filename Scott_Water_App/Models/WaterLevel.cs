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
        public int Id { get; set; }
        public double ReservePercentage { get; set; }
        public DateTime DateSet { get; set; }
    }
}
