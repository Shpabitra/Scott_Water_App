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
    public class User
    {
        [Key]
        public int UserID { get; set; } //Primary Key
        public string Email { get; set; } //User's Email
        public string Password { get; set; } //User's Password

        [ForeignKey("Businesses")]
        public int BusinessID { get; set; }
        public Businesses Businesses { get; set; }

        [ForeignKey("Readings")]
        public int MeterID { get; set; }
        public Readings Readings { get; set; }
    }
}
