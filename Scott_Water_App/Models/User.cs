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
        public string ConfirmPassword { get; set; } // to confirm password
        public string Role { get; set; }
        public int FailedLoginAttempts { get; set; } // counter of failed log on attemps 
        public bool IsLocked { get; set; }
    }
}