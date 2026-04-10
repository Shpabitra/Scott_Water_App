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
    public class Businesses
    {
        [Key]
        public double BusinessID { get; set; } //Primary Key
        public string BusinessName { get; set; } //Business Name
        public string BusinessEmail { get; set; } //Business Email
        public string BusinessContactNumber { get; set; } //Business Contact Number
        public string BusinessCity { get; set; } //Location of Business
        public string BusinessPostcode { get; set; } //Business Postcode
        public string ContactPerson { get; set; } //Contact Person
        public string RegistrationDate { get; set; } //Registration Date
        public string Status { get; set; } //Status of the business (active/inactive)

        public virtual ICollection<Readings> Readings { get; set; } // Navigation property to Users
    }
}
